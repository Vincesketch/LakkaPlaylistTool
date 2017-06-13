using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LakkaPlaylistTool
{
    public partial class FrmRetro : Form
    {
        public FrmRetro()
        {
            InitializeComponent();
        }

        private void btnRetro_Click(object sender, EventArgs e)
        {

            //OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Multiselect = false;
            //fileDialog.Title = "请选择Retro游戏列表文件";
            //fileDialog.Filter = "所有文件(*.xml)|*.xml";
            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    foreach (string file in fileDialog.FileNames)
            //    {
            //        this.txtRetro.Text = file;
            //        // Read into memory
            //        Dictionary<string, GameItem> games = readRetroGames(file);
            //        // Merge to Data Base
            //        foreach (GameItem item in games.Values)
            //        {
            //            m_games[item.V1RomFullFileName] = item;
            //        }
            //        this.label1.Text = ("载入<" + games.Count.ToString() + ">个游戏到内存，目前内存共有<" + m_games.Count.ToString() + ">个游戏");
            //    }

            //}
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

        }
    }
}
