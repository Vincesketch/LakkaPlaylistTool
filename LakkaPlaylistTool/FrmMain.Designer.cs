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
            this.SuspendLayout();
            // 
            // btnLakka
            // 
            this.btnLakka.Location = new System.Drawing.Point(65, 65);
            this.btnLakka.Name = "btnLakka";
            this.btnLakka.Size = new System.Drawing.Size(140, 54);
            this.btnLakka.TabIndex = 0;
            this.btnLakka.Text = "编辑Lakka列表";
            this.btnLakka.UseVisualStyleBackColor = true;
            this.btnLakka.Click += new System.EventHandler(this.btnLakka_Click);
            // 
            // btnRetro
            // 
            this.btnRetro.Location = new System.Drawing.Point(254, 65);
            this.btnRetro.Name = "btnRetro";
            this.btnRetro.Size = new System.Drawing.Size(133, 54);
            this.btnRetro.TabIndex = 1;
            this.btnRetro.Text = "编辑Retro列表";
            this.btnRetro.UseVisualStyleBackColor = true;
            this.btnRetro.Click += new System.EventHandler(this.btnRetro_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 255);
            this.Controls.Add(this.btnRetro);
            this.Controls.Add(this.btnLakka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lakka游戏列表维护工具  |  作者QQ:178029200";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLakka;
        private System.Windows.Forms.Button btnRetro;
    }
}