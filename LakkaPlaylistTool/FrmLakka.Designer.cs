namespace LakkaPlaylistTool
{
    partial class FrmLakka
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxCrc32 = new System.Windows.Forms.CheckBox();
            this.btnLoadRomDir = new System.Windows.Forms.Button();
            this.btnRetroImageDir = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLoadLakkaList = new System.Windows.Forms.Button();
            this.txtLakkaRom = new System.Windows.Forms.TextBox();
            this.txtRetroImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLakkaList = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxCopyRoms = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCrc32
            // 
            this.cbxCrc32.AutoSize = true;
            this.cbxCrc32.Location = new System.Drawing.Point(3, 3);
            this.cbxCrc32.Name = "cbxCrc32";
            this.cbxCrc32.Size = new System.Drawing.Size(99, 19);
            this.cbxCrc32.TabIndex = 12;
            this.cbxCrc32.Text = "获取CRC32";
            this.toolTip1.SetToolTip(this.cbxCrc32, "生成CRC32会耗费比较长的时间");
            this.cbxCrc32.UseVisualStyleBackColor = true;
            // 
            // btnLoadRomDir
            // 
            this.btnLoadRomDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadRomDir.Location = new System.Drawing.Point(3, 173);
            this.btnLoadRomDir.Name = "btnLoadRomDir";
            this.btnLoadRomDir.Size = new System.Drawing.Size(264, 79);
            this.btnLoadRomDir.TabIndex = 2;
            this.btnLoadRomDir.Text = "3. 选择游戏ROM目录";
            this.btnLoadRomDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnLoadRomDir, "将根据此目录下的rom生成的Lakka游戏列表（比如：\\\\LAKKA\\ROMs\\fba）");
            this.btnLoadRomDir.UseVisualStyleBackColor = true;
            this.btnLoadRomDir.Click += new System.EventHandler(this.btnLoadRomDir_Click);
            // 
            // btnRetroImageDir
            // 
            this.btnRetroImageDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetroImageDir.Location = new System.Drawing.Point(3, 88);
            this.btnRetroImageDir.Name = "btnRetroImageDir";
            this.btnRetroImageDir.Size = new System.Drawing.Size(264, 79);
            this.btnRetroImageDir.TabIndex = 10;
            this.btnRetroImageDir.Text = "2. 选择图片目录";
            this.btnRetroImageDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnRetroImageDir, "选择了图片目录, 在生成列表的同时会生成一个Lakka格式的图片目录");
            this.btnRetroImageDir.UseVisualStyleBackColor = true;
            this.btnRetroImageDir.Click += new System.EventHandler(this.btnRetroImageDir_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(3, 258);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(264, 79);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "4. 编辑Lakka列表";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnEdit, "如果选择了Retro图片目录，那么生成列表的同时会在相同目录下生成图片目录");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLoadLakkaList
            // 
            this.btnLoadLakkaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadLakkaList.Location = new System.Drawing.Point(3, 3);
            this.btnLoadLakkaList.Name = "btnLoadLakkaList";
            this.btnLoadLakkaList.Size = new System.Drawing.Size(264, 79);
            this.btnLoadLakkaList.TabIndex = 0;
            this.btnLoadLakkaList.Text = "1. 加载Lakka列表文件(lpl文件)";
            this.btnLoadLakkaList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadLakkaList.UseVisualStyleBackColor = true;
            this.btnLoadLakkaList.Click += new System.EventHandler(this.btnLoadLakkaList_Click);
            // 
            // txtLakkaRom
            // 
            this.txtLakkaRom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLakkaRom.Location = new System.Drawing.Point(273, 173);
            this.txtLakkaRom.Multiline = true;
            this.txtLakkaRom.Name = "txtLakkaRom";
            this.txtLakkaRom.ReadOnly = true;
            this.txtLakkaRom.Size = new System.Drawing.Size(260, 79);
            this.txtLakkaRom.TabIndex = 3;
            // 
            // txtRetroImage
            // 
            this.txtRetroImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRetroImage.Location = new System.Drawing.Point(273, 88);
            this.txtRetroImage.Multiline = true;
            this.txtRetroImage.Name = "txtRetroImage";
            this.txtRetroImage.ReadOnly = true;
            this.txtRetroImage.Size = new System.Drawing.Size(260, 79);
            this.txtRetroImage.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Location = new System.Drawing.Point(3, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "编辑Lakka游戏列表和图片";
            // 
            // txtLakkaList
            // 
            this.txtLakkaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLakkaList.Location = new System.Drawing.Point(273, 3);
            this.txtLakkaList.Multiline = true;
            this.txtLakkaList.Name = "txtLakkaList";
            this.txtLakkaList.ReadOnly = true;
            this.txtLakkaList.Size = new System.Drawing.Size(260, 79);
            this.txtLakkaList.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.4604F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.53959F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLakkaList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadLakkaList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtRetroImage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLakkaRom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRetroImageDir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadRomDir, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 360);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "*必选";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "*必选";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "可选";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(273, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 79);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "5. 保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbxCrc32);
            this.flowLayoutPanel1.Controls.Add(this.cbxCopyRoms);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(539, 258);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(87, 79);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // cbxCopyRoms
            // 
            this.cbxCopyRoms.AutoSize = true;
            this.cbxCopyRoms.Location = new System.Drawing.Point(3, 28);
            this.cbxCopyRoms.Name = "cbxCopyRoms";
            this.cbxCopyRoms.Size = new System.Drawing.Size(113, 19);
            this.cbxCopyRoms.TabIndex = 13;
            this.cbxCopyRoms.Text = "重新拷贝ROM";
            this.toolTip1.SetToolTip(this.cbxCopyRoms, "重新拷贝整理后的ROM,如果对ROM有删减，可以重新拷贝一个干净的ROM目录");
            this.cbxCopyRoms.UseVisualStyleBackColor = true;
            // 
            // FrmLakka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmLakka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lakka游戏列表维护";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbxCrc32;
        private System.Windows.Forms.Button btnLoadRomDir;
        private System.Windows.Forms.Button btnRetroImageDir;
        private System.Windows.Forms.TextBox txtLakkaRom;
        private System.Windows.Forms.TextBox txtRetroImage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLoadLakkaList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLakkaList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox cbxCopyRoms;
    }
}

