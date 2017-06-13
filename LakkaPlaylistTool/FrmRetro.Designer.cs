namespace LakkaPlaylistTool
{
    partial class FrmRetro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRetro = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtRetroImage = new System.Windows.Forms.TextBox();
            this.txtRetro = new System.Windows.Forms.TextBox();
            this.txtLakkaRom = new System.Windows.Forms.TextBox();
            this.btnRetroImageDir = new System.Windows.Forms.Button();
            this.btnLoadRomDir = new System.Windows.Forms.Button();
            this.cbxCrc32 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.btnRetro, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 456);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnRetro
            // 
            this.btnRetro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetro.Location = new System.Drawing.Point(3, 94);
            this.btnRetro.Name = "btnRetro";
            this.btnRetro.Size = new System.Drawing.Size(217, 85);
            this.btnRetro.TabIndex = 7;
            this.btnRetro.Text = "1. 加载Retro列表文件(gamelist.xml)";
            this.btnRetro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetro.UseVisualStyleBackColor = true;
            this.btnRetro.Click += new System.EventHandler(this.btnRetro_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWrite.Location = new System.Drawing.Point(3, 367);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(217, 86);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "4. 保存新的Lakka列表（和图片）";
            this.btnWrite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtRetroImage
            // 
            this.txtRetroImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRetroImage.Location = new System.Drawing.Point(226, 185);
            this.txtRetroImage.Multiline = true;
            this.txtRetroImage.Name = "txtRetroImage";
            this.txtRetroImage.ReadOnly = true;
            this.txtRetroImage.Size = new System.Drawing.Size(367, 85);
            this.txtRetroImage.TabIndex = 11;
            // 
            // txtRetro
            // 
            this.txtRetro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRetro.Location = new System.Drawing.Point(226, 94);
            this.txtRetro.Multiline = true;
            this.txtRetro.Name = "txtRetro";
            this.txtRetro.ReadOnly = true;
            this.txtRetro.Size = new System.Drawing.Size(367, 85);
            this.txtRetro.TabIndex = 8;
            // 
            // txtLakkaRom
            // 
            this.txtLakkaRom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLakkaRom.Location = new System.Drawing.Point(226, 276);
            this.txtLakkaRom.Multiline = true;
            this.txtLakkaRom.Name = "txtLakkaRom";
            this.txtLakkaRom.ReadOnly = true;
            this.txtLakkaRom.Size = new System.Drawing.Size(367, 85);
            this.txtLakkaRom.TabIndex = 3;
            // 
            // btnRetroImageDir
            // 
            this.btnRetroImageDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetroImageDir.Location = new System.Drawing.Point(3, 185);
            this.btnRetroImageDir.Name = "btnRetroImageDir";
            this.btnRetroImageDir.Size = new System.Drawing.Size(217, 85);
            this.btnRetroImageDir.TabIndex = 10;
            this.btnRetroImageDir.Text = "2. 选择Retro图片目录(可选)";
            this.btnRetroImageDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetroImageDir.UseVisualStyleBackColor = true;
            // 
            // btnLoadRomDir
            // 
            this.btnLoadRomDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadRomDir.Location = new System.Drawing.Point(3, 276);
            this.btnLoadRomDir.Name = "btnLoadRomDir";
            this.btnLoadRomDir.Size = new System.Drawing.Size(217, 85);
            this.btnLoadRomDir.TabIndex = 2;
            this.btnLoadRomDir.Text = "3. 选择游戏ROM目录";
            this.btnLoadRomDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadRomDir.UseVisualStyleBackColor = true;
            // 
            // cbxCrc32
            // 
            this.cbxCrc32.AutoSize = true;
            this.cbxCrc32.Location = new System.Drawing.Point(599, 367);
            this.cbxCrc32.Name = "cbxCrc32";
            this.cbxCrc32.Size = new System.Drawing.Size(59, 19);
            this.cbxCrc32.TabIndex = 12;
            this.cbxCrc32.Text = "CRC32";
            this.cbxCrc32.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(226, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 92);
            this.label1.TabIndex = 5;
            this.label1.Text = "工具主要作用：将复古Pi的游戏列表转换为Lakka格式，并且将图片重名为Lakka格式";
            // 
            // FrmRetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 456);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmRetro";
            this.Text = "FrmRetro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRetro;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtRetroImage;
        private System.Windows.Forms.TextBox txtRetro;
        private System.Windows.Forms.TextBox txtLakkaRom;
        private System.Windows.Forms.Button btnRetroImageDir;
        private System.Windows.Forms.Button btnLoadRomDir;
        private System.Windows.Forms.CheckBox cbxCrc32;
        private System.Windows.Forms.Label label1;
    }
}