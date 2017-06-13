using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LakkaPlaylistTool
{

    public partial class FrmLakka : Form
    {
        /// <summary>
        /// Key : ROM name, wolf
        /// </summary>
        private Dictionary<string, GameItem> m_games = new Dictionary<string, GameItem>();
        /// <summary>
        /// Key : ROM name, wolf
        /// </summary>
        private Dictionary<string, FileInfo> m_roms = new Dictionary<string, FileInfo>();

        /// <summary>
        /// Key : ROM name, wolf
        /// </summary>
        private Dictionary<string, FileInfo> m_images = new Dictionary<string, FileInfo>();

        private List<GameItem> m_filterGames = new List<GameItem>();


        public FrmLakka()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadLakkaList_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择Lakka游戏列表文件";
            fileDialog.Filter = "所有文件(*.lpl)|*.lpl";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in fileDialog.FileNames)
                {
                    this.txtLakkaList.Text = file;
                    // Read into memory
                    m_games = readLakkaGames(file);
                    this.label1.Text = ("载入<" + m_games.Count.ToString() + ">个ROM到内存。");
                }

            }
        }
        private void btnLoadRomDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Lakka ROM文件夹路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                txtLakkaRom.Text = foldPath;
                m_roms = readRomToMem(foldPath);
                this.label1.Text = ("检测到<" + m_roms.Count.ToString() + ">个游戏ROM");
            }
        }

        private string readLine(StreamReader sr)
        {
            if (sr.EndOfStream)
            {
                return "";
            }

            string s = sr.ReadLine();
            if (s.Contains("<hidden>") || s.Trim().Length == 0)
            {
                s = sr.ReadLine();
            }
            return s.Trim();
        }
        private Dictionary<string, GameItem> readLakkaGames(string filePath)
        {
            StreamReader reader = File.OpenText(filePath);
            Dictionary<string, GameItem> games = new Dictionary<string, GameItem>();
            while (!reader.EndOfStream)
            {
                GameItem item = new GameItem();
                item.V1RomFullFileName = readLine(reader);
                if (item.V1RomFullFileName.Contains("."))
                {
                    games.Add(item.V1RomFullFileName, item);

                }
                else
                {
                    this.label1.Text = "警告, ROM <" + item.V1RomFullFileName + "> 不是文件, 忽略.";
                }
                item.V2RomCnName = readLine(reader);
                item.V3coreBinaryPath = readLine(reader);
                item.V4EmuType = readLine(reader);
                item.V5Crc32 = readLine(reader);
                item.V6pListName = readLine(reader);

                item.handleSpecialChars();
            }
            reader.Close();
            return games;
        }
        private void writeStrToFile(FileStream fStream, string str)
        {
            byte[] data1 = System.Text.Encoding.UTF8.GetBytes(str);
            fStream.Write(data1, 0, data1.Length);

            byte[] data7 = System.Text.Encoding.UTF8.GetBytes("\r\n");
            fStream.Write(data7, 0, data7.Length);
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {

        }
        private void btnRetroImageDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择ROM图片文件夹路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                txtRetroImage.Text = foldPath;

                m_images = readImgToMem(foldPath);
                this.label1.Text = ("检测到<" + m_images.Count.ToString() + ">个图片");
            }
        }

        private Dictionary<string, FileInfo> readRomToMem(string dir)
        {
            Dictionary<string, FileInfo> roms = new Dictionary<string, FileInfo>();
            FileInfo[] fileList = new DirectoryInfo(dir).GetFiles();
            foreach (FileInfo file in fileList)
            {
                roms.Add(file.Name.Split('.').First(), file);
            }
            return roms;
        }

        private Dictionary<string, FileInfo> readImgToMem(string dir)
        {
            Dictionary<string, FileInfo> images = new Dictionary<string, FileInfo>();
            // 加载所有图片到内存中
            FileInfo[] fileList = new DirectoryInfo(dir).GetFiles("*.jpg");
            foreach (FileInfo file in fileList)
            {
                images.Add(file.Name.Split('.').First(), file);
            }
            fileList = new DirectoryInfo(dir).GetFiles("*.png");
            foreach (FileInfo file in fileList)
            {
                images.Add(file.Name.Split('.').First(), file);
            }
            return images;
        }
        private void readImageBitToMem(List<GameItem> games)
        {
            if (txtRetroImage.Text.Length > 0)
            {
                foreach (GameItem item in games)
                {
                    FileInfo fi = null;
                    if (!m_images.TryGetValue(item.getRomShortFileNameWithOutExtension(), out fi))
                    {
                        m_images.TryGetValue(item.V2RomCnName, out fi);
                    }
                    if (fi != null)
                    {
                        item.image = Image.FromFile(fi.FullName);
                        item.imageFullName = fi.FullName;
                    }
                }
            }
        }
        private int doAction(List<GameItem> games, string newFileName)
        {
            int count = 0;
            if (games.Count() == 0) return 0;
            //输出
            FileStream fs = File.Create(newFileName);
            foreach (GameItem item in games)
            {
                if (!m_roms.ContainsKey(item.getRomShortFileNameWithOutExtension())) continue;
                if (this.cbxCrc32.Checked) item.V5Crc32 = FileToCRC32.GetLakkaCRC32(m_roms[item.getRomShortFileNameWithOutExtension()].FullName);
                writeStrToFile(fs, item.V1RomFullFileName);
                writeStrToFile(fs, item.V2RomCnName);
                writeStrToFile(fs, item.V3coreBinaryPath);
                writeStrToFile(fs, item.V4EmuType);
                writeStrToFile(fs, item.V5Crc32);
                writeStrToFile(fs, item.V6pListName);
                count++;
            }
            fs.Flush();
            fs.Close();

            // 重新拷贝ROM
            FileInfo fi1 = new FileInfo(newFileName);
            string newRomDir = fi1.DirectoryName + "\\" + fi1.Name + "_ROM";
            Directory.CreateDirectory(newRomDir);
            foreach (GameItem item in games)
            {
                FileInfo fi = m_roms[item.getRomShortFileNameWithOutExtension()];
                string newRomName = newRomDir + "\\" + item.getRomShortFileNameWithOutExtension() + fi.Extension;
                try
                {
                    // 对每一个rom
                    if (!File.Exists(newRomName))
                    {
                        fi.CopyTo(newRomName);
                    }
                }
                catch (Exception ex)
                {
                    this.label1.Text += ex.Message;
                }
            }

            if (txtRetroImage.Text.Length > 0)
            {
                // 创建新的图片目录
                FileInfo fi = new FileInfo(newFileName);
                string newImageDir = fi.DirectoryName + "\\" + fi.Name + "_IMAGE";
                Directory.CreateDirectory(newImageDir);
                foreach (GameItem item in games)
                {
                    if (item.imageFullName != "")
                    {
                        FileInfo ff = new FileInfo(item.imageFullName);
                        string newImageName = newImageDir + "\\" + item.V2RomCnName + ff.Extension;
                        try
                        {
                            // 对每一个rom，找图片并且拷贝到新名字中
                            if (!File.Exists(newImageName))
                            {
                                ff.CopyTo(newImageName);
                            }
                        }
                        catch (Exception ex)
                        {
                            this.label1.Text += ex.Message;
                        }

                    }
                }
            }

            return count;
        }

        private Dictionary<string, GameItem> readRetroGames(string filePath)
        {
            Dictionary<string, GameItem> games = new Dictionary<string, GameItem>();

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNode gameList = doc.SelectSingleNode("gameList");
            foreach (XmlNode game in gameList.ChildNodes)
            {
                GameItem item = new GameItem();
                // 将节点转换为元素，便于得到节点的属性值
                XmlElement xe = (XmlElement)game;
                item.V1RomFullFileName = "LAKKA_ROM_DIR/" + xe.SelectSingleNode("path").InnerText.Split('/').Last<string>();
                item.V2RomCnName = xe.SelectSingleNode("name").InnerText.Trim().Replace("/", ""); ;
                item.V3coreBinaryPath = "DETECT_CORE";
                item.V4EmuType = "DETECT_TYPE";
                item.V5Crc32 = "DETECT";
                item.V6pListName = "PLAY_LIST_FILE_NAME";
                item.handleSpecialChars();
                //if (xe.SelectSingleNode("image") != null)
                //{
                //    item.image = xe.SelectSingleNode("image").InnerText.Trim().Split('/').Last<string>();
                //}
                //if (item.image.Length == 0)
                //{
                //    item.image = item.a2RomCnName;
                //}
                games.Add(item.V1RomFullFileName, item);
            }
            return games;
        }

        void CheckAll()
        {
            List<string> removeList = new List<string>();
            foreach (GameItem game in m_games.Values)
            {
                if (!m_roms.ContainsKey(game.getRomShortFileNameWithOutExtension()) &&
                    !m_roms.ContainsKey(game.V2RomCnName))
                {
                    removeList.Add(game.getRomShortFileNameWithOutExtension());
                }
            }
            foreach (string s in removeList)
            {
                m_games.Remove(s);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (m_games.Count == 0 || m_roms.Count == 0)
            {
                MessageBox.Show("请先进行选择");
                return;
            }
            CheckAll();

            //排序
            List<GameItem> sortedList = new List<GameItem>();
            sortedList.AddRange(m_games.Values);
            sortedList.Sort();

            readImageBitToMem(sortedList);

            FrmEditRoms frm = new FrmEditRoms();
            frm.m_games = sortedList;
            frm.ShowDialog();
            this.m_filterGames = frm.m_games;
            frm.Dispose();
            this.label1.Text = ("编辑<" + this.m_filterGames.Count.ToString() + ">个ROM");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_games.Count == 0 || m_roms.Count == 0)
            {
                MessageBox.Show("请先进行选择");
                return;
            }
            CheckAll();
            //--------------------------------------------------------------------
            int count = 0;
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "保存Lakka游戏列表文件";
            fileDialog.Filter = "所有文件(*.lpl)|*.lpl";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                count = doAction(this.m_filterGames, fileDialog.FileName);

            }
            this.label1.Text = ("保存<" + count.ToString() + ">个rom到新文件中");
            MessageBox.Show(this.label1.Text);
        }
    }
}
