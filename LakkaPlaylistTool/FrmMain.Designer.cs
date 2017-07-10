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
            this.btnLakka = new System.Windows.Forms.Button();
            this.btnRetro = new System.Windows.Forms.Button();
            this.btnGenerateLakka = new System.Windows.Forms.Button();
            this.btnLakka2Retro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLakka
            // 
            this.btnLakka.Location = new System.Drawing.Point(6, 17);
            this.btnLakka.Name = "btnLakka";
            this.btnLakka.Size = new System.Drawing.Size(449, 54);
            this.btnLakka.TabIndex = 0;
            this.btnLakka.Text = "1. 编辑Lakka列表";
            this.btnLakka.UseVisualStyleBackColor = true;
            this.btnLakka.Click += new System.EventHandler(this.btnLakka_Click);
            // 
            // btnRetro
            // 
            this.btnRetro.Location = new System.Drawing.Point(6, 89);
            this.btnRetro.Name = "btnRetro";
            this.btnRetro.Size = new System.Drawing.Size(449, 54);
            this.btnRetro.TabIndex = 1;
            this.btnRetro.Text = "2. 转换Retro列表为Lakka格式";
            this.btnRetro.UseVisualStyleBackColor = true;
            this.btnRetro.Click += new System.EventHandler(this.btnRetro_Click);
            // 
            // btnGenerateLakka
            // 
            this.btnGenerateLakka.Location = new System.Drawing.Point(6, 163);
            this.btnGenerateLakka.Name = "btnGenerateLakka";
            this.btnGenerateLakka.Size = new System.Drawing.Size(449, 54);
            this.btnGenerateLakka.TabIndex = 2;
            this.btnGenerateLakka.Text = "3. 根据ROM目录生成Lakka列表";
            this.btnGenerateLakka.UseVisualStyleBackColor = true;
            this.btnGenerateLakka.Click += new System.EventHandler(this.btnGenerateLakka_Click);
            // 
            // btnLakka2Retro
            // 
            this.btnLakka2Retro.Location = new System.Drawing.Point(6, 232);
            this.btnLakka2Retro.Name = "btnLakka2Retro";
            this.btnLakka2Retro.Size = new System.Drawing.Size(449, 54);
            this.btnLakka2Retro.TabIndex = 3;
            this.btnLakka2Retro.Text = "4. 转换Lakka列表为Retro格式";
            this.btnLakka2Retro.UseVisualStyleBackColor = true;
            this.btnLakka2Retro.Click += new System.EventHandler(this.btnLakka2Retro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLakka2Retro);
            this.groupBox1.Controls.Add(this.btnGenerateLakka);
            this.groupBox1.Controls.Add(this.btnRetro);
            this.groupBox1.Controls.Add(this.btnLakka);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 294);
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
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLakka;
        private System.Windows.Forms.Button btnRetro;
        private System.Windows.Forms.Button btnGenerateLakka;
        private System.Windows.Forms.Button btnLakka2Retro;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}