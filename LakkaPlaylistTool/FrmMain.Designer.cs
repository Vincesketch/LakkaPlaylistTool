namespace LakkaPlaylistTool
{
    partial class FrmMain
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
            this.btnLakkaEdit = new System.Windows.Forms.Button();
            this.btnRetro2Lakka = new System.Windows.Forms.Button();
            this.btnCreateLakka = new System.Windows.Forms.Button();
            this.btnLakka2Retro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLakkaEdit
            // 
            this.btnLakkaEdit.Location = new System.Drawing.Point(40, 19);
            this.btnLakkaEdit.Name = "btnLakkaEdit";
            this.btnLakkaEdit.Size = new System.Drawing.Size(348, 54);
            this.btnLakkaEdit.TabIndex = 0;
            this.btnLakkaEdit.Text = "1. 编辑Lakka列表";
            this.btnLakkaEdit.UseVisualStyleBackColor = true;
            this.btnLakkaEdit.Click += new System.EventHandler(this.btnLakkaEdit_Click);
            // 
            // btnRetro2Lakka
            // 
            this.btnRetro2Lakka.Location = new System.Drawing.Point(40, 161);
            this.btnRetro2Lakka.Name = "btnRetro2Lakka";
            this.btnRetro2Lakka.Size = new System.Drawing.Size(348, 54);
            this.btnRetro2Lakka.TabIndex = 1;
            this.btnRetro2Lakka.Text = "3. 转换Retro列表为Lakka格式";
            this.btnRetro2Lakka.UseVisualStyleBackColor = true;
            this.btnRetro2Lakka.Click += new System.EventHandler(this.btnRetro2Lakka_Click);
            // 
            // btnCreateLakka
            // 
            this.btnCreateLakka.Location = new System.Drawing.Point(40, 90);
            this.btnCreateLakka.Name = "btnCreateLakka";
            this.btnCreateLakka.Size = new System.Drawing.Size(348, 54);
            this.btnCreateLakka.TabIndex = 2;
            this.btnCreateLakka.Text = "2. 根据ROM目录生成Lakka列表";
            this.btnCreateLakka.UseVisualStyleBackColor = true;
            this.btnCreateLakka.Click += new System.EventHandler(this.btnCreateLakka_Click);
            // 
            // btnLakka2Retro
            // 
            this.btnLakka2Retro.Location = new System.Drawing.Point(40, 232);
            this.btnLakka2Retro.Name = "btnLakka2Retro";
            this.btnLakka2Retro.Size = new System.Drawing.Size(348, 54);
            this.btnLakka2Retro.TabIndex = 3;
            this.btnLakka2Retro.Text = "4. 转换Lakka列表为Retro格式";
            this.btnLakka2Retro.UseVisualStyleBackColor = true;
            this.btnLakka2Retro.Click += new System.EventHandler(this.btnLakka2Retro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLakka2Retro);
            this.groupBox1.Controls.Add(this.btnCreateLakka);
            this.groupBox1.Controls.Add(this.btnRetro2Lakka);
            this.groupBox1.Controls.Add(this.btnLakkaEdit);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 294);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能列表";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 318);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lakka游戏列表维护工具";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLakkaEdit;
        private System.Windows.Forms.Button btnRetro2Lakka;
        private System.Windows.Forms.Button btnCreateLakka;
        private System.Windows.Forms.Button btnLakka2Retro;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}