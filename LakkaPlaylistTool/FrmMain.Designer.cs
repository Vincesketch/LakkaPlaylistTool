namespace LakkaPlaylistTool
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLoadLakkaList = new System.Windows.Forms.Button();
            this.txtLakkaList = new System.Windows.Forms.TextBox();
            this.txtLakkaRom = new System.Windows.Forms.TextBox();
            this.btnLoadRomDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRetro = new System.Windows.Forms.Button();
            this.txtRetro = new System.Windows.Forms.TextBox();
            this.btnRetroImageDir = new System.Windows.Forms.Button();
            this.txtRetroImage = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxCrc32 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadLakkaList
            // 
            this.btnLoadLakkaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadLakkaList.Location = new System.Drawing.Point(3, 3);
            this.btnLoadLakkaList.Name = "btnLoadLakkaList";
            this.btnLoadLakkaList.Size = new System.Drawing.Size(284, 84);
            this.btnLoadLakkaList.TabIndex = 0;
            this.btnLoadLakkaList.Text = "1. 加载Lakka列表文件(lpl文件，可选)";
            this.btnLoadLakkaList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnLoadLakkaList, "可对格式有问题的Lakka游戏列表重新格式化，如果没有问题，不需要选择此项");
            this.btnLoadLakkaList.UseVisualStyleBackColor = true;
            this.btnLoadLakkaList.Click += new System.EventHandler(this.btnLoadLakkaList_Click);
            // 
            // txtLakkaList
            // 
            this.txtLakkaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLakkaList.Location = new System.Drawing.Point(293, 3);
            this.txtLakkaList.Multiline = true;
            this.txtLakkaList.Name = "txtLakkaList";
            this.txtLakkaList.ReadOnly = true;
            this.txtLakkaList.Size = new System.Drawing.Size(478, 84);
            this.txtLakkaList.TabIndex = 1;
            // 
            // txtLakkaRom
            // 
            this.txtLakkaRom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLakkaRom.Location = new System.Drawing.Point(293, 273);
            this.txtLakkaRom.Multiline = true;
            this.txtLakkaRom.Name = "txtLakkaRom";
            this.txtLakkaRom.ReadOnly = true;
            this.txtLakkaRom.Size = new System.Drawing.Size(478, 84);
            this.txtLakkaRom.TabIndex = 3;
            // 
            // btnLoadRomDir
            // 
            this.btnLoadRomDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadRomDir.Location = new System.Drawing.Point(3, 273);
            this.btnLoadRomDir.Name = "btnLoadRomDir";
            this.btnLoadRomDir.Size = new System.Drawing.Size(284, 84);
            this.btnLoadRomDir.TabIndex = 2;
            this.btnLoadRomDir.Text = "3. 选择游戏ROM目录";
            this.btnLoadRomDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnLoadRomDir, "将根据此目录下的rom生成的Lakka游戏列表（比如：\\\\LAKKA\\ROMs\\fba）");
            this.btnLoadRomDir.UseVisualStyleBackColor = true;
            this.btnLoadRomDir.Click += new System.EventHandler(this.btnLoadRomDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(293, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 90);
            this.label1.TabIndex = 5;
            this.label1.Text = "工具主要作用：将复古Pi的游戏列表转换为Lakka格式，并且将图片重名为Lakka格式";
            // 
            // btnWrite
            // 
            this.btnWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWrite.Location = new System.Drawing.Point(3, 363);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(284, 84);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "4. 保存新的Lakka列表（和图片）";
            this.btnWrite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnWrite, "如果选择了Retro图片目录，那么生成列表的同时会在相同目录下生成图片目录");
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRetro
            // 
            this.btnRetro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetro.Location = new System.Drawing.Point(3, 93);
            this.btnRetro.Name = "btnRetro";
            this.btnRetro.Size = new System.Drawing.Size(284, 84);
            this.btnRetro.TabIndex = 7;
            this.btnRetro.Text = "1. 加载Retro列表文件(gamelist.xml)";
            this.btnRetro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnRetro, "加载Retro游戏列表文件到内存，用于生成Lakka格式列表");
            this.btnRetro.UseVisualStyleBackColor = true;
            this.btnRetro.Click += new System.EventHandler(this.btnRetro_Click);
            // 
            // txtRetro
            // 
            this.txtRetro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRetro.Location = new System.Drawing.Point(293, 93);
            this.txtRetro.Multiline = true;
            this.txtRetro.Name = "txtRetro";
            this.txtRetro.ReadOnly = true;
            this.txtRetro.Size = new System.Drawing.Size(478, 84);
            this.txtRetro.TabIndex = 8;
            // 
            // btnRetroImageDir
            // 
            this.btnRetroImageDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetroImageDir.Location = new System.Drawing.Point(3, 183);
            this.btnRetroImageDir.Name = "btnRetroImageDir";
            this.btnRetroImageDir.Size = new System.Drawing.Size(284, 84);
            this.btnRetroImageDir.TabIndex = 10;
            this.btnRetroImageDir.Text = "2. 选择Retro图片目录(可选)";
            this.btnRetroImageDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnRetroImageDir, "选择了图片目录, 在生成列表的同时会生成一个Lakka格式的图片目录");
            this.btnRetroImageDir.UseVisualStyleBackColor = true;
            this.btnRetroImageDir.Click += new System.EventHandler(this.btnRetroImageDir_Click);
            // 
            // txtRetroImage
            // 
            this.txtRetroImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRetroImage.Location = new System.Drawing.Point(293, 183);
            this.txtRetroImage.Multiline = true;
            this.txtRetroImage.Name = "txtRetroImage";
            this.txtRetroImage.ReadOnly = true;
            this.txtRetroImage.Size = new System.Drawing.Size(478, 84);
            this.txtRetroImage.TabIndex = 11;
            // 
            // cbxCrc32
            // 
            this.cbxCrc32.AutoSize = true;
            this.cbxCrc32.Location = new System.Drawing.Point(777, 363);
            this.cbxCrc32.Name = "cbxCrc32";
            this.cbxCrc32.Size = new System.Drawing.Size(56, 19);
            this.cbxCrc32.TabIndex = 12;
            this.cbxCrc32.Text = "CRC32";
            this.toolTip1.SetToolTip(this.cbxCrc32, "生成CRC32会耗费比较长的时间");
            this.cbxCrc32.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Controls.Add(this.btnRetro, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLakkaList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadLakkaList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnWrite, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtRetroImage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRetro, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLakkaRom, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnRetroImageDir, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadRomDir, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxCrc32, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 450);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lakka游戏列表维护工具  |  作者QQ:178029200";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadLakkaList;
        private System.Windows.Forms.TextBox txtLakkaList;
        private System.Windows.Forms.TextBox txtLakkaRom;
        private System.Windows.Forms.Button btnLoadRomDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRetro;
        private System.Windows.Forms.TextBox txtRetro;
        private System.Windows.Forms.Button btnRetroImageDir;
        private System.Windows.Forms.TextBox txtRetroImage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cbxCrc32;
    }
}

