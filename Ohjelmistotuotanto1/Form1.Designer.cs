
namespace Ohjelmistotuotanto1
{
    partial class Form1
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
            this.btnElaPaina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElaPaina
            // 
            this.btnElaPaina.Location = new System.Drawing.Point(371, 145);
            this.btnElaPaina.Name = "btnElaPaina";
            this.btnElaPaina.Size = new System.Drawing.Size(159, 68);
            this.btnElaPaina.TabIndex = 0;
            this.btnElaPaina.Text = "Testinappi: Paina tästä";
            this.btnElaPaina.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 637);
            this.Controls.Add(this.btnElaPaina);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElaPaina;
    }
}

