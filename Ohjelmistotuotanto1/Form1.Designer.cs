
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLisaaMokki = new System.Windows.Forms.Button();
            this.tbMokkiID = new System.Windows.Forms.TextBox();
            this.dataGridViewMokki = new System.Windows.Forms.DataGridView();
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
            this.mokkiTableAdapter = new Ohjelmistotuotanto1.vnDataSetTableAdapters.mokkiTableAdapter();
            this.toimintaalueTableAdapter = new Ohjelmistotuotanto1.vnDataSetTableAdapters.toimintaalueTableAdapter();
            this.mokkiPanel = new System.Windows.Forms.Panel();
            this.btnHaeMokki = new System.Windows.Forms.Button();
            this.btnPoistaMokki = new System.Windows.Forms.Button();
            this.tbMokkinimi = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.lblMokkiID = new System.Windows.Forms.Label();
            this.lblMokkinimi = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.lblToimintaAlueNimi = new System.Windows.Forms.Label();
            this.tbToimintaAlueNimi = new System.Windows.Forms.TextBox();
            this.dataGridViewToimintaAlue = new System.Windows.Forms.DataGridView();
            this.btnLisaaToimintaAlue = new System.Windows.Forms.Button();
            this.btnPoistaToimintaAlue = new System.Windows.Forms.Button();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimintaalueidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaskutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.AsiakkaatBtn = new Ohjelmistotuotanto1.CustomButton();
            this.PalvelutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.MokitBtn = new Ohjelmistotuotanto1.CustomButton();
            this.VarausBtn = new Ohjelmistotuotanto1.CustomButton();
            this.mokkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            this.mokkiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToimintaAlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource1)).BeginInit();
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
            this.ParentPanel.Size = new System.Drawing.Size(233, 64);
            this.ParentPanel.TabIndex = 5;
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
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.Location = new System.Drawing.Point(570, 253);
            this.btnLisaaMokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.Size = new System.Drawing.Size(86, 25);
            this.btnLisaaMokki.TabIndex = 3;
            this.btnLisaaMokki.Text = "Lisää";
            this.btnLisaaMokki.UseVisualStyleBackColor = true;
            this.btnLisaaMokki.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // tbMokkiID
            // 
            this.tbMokkiID.Location = new System.Drawing.Point(105, 32);
            this.tbMokkiID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMokkiID.Name = "tbMokkiID";
            this.tbMokkiID.Size = new System.Drawing.Size(176, 20);
            this.tbMokkiID.TabIndex = 2;
            // 
            // dataGridViewMokki
            // 
            this.dataGridViewMokki.AutoGenerateColumns = false;
            this.dataGridViewMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMokki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dataGridViewMokki.DataSource = this.mokkiBindingSource;
            this.dataGridViewMokki.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewMokki.Location = new System.Drawing.Point(0, 282);
            this.dataGridViewMokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMokki.Name = "dataGridViewMokki";
            this.dataGridViewMokki.Size = new System.Drawing.Size(842, 121);
            this.dataGridViewMokki.TabIndex = 1;
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
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // mokkiPanel
            // 
            this.mokkiPanel.Controls.Add(this.btnMuokkaa);
            this.mokkiPanel.Controls.Add(this.label1);
            this.mokkiPanel.Controls.Add(this.btnPoistaToimintaAlue);
            this.mokkiPanel.Controls.Add(this.btnLisaaToimintaAlue);
            this.mokkiPanel.Controls.Add(this.dataGridViewToimintaAlue);
            this.mokkiPanel.Controls.Add(this.tbToimintaAlueNimi);
            this.mokkiPanel.Controls.Add(this.lblToimintaAlueNimi);
            this.mokkiPanel.Controls.Add(this.lblVarustelu);
            this.mokkiPanel.Controls.Add(this.lblHenkilomaara);
            this.mokkiPanel.Controls.Add(this.lblKuvaus);
            this.mokkiPanel.Controls.Add(this.lblKatuosoite);
            this.mokkiPanel.Controls.Add(this.lblMokkinimi);
            this.mokkiPanel.Controls.Add(this.lblMokkiID);
            this.mokkiPanel.Controls.Add(this.tbVarustelu);
            this.mokkiPanel.Controls.Add(this.tbHenkilomaara);
            this.mokkiPanel.Controls.Add(this.tbKuvaus);
            this.mokkiPanel.Controls.Add(this.tbKatuosoite);
            this.mokkiPanel.Controls.Add(this.tbMokkinimi);
            this.mokkiPanel.Controls.Add(this.btnHaeMokki);
            this.mokkiPanel.Controls.Add(this.btnPoistaMokki);
            this.mokkiPanel.Controls.Add(this.dataGridViewMokki);
            this.mokkiPanel.Controls.Add(this.btnLisaaMokki);
            this.mokkiPanel.Controls.Add(this.tbMokkiID);
            this.mokkiPanel.Location = new System.Drawing.Point(174, 91);
            this.mokkiPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mokkiPanel.Name = "mokkiPanel";
            this.mokkiPanel.Size = new System.Drawing.Size(842, 403);
            this.mokkiPanel.TabIndex = 6;
            // 
            // btnHaeMokki
            // 
            this.btnHaeMokki.Location = new System.Drawing.Point(196, 227);
            this.btnHaeMokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHaeMokki.Name = "btnHaeMokki";
            this.btnHaeMokki.Size = new System.Drawing.Size(85, 25);
            this.btnHaeMokki.TabIndex = 5;
            this.btnHaeMokki.Text = "Hae";
            this.btnHaeMokki.UseVisualStyleBackColor = true;
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.Location = new System.Drawing.Point(754, 253);
            this.btnPoistaMokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(85, 25);
            this.btnPoistaMokki.TabIndex = 4;
            this.btnPoistaMokki.Text = "Poista";
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Location = new System.Drawing.Point(105, 63);
            this.tbMokkinimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(176, 20);
            this.tbMokkinimi.TabIndex = 6;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(105, 96);
            this.tbKatuosoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(176, 20);
            this.tbKatuosoite.TabIndex = 7;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(105, 133);
            this.tbKuvaus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(176, 20);
            this.tbKuvaus.TabIndex = 8;
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(105, 169);
            this.tbHenkilomaara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(176, 20);
            this.tbHenkilomaara.TabIndex = 9;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(105, 203);
            this.tbVarustelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(176, 20);
            this.tbVarustelu.TabIndex = 10;
            // 
            // lblMokkiID
            // 
            this.lblMokkiID.AutoSize = true;
            this.lblMokkiID.Location = new System.Drawing.Point(17, 35);
            this.lblMokkiID.Name = "lblMokkiID";
            this.lblMokkiID.Size = new System.Drawing.Size(51, 12);
            this.lblMokkiID.TabIndex = 11;
            this.lblMokkiID.Text = "Mökin ID";
            // 
            // lblMokkinimi
            // 
            this.lblMokkinimi.AutoSize = true;
            this.lblMokkinimi.Location = new System.Drawing.Point(17, 66);
            this.lblMokkinimi.Name = "lblMokkinimi";
            this.lblMokkinimi.Size = new System.Drawing.Size(63, 12);
            this.lblMokkinimi.TabIndex = 12;
            this.lblMokkinimi.Text = "Mökin nimi";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Location = new System.Drawing.Point(17, 99);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(65, 12);
            this.lblKatuosoite.TabIndex = 13;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(17, 136);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(46, 12);
            this.lblKuvaus.TabIndex = 14;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Location = new System.Drawing.Point(17, 172);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(82, 12);
            this.lblHenkilomaara.TabIndex = 15;
            this.lblHenkilomaara.Text = "Henkilomäärä";
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(17, 206);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(59, 12);
            this.lblVarustelu.TabIndex = 16;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // lblToimintaAlueNimi
            // 
            this.lblToimintaAlueNimi.AutoSize = true;
            this.lblToimintaAlueNimi.Location = new System.Drawing.Point(578, 33);
            this.lblToimintaAlueNimi.Name = "lblToimintaAlueNimi";
            this.lblToimintaAlueNimi.Size = new System.Drawing.Size(137, 12);
            this.lblToimintaAlueNimi.TabIndex = 19;
            this.lblToimintaAlueNimi.Text = "Lisää uusi toiminta-alue";
            // 
            // tbToimintaAlueNimi
            // 
            this.tbToimintaAlueNimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource, "nimi", true));
            this.tbToimintaAlueNimi.Location = new System.Drawing.Point(580, 47);
            this.tbToimintaAlueNimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbToimintaAlueNimi.Name = "tbToimintaAlueNimi";
            this.tbToimintaAlueNimi.Size = new System.Drawing.Size(123, 20);
            this.tbToimintaAlueNimi.TabIndex = 20;
            // 
            // dataGridViewToimintaAlue
            // 
            this.dataGridViewToimintaAlue.AutoGenerateColumns = false;
            this.dataGridViewToimintaAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToimintaAlue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toimintaalueidDataGridViewTextBoxColumn1,
            this.nimiDataGridViewTextBoxColumn});
            this.dataGridViewToimintaAlue.DataSource = this.toimintaalueBindingSource;
            this.dataGridViewToimintaAlue.Location = new System.Drawing.Point(314, 32);
            this.dataGridViewToimintaAlue.Name = "dataGridViewToimintaAlue";
            this.dataGridViewToimintaAlue.Size = new System.Drawing.Size(254, 116);
            this.dataGridViewToimintaAlue.TabIndex = 21;
            // 
            // btnLisaaToimintaAlue
            // 
            this.btnLisaaToimintaAlue.Location = new System.Drawing.Point(709, 44);
            this.btnLisaaToimintaAlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLisaaToimintaAlue.Name = "btnLisaaToimintaAlue";
            this.btnLisaaToimintaAlue.Size = new System.Drawing.Size(86, 25);
            this.btnLisaaToimintaAlue.TabIndex = 22;
            this.btnLisaaToimintaAlue.Text = "Lisää";
            this.btnLisaaToimintaAlue.UseVisualStyleBackColor = true;
            this.btnLisaaToimintaAlue.Click += new System.EventHandler(this.btnLisaaToimintaAlue_Click);
            // 
            // btnPoistaToimintaAlue
            // 
            this.btnPoistaToimintaAlue.Location = new System.Drawing.Point(483, 153);
            this.btnPoistaToimintaAlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoistaToimintaAlue.Name = "btnPoistaToimintaAlue";
            this.btnPoistaToimintaAlue.Size = new System.Drawing.Size(85, 25);
            this.btnPoistaToimintaAlue.TabIndex = 23;
            this.btnPoistaToimintaAlue.Text = "Poista alue";
            this.btnPoistaToimintaAlue.UseVisualStyleBackColor = true;
            this.btnPoistaToimintaAlue.Click += new System.EventHandler(this.btnPoistaToimintaAlue_Click);
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.vnDataSet;
            // 
            // toimintaalueidDataGridViewTextBoxColumn1
            // 
            this.toimintaalueidDataGridViewTextBoxColumn1.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn1.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn1.Name = "toimintaalueidDataGridViewTextBoxColumn1";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
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
            // mokkiBindingSource1
            // 
            this.mokkiBindingSource1.DataMember = "mokki";
            this.mokkiBindingSource1.DataSource = this.vnDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hallitse mökkejä";
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(662, 253);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(86, 25);
            this.btnMuokkaa.TabIndex = 25;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 513);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            this.mokkiPanel.ResumeLayout(false);
            this.mokkiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToimintaAlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewMokki;
        private System.Windows.Forms.BindingSource vnDataSetBindingSource;
        private vnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private vnDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.Button btnLisaaMokki;
        private System.Windows.Forms.TextBox tbMokkiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private vnDataSetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.Panel mokkiPanel;
        private System.Windows.Forms.Button btnHaeMokki;
        private System.Windows.Forms.Button btnPoistaMokki;
        private System.Windows.Forms.Label lblVarustelu;
        private System.Windows.Forms.Label lblHenkilomaara;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.Label lblKatuosoite;
        private System.Windows.Forms.Label lblMokkinimi;
        private System.Windows.Forms.Label lblMokkiID;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.TextBox tbHenkilomaara;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbMokkinimi;
        private System.Windows.Forms.TextBox tbToimintaAlueNimi;
        private System.Windows.Forms.Label lblToimintaAlueNimi;
        private System.Windows.Forms.Button btnPoistaToimintaAlue;
        private System.Windows.Forms.Button btnLisaaToimintaAlue;
        private System.Windows.Forms.DataGridView dataGridViewToimintaAlue;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private System.Windows.Forms.BindingSource mokkiBindingSource1;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Label label1;
    }
}

