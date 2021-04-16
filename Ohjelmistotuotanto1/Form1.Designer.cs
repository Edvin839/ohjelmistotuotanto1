
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
            this.components = new System.ComponentModel.Container();
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.tbMokkiID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSet = new Ohjelmistotuotanto1.vnDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LaskutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.AsiakkaatBtn = new Ohjelmistotuotanto1.CustomButton();
            this.PalvelutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.MokitBtn = new Ohjelmistotuotanto1.CustomButton();
            this.VarausBtn = new Ohjelmistotuotanto1.CustomButton();
            this.mokkiTableAdapter = new Ohjelmistotuotanto1.vnDataSetTableAdapters.mokkiTableAdapter();
            this.toimintaalueTableAdapter1 = new Ohjelmistotuotanto1.vnDataSetTableAdapters.toimintaalueTableAdapter();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiPanel = new System.Windows.Forms.Panel();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnHae = new System.Windows.Forms.Button();
            this.ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            this.mokkiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentPanel.Controls.Add(this.textBox1);
            this.ParentPanel.Location = new System.Drawing.Point(174, 20);
            this.ParentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(380, 53);
            this.ParentPanel.TabIndex = 5;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(544, 249);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 17);
            this.btnLisaa.TabIndex = 3;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // tbMokkiID
            // 
            this.tbMokkiID.Location = new System.Drawing.Point(75, 32);
            this.tbMokkiID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMokkiID.Name = "tbMokkiID";
            this.tbMokkiID.Size = new System.Drawing.Size(102, 20);
            this.tbMokkiID.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mokkiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 282);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 121);
            this.dataGridView1.TabIndex = 1;
            // 
            // mokkiidDataGridViewTextBoxColumn
            // 
            this.mokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.Name = "mokkiidDataGridViewTextBoxColumn";
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.vnDataSetBindingSource;
            // 
            // vnDataSetBindingSource
            // 
            this.vnDataSetBindingSource.DataSource = this.vnDataSet;
            this.vnDataSetBindingSource.Position = 0;
            // 
            // vnDataSet
            // 
            this.vnDataSet.DataSetName = "vnDataSet";
            this.vnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tämän paneelin sisään tulee kaikki muut paneelit";
            // 
            // LaskutBtn
            // 
            this.LaskutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskutBtn.Location = new System.Drawing.Point(34, 250);
            this.LaskutBtn.Name = "LaskutBtn";
            this.LaskutBtn.Size = new System.Drawing.Size(115, 42);
            this.LaskutBtn.TabIndex = 4;
            this.LaskutBtn.Text = "Laskut";
            this.LaskutBtn.Click += new System.EventHandler(this.LaskutBtn_Click);
            // 
            // AsiakkaatBtn
            // 
            this.AsiakkaatBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakkaatBtn.Location = new System.Drawing.Point(34, 202);
            this.AsiakkaatBtn.Name = "AsiakkaatBtn";
            this.AsiakkaatBtn.Size = new System.Drawing.Size(115, 42);
            this.AsiakkaatBtn.TabIndex = 3;
            this.AsiakkaatBtn.Text = "Asiakkaat";
            this.AsiakkaatBtn.Click += new System.EventHandler(this.AsiakkaatBtn_Click);
            // 
            // PalvelutBtn
            // 
            this.PalvelutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalvelutBtn.Location = new System.Drawing.Point(34, 154);
            this.PalvelutBtn.Name = "PalvelutBtn";
            this.PalvelutBtn.Size = new System.Drawing.Size(115, 42);
            this.PalvelutBtn.TabIndex = 2;
            this.PalvelutBtn.Text = "Palvelut";
            this.PalvelutBtn.Click += new System.EventHandler(this.PalvelutBtn_Click);
            // 
            // MokitBtn
            // 
            this.MokitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MokitBtn.Location = new System.Drawing.Point(34, 106);
            this.MokitBtn.Name = "MokitBtn";
            this.MokitBtn.Size = new System.Drawing.Size(115, 42);
            this.MokitBtn.TabIndex = 1;
            this.MokitBtn.Text = "Mökit";
            this.MokitBtn.Click += new System.EventHandler(this.MokitBtn_Click);
            // 
            // VarausBtn
            // 
            this.VarausBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausBtn.Location = new System.Drawing.Point(34, 58);
            this.VarausBtn.Name = "VarausBtn";
            this.VarausBtn.Size = new System.Drawing.Size(115, 42);
            this.VarausBtn.TabIndex = 0;
            this.VarausBtn.Text = "Varaus";
            this.VarausBtn.Click += new System.EventHandler(this.VarausBtn_Click);
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueTableAdapter1
            // 
            this.toimintaalueTableAdapter1.ClearBeforeFill = true;
            // 
            // mokkiPanel
            // 
            this.mokkiPanel.Controls.Add(this.btnHae);
            this.mokkiPanel.Controls.Add(this.btnPoista);
            this.mokkiPanel.Controls.Add(this.dataGridView1);
            this.mokkiPanel.Controls.Add(this.btnLisaa);
            this.mokkiPanel.Controls.Add(this.tbMokkiID);
            this.mokkiPanel.Location = new System.Drawing.Point(174, 91);
            this.mokkiPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mokkiPanel.Name = "mokkiPanel";
            this.mokkiPanel.Size = new System.Drawing.Size(842, 403);
            this.mokkiPanel.TabIndex = 6;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(625, 249);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 17);
            this.btnPoista.TabIndex = 4;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(706, 249);
            this.btnHae.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 17);
            this.btnHae.TabIndex = 5;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 502);
            this.Controls.Add(this.mokkiPanel);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.LaskutBtn);
            this.Controls.Add(this.AsiakkaatBtn);
            this.Controls.Add(this.PalvelutBtn);
            this.Controls.Add(this.MokitBtn);
            this.Controls.Add(this.VarausBtn);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Varaus";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ParentPanel.ResumeLayout(false);
            this.ParentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            this.mokkiPanel.ResumeLayout(false);
            this.mokkiPanel.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vnDataSetBindingSource;
        private vnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private vnDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.TextBox tbMokkiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private vnDataSetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter1;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private System.Windows.Forms.Panel mokkiPanel;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.Button btnPoista;
    }
}

