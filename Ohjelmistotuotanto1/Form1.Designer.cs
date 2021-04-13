
namespace Ohjelmistotuotanto1
{
    partial class Form
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
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LaskutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.AsiakkaatBtn = new Ohjelmistotuotanto1.CustomButton();
            this.PalvelutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.MokitBtn = new Ohjelmistotuotanto1.CustomButton();
            this.VarausBtn = new Ohjelmistotuotanto1.CustomButton();
            this.ParentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.textBox1);
            this.ParentPanel.Location = new System.Drawing.Point(194, 40);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(630, 425);
            this.ParentPanel.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tämän paneelin sisään tulee kaikki muut paneelit";
            // 
            // LaskutBtn
            // 
            this.LaskutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskutBtn.Location = new System.Drawing.Point(34, 334);
            this.LaskutBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LaskutBtn.Name = "LaskutBtn";
            this.LaskutBtn.Size = new System.Drawing.Size(115, 56);
            this.LaskutBtn.TabIndex = 4;
            this.LaskutBtn.Text = "Laskut";
            this.LaskutBtn.Click += new System.EventHandler(this.LaskutBtn_Click);
            // 
            // AsiakkaatBtn
            // 
            this.AsiakkaatBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakkaatBtn.Location = new System.Drawing.Point(34, 270);
            this.AsiakkaatBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AsiakkaatBtn.Name = "AsiakkaatBtn";
            this.AsiakkaatBtn.Size = new System.Drawing.Size(115, 56);
            this.AsiakkaatBtn.TabIndex = 3;
            this.AsiakkaatBtn.Text = "Asiakkaat";
            this.AsiakkaatBtn.Click += new System.EventHandler(this.AsiakkaatBtn_Click);
            // 
            // PalvelutBtn
            // 
            this.PalvelutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalvelutBtn.Location = new System.Drawing.Point(34, 206);
            this.PalvelutBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PalvelutBtn.Name = "PalvelutBtn";
            this.PalvelutBtn.Size = new System.Drawing.Size(115, 56);
            this.PalvelutBtn.TabIndex = 2;
            this.PalvelutBtn.Text = "Palvelut";
            this.PalvelutBtn.Click += new System.EventHandler(this.PalvelutBtn_Click);
            // 
            // MokitBtn
            // 
            this.MokitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MokitBtn.Location = new System.Drawing.Point(34, 142);
            this.MokitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MokitBtn.Name = "MokitBtn";
            this.MokitBtn.Size = new System.Drawing.Size(115, 56);
            this.MokitBtn.TabIndex = 1;
            this.MokitBtn.Text = "Mökit";
            this.MokitBtn.Click += new System.EventHandler(this.MokitBtn_Click);
            // 
            // VarausBtn
            // 
            this.VarausBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausBtn.Location = new System.Drawing.Point(34, 78);
            this.VarausBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VarausBtn.Name = "VarausBtn";
            this.VarausBtn.Size = new System.Drawing.Size(115, 56);
            this.VarausBtn.TabIndex = 0;
            this.VarausBtn.Text = "Varaus";
            this.VarausBtn.Click += new System.EventHandler(this.VarausBtn_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.LaskutBtn);
            this.Controls.Add(this.AsiakkaatBtn);
            this.Controls.Add(this.PalvelutBtn);
            this.Controls.Add(this.MokitBtn);
            this.Controls.Add(this.VarausBtn);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Varaus";
            this.ParentPanel.ResumeLayout(false);
            this.ParentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton VarausBtn;
        private CustomButton MokitBtn;
        private CustomButton PalvelutBtn;
        private CustomButton AsiakkaatBtn;
        private CustomButton LaskutBtn;
        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

