using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace LakkaPlaylistTool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLakka_Click(object sender, EventArgs e)
        {
            Form frm = new FrmLakka();
            frm.ShowDialog(this);
            frm.Dispose();
        }

        private void btnRetro_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择Retro游戏列表文件";
            fileDialog.Filter = "所有文件(*.xml)|*.xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in fileDialog.FileNames)
                {
                    // Read into memory
                    Dictionary<string, GameItem> games = readRetroGames(file);

                    FileInfo fi = new FileInfo(file);
                    string newLakkaFileName = fi.DirectoryName + "\\" + fi.Name.Split('.').First() + ".lpl";

                    FileStream fs = File.Create(newLakkaFileName);
                    foreach (GameItem item in games.Values)
                    {
                        writeStrToFile(fs, item.V1RomFullFileName);
                        writeStrToFile(fs, item.V2RomCnName);
                        writeStrToFile(fs, item.V3coreBinaryPath);
                        writeStrToFile(fs, item.V4EmuType);
                        writeStrToFile(fs, item.V5Crc32);
                        writeStrToFile(fs, item.V6pListName);
                    }
                    fs.Flush();
                    fs.Close();
                    MessageBox.Show("成功转换<" + games.Count.ToString() + ">个游戏");
                }

            }
        }

        private void btnGenerateLakka_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Lakka ROM文件夹路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(foldPath);
                FileInfo[] files = di.GetFiles();//di.GetFiles("*.zip");
                Dictionary<string, GameItem> games = new Dictionary<string, GameItem>();
                foreach (FileInfo fi in files)
                {
                    GameItem item = new GameItem();
                    item.V1RomFullFileName = fi.FullName;
                    item.V2RomCnName = item.getRomShortFileNameWithOutExtension();
                    item.V3coreBinaryPath = "DETECT_CORE";
                    item.V4EmuType = "DETECT_TYPE";
                    item.V5Crc32 = "DETECT";
                    item.V6pListName = "PLAY_LIST_FILE_NAME";
                    item.removeUnSupportedFileChar();
                    games.Add(item.V1RomFullFileName, item);
                }

                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Title = "保存Lakka游戏列表文件";
                fileDialog.Filter = "所有文件(*.lpl)|*.lpl";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    //排序
                    List<GameItem> sortedList = new List<GameItem>();
                    sortedList.AddRange(games.Values);
                    sortedList.Sort();

                    FileStream fs = File.Create(fileDialog.FileName);
                    foreach (GameItem item in sortedList)
                    {
                        writeStrToFile(fs, item.V1RomFullFileName);
                        writeStrToFile(fs, item.V2RomCnName);
                        writeStrToFile(fs, item.V3coreBinaryPath);
                        writeStrToFile(fs, item.V4EmuType);
                        writeStrToFile(fs, item.V5Crc32);
                        writeStrToFile(fs, item.V6pListName);
                    }
                    fs.Flush();
                    fs.Close();
                    MessageBox.Show("成功转换<" + games.Count.ToString() + ">个游戏");
                }
            }
        }

        private void writeStrToFile(FileStream fStream, string str)
        {
            byte[] data1 = System.Text.Encoding.UTF8.GetBytes(str);
            fStream.Write(data1, 0, data1.Length);

            byte[] data7 = System.Text.Encoding.UTF8.GetBytes("\r\n");
            fStream.Write(data7, 0, data7.Length);
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
                item.removeUnSupportedFileChar();
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

        private void btnLakka2Retro_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择Retro游戏列表文件";
            fileDialog.Filter = "所有文件(*.lpl)|*.lpl";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in fileDialog.FileNames)
                {
                    // Read into memory
                    FrmLakka frm = new FrmLakka();
                    Dictionary<string, GameItem> games = frm.readLakkaGames(file);

                    FileInfo fi = new FileInfo(file);
                    string newRetroFileName = fi.DirectoryName + "\\" + fi.Name.Split('.').First() + ".xml";
                    XmlDocument xmlDoc = new XmlDocument();
                    XmlDeclaration Declaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
                    XmlNode rootNode = xmlDoc.CreateElement("gameList");
                    xmlDoc.AppendChild(rootNode);
                    foreach (GameItem item in games.Values)
                    {
                        XmlNode gameNode = xmlDoc.CreateElement("game");
                        rootNode.AppendChild(gameNode);

                        XmlNode pathNode = xmlDoc.CreateElement("path");
                        pathNode.InnerText = item.V1RomFullFileName;
                        gameNode.AppendChild(pathNode);

                        XmlNode nameNode = xmlDoc.CreateElement("name");
                        nameNode.InnerText = item.V2RomCnName;
                        gameNode.AppendChild(nameNode);

                        XmlNode imgNode = xmlDoc.CreateElement("image");
                        imgNode.InnerText = item.V2RomCnName + ".png";
                        gameNode.AppendChild(imgNode);

                        XmlNode vdoNode = xmlDoc.CreateElement("video");
                        vdoNode.InnerText = item.getRomShortFileNameWithOutExtension() + ".mp4";
                        gameNode.AppendChild(vdoNode);
                    }
                    xmlDoc.InsertBefore(Declaration, xmlDoc.DocumentElement);
                    xmlDoc.Save(newRetroFileName);
                    MessageBox.Show("成功转换<" + games.Count.ToString() + ">个游戏到文件<" + newRetroFileName + ">中。");
                }

            }
        }
    }
}
