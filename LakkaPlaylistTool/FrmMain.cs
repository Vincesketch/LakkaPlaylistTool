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
            Form frm = new FrmRetro();
            frm.ShowDialog(this);
            frm.Dispose();
        }

        

        
    }
}
