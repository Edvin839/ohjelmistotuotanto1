
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
            this.dataGridViewMokki = new System.Windows.Forms.DataGridView();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSet = new Ohjelmistotuotanto1.vnDataSet();
            this.mokkiTableAdapter = new Ohjelmistotuotanto1.vnDataSetTableAdapters.mokkiTableAdapter();
            this.toimintaalueTableAdapter = new Ohjelmistotuotanto1.vnDataSetTableAdapters.toimintaalueTableAdapter();
            this.mokkiPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHenkilomaara = new System.Windows.Forms.ComboBox();
            this.btnMuokkaaAluetta = new System.Windows.Forms.Button();
            this.lblAlueenNimi = new System.Windows.Forms.Label();
            this.lblValitseListasta = new System.Windows.Forms.Label();
            this.btnToimintaAlueMuokkaus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPostiNro = new System.Windows.Forms.ComboBox();
            this.tbToimintaAlueID = new System.Windows.Forms.TextBox();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPoistaToimintaAlue = new System.Windows.Forms.Button();
            this.btnLisaaToimintaAlue = new System.Windows.Forms.Button();
            this.dataGridViewToimintaAlue = new System.Windows.Forms.DataGridView();
            this.toimintaalueidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbToimintaAlueNimi = new System.Windows.Forms.TextBox();
            this.lblToimintaAlueNimi = new System.Windows.Forms.Label();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblMokkinimi = new System.Windows.Forms.Label();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbMokkinimi = new System.Windows.Forms.TextBox();
            this.btnHaeMokki = new System.Windows.Forms.Button();
            this.btnPoistaMokki = new System.Windows.Forms.Button();
            this.mokkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LaskutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.AsiakkaatBtn = new Ohjelmistotuotanto1.CustomButton();
            this.PalvelutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.MokitBtn = new Ohjelmistotuotanto1.CustomButton();
            this.VarausBtn = new Ohjelmistotuotanto1.CustomButton();
            this.postiTableAdapter = new Ohjelmistotuotanto1.vnDataSetTableAdapters.postiTableAdapter();
            this.ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            this.mokkiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToimintaAlue)).BeginInit();
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
            this.ParentPanel.Size = new System.Drawing.Size(827, 44);
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
            // dataGridViewMokki
            // 
            this.dataGridViewMokki.AutoGenerateColumns = false;
            this.dataGridViewMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMokki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn});
            this.dataGridViewMokki.DataSource = this.mokkiBindingSource;
            this.dataGridViewMokki.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMokki.Location = new System.Drawing.Point(0, 282);
            this.dataGridViewMokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMokki.MultiSelect = false;
            this.dataGridViewMokki.Name = "dataGridViewMokki";
            this.dataGridViewMokki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMokki.Size = new System.Drawing.Size(840, 297);
            this.dataGridViewMokki.TabIndex = 1;
            // 
            // mokkiidDataGridViewTextBoxColumn
            // 
            this.mokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.HeaderText = "MökkiID";
            this.mokkiidDataGridViewTextBoxColumn.Name = "mokkiidDataGridViewTextBoxColumn";
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "ToimintaalueID";
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "Mökin Nimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "Henkilömäärä";
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "Kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "Varustelu";
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "Katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "Postinumero";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
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
            this.mokkiPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mokkiPanel.Controls.Add(this.label4);
            this.mokkiPanel.Controls.Add(this.label3);
            this.mokkiPanel.Controls.Add(this.cbHenkilomaara);
            this.mokkiPanel.Controls.Add(this.btnMuokkaaAluetta);
            this.mokkiPanel.Controls.Add(this.lblAlueenNimi);
            this.mokkiPanel.Controls.Add(this.lblValitseListasta);
            this.mokkiPanel.Controls.Add(this.btnToimintaAlueMuokkaus);
            this.mokkiPanel.Controls.Add(this.label2);
            this.mokkiPanel.Controls.Add(this.lblPostitoimipaikka);
            this.mokkiPanel.Controls.Add(this.cbPostiNro);
            this.mokkiPanel.Controls.Add(this.tbToimintaAlueID);
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
            this.mokkiPanel.Controls.Add(this.tbVarustelu);
            this.mokkiPanel.Controls.Add(this.tbKuvaus);
            this.mokkiPanel.Controls.Add(this.tbKatuosoite);
            this.mokkiPanel.Controls.Add(this.tbMokkinimi);
            this.mokkiPanel.Controls.Add(this.btnHaeMokki);
            this.mokkiPanel.Controls.Add(this.btnPoistaMokki);
            this.mokkiPanel.Controls.Add(this.dataGridViewMokki);
            this.mokkiPanel.Controls.Add(this.btnLisaaMokki);
            this.mokkiPanel.Location = new System.Drawing.Point(174, 68);
            this.mokkiPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mokkiPanel.MinimumSize = new System.Drawing.Size(840, 400);
            this.mokkiPanel.Name = "mokkiPanel";
            this.mokkiPanel.Size = new System.Drawing.Size(840, 581);
            this.mokkiPanel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "Toiminta-alueet";
            // 
            // cbHenkilomaara
            // 
            this.cbHenkilomaara.FormattingEnabled = true;
            this.cbHenkilomaara.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.cbHenkilomaara.Location = new System.Drawing.Point(105, 44);
            this.cbHenkilomaara.Name = "cbHenkilomaara";
            this.cbHenkilomaara.Size = new System.Drawing.Size(176, 20);
            this.cbHenkilomaara.TabIndex = 34;
            // 
            // btnMuokkaaAluetta
            // 
            this.btnMuokkaaAluetta.Enabled = false;
            this.btnMuokkaaAluetta.Location = new System.Drawing.Point(754, 102);
            this.btnMuokkaaAluetta.Name = "btnMuokkaaAluetta";
            this.btnMuokkaaAluetta.Size = new System.Drawing.Size(72, 23);
            this.btnMuokkaaAluetta.TabIndex = 33;
            this.btnMuokkaaAluetta.Text = "Muokkaa";
            this.btnMuokkaaAluetta.UseVisualStyleBackColor = true;
            this.btnMuokkaaAluetta.Click += new System.EventHandler(this.btnMuokkaaAluetta_Click);
            // 
            // lblAlueenNimi
            // 
            this.lblAlueenNimi.AutoSize = true;
            this.lblAlueenNimi.Enabled = false;
            this.lblAlueenNimi.Location = new System.Drawing.Point(623, 57);
            this.lblAlueenNimi.Name = "lblAlueenNimi";
            this.lblAlueenNimi.Size = new System.Drawing.Size(29, 12);
            this.lblAlueenNimi.TabIndex = 32;
            this.lblAlueenNimi.Text = "Nimi";
            // 
            // lblValitseListasta
            // 
            this.lblValitseListasta.AutoSize = true;
            this.lblValitseListasta.Enabled = false;
            this.lblValitseListasta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValitseListasta.Location = new System.Drawing.Point(662, 107);
            this.lblValitseListasta.Name = "lblValitseListasta";
            this.lblValitseListasta.Size = new System.Drawing.Size(86, 12);
            this.lblValitseListasta.TabIndex = 31;
            this.lblValitseListasta.Text = "Valitse listasta";
            // 
            // btnToimintaAlueMuokkaus
            // 
            this.btnToimintaAlueMuokkaus.Location = new System.Drawing.Point(622, 32);
            this.btnToimintaAlueMuokkaus.Name = "btnToimintaAlueMuokkaus";
            this.btnToimintaAlueMuokkaus.Size = new System.Drawing.Size(123, 23);
            this.btnToimintaAlueMuokkaus.TabIndex = 30;
            this.btnToimintaAlueMuokkaus.Text = "Lisää tai poista";
            this.btnToimintaAlueMuokkaus.UseVisualStyleBackColor = true;
            this.btnToimintaAlueMuokkaus.Click += new System.EventHandler(this.btnToimintaAlueMuokkaus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "Postinumero";
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postiBindingSource, "toimipaikka", true));
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(386, 79);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(95, 12);
            this.lblPostitoimipaikka.TabIndex = 28;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // postiBindingSource
            // 
            this.postiBindingSource.DataMember = "posti";
            this.postiBindingSource.DataSource = this.vnDataSet;
            // 
            // cbPostiNro
            // 
            this.cbPostiNro.DataSource = this.postiBindingSource;
            this.cbPostiNro.DisplayMember = "postinro";
            this.cbPostiNro.FormattingEnabled = true;
            this.cbPostiNro.Location = new System.Drawing.Point(388, 44);
            this.cbPostiNro.Name = "cbPostiNro";
            this.cbPostiNro.Size = new System.Drawing.Size(176, 20);
            this.cbPostiNro.TabIndex = 27;
            this.cbPostiNro.ValueMember = "postinro";
            // 
            // tbToimintaAlueID
            // 
            this.tbToimintaAlueID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource, "toimintaalue_id", true));
            this.tbToimintaAlueID.Enabled = false;
            this.tbToimintaAlueID.Location = new System.Drawing.Point(717, 137);
            this.tbToimintaAlueID.Name = "tbToimintaAlueID";
            this.tbToimintaAlueID.ReadOnly = true;
            this.tbToimintaAlueID.Size = new System.Drawing.Size(31, 20);
            this.tbToimintaAlueID.TabIndex = 26;
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.vnDataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hallitse mökkejä";
            // 
            // btnPoistaToimintaAlue
            // 
            this.btnPoistaToimintaAlue.Enabled = false;
            this.btnPoistaToimintaAlue.Location = new System.Drawing.Point(754, 134);
            this.btnPoistaToimintaAlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoistaToimintaAlue.Name = "btnPoistaToimintaAlue";
            this.btnPoistaToimintaAlue.Size = new System.Drawing.Size(72, 25);
            this.btnPoistaToimintaAlue.TabIndex = 23;
            this.btnPoistaToimintaAlue.Text = "Poista";
            this.btnPoistaToimintaAlue.UseVisualStyleBackColor = true;
            this.btnPoistaToimintaAlue.Click += new System.EventHandler(this.btnPoistaToimintaAlue_Click);
            // 
            // btnLisaaToimintaAlue
            // 
            this.btnLisaaToimintaAlue.Enabled = false;
            this.btnLisaaToimintaAlue.Location = new System.Drawing.Point(754, 68);
            this.btnLisaaToimintaAlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLisaaToimintaAlue.Name = "btnLisaaToimintaAlue";
            this.btnLisaaToimintaAlue.Size = new System.Drawing.Size(72, 25);
            this.btnLisaaToimintaAlue.TabIndex = 22;
            this.btnLisaaToimintaAlue.Text = "Lisää";
            this.btnLisaaToimintaAlue.UseVisualStyleBackColor = true;
            this.btnLisaaToimintaAlue.Click += new System.EventHandler(this.btnLisaaToimintaAlue_Click);
            // 
            // dataGridViewToimintaAlue
            // 
            this.dataGridViewToimintaAlue.AutoGenerateColumns = false;
            this.dataGridViewToimintaAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToimintaAlue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toimintaalueidDataGridViewTextBoxColumn1,
            this.nimiDataGridViewTextBoxColumn});
            this.dataGridViewToimintaAlue.DataSource = this.toimintaalueBindingSource;
            this.dataGridViewToimintaAlue.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewToimintaAlue.Location = new System.Drawing.Point(302, 111);
            this.dataGridViewToimintaAlue.MultiSelect = false;
            this.dataGridViewToimintaAlue.Name = "dataGridViewToimintaAlue";
            this.dataGridViewToimintaAlue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewToimintaAlue.Size = new System.Drawing.Size(262, 116);
            this.dataGridViewToimintaAlue.TabIndex = 21;
            // 
            // toimintaalueidDataGridViewTextBoxColumn1
            // 
            this.toimintaalueidDataGridViewTextBoxColumn1.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.toimintaalueidDataGridViewTextBoxColumn1.Name = "toimintaalueidDataGridViewTextBoxColumn1";
            this.toimintaalueidDataGridViewTextBoxColumn1.Width = 60;
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "Nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // tbToimintaAlueNimi
            // 
            this.tbToimintaAlueNimi.Enabled = false;
            this.tbToimintaAlueNimi.Location = new System.Drawing.Point(625, 71);
            this.tbToimintaAlueNimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbToimintaAlueNimi.MaxLength = 40;
            this.tbToimintaAlueNimi.Name = "tbToimintaAlueNimi";
            this.tbToimintaAlueNimi.Size = new System.Drawing.Size(123, 20);
            this.tbToimintaAlueNimi.TabIndex = 20;
            // 
            // lblToimintaAlueNimi
            // 
            this.lblToimintaAlueNimi.AutoSize = true;
            this.lblToimintaAlueNimi.Location = new System.Drawing.Point(620, 17);
            this.lblToimintaAlueNimi.Name = "lblToimintaAlueNimi";
            this.lblToimintaAlueNimi.Size = new System.Drawing.Size(149, 12);
            this.lblToimintaAlueNimi.TabIndex = 19;
            this.lblToimintaAlueNimi.Text = "Toiminta-alueiden hallinta";
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(17, 176);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(59, 12);
            this.lblVarustelu.TabIndex = 16;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Location = new System.Drawing.Point(17, 45);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(82, 12);
            this.lblHenkilomaara.TabIndex = 15;
            this.lblHenkilomaara.Text = "Henkilomäärä";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(17, 79);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(46, 12);
            this.lblKuvaus.TabIndex = 14;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Location = new System.Drawing.Point(300, 18);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(65, 12);
            this.lblKatuosoite.TabIndex = 13;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // lblMokkinimi
            // 
            this.lblMokkinimi.AutoSize = true;
            this.lblMokkinimi.Location = new System.Drawing.Point(17, 18);
            this.lblMokkinimi.Name = "lblMokkinimi";
            this.lblMokkinimi.Size = new System.Drawing.Size(63, 12);
            this.lblMokkinimi.TabIndex = 12;
            this.lblMokkinimi.Text = "Mökin nimi";
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(105, 173);
            this.tbVarustelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVarustelu.MaxLength = 100;
            this.tbVarustelu.Multiline = true;
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(176, 88);
            this.tbVarustelu.TabIndex = 10;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(105, 79);
            this.tbKuvaus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKuvaus.MaxLength = 150;
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(176, 80);
            this.tbKuvaus.TabIndex = 8;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(388, 15);
            this.tbKatuosoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKatuosoite.MaxLength = 45;
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(176, 20);
            this.tbKatuosoite.TabIndex = 7;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Location = new System.Drawing.Point(105, 15);
            this.tbMokkinimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMokkinimi.MaxLength = 45;
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(176, 20);
            this.tbMokkinimi.TabIndex = 6;
            // 
            // btnHaeMokki
            // 
            this.btnHaeMokki.Location = new System.Drawing.Point(479, 253);
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
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
            // 
            // mokkiBindingSource1
            // 
            this.mokkiBindingSource1.DataMember = "mokki";
            this.mokkiBindingSource1.DataSource = this.vnDataSet;
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
            // postiTableAdapter
            // 
            this.postiTableAdapter.ClearBeforeFill = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.mokkiPanel);
            this.Controls.Add(this.LaskutBtn);
            this.Controls.Add(this.AsiakkaatBtn);
            this.Controls.Add(this.PalvelutBtn);
            this.Controls.Add(this.MokitBtn);
            this.Controls.Add(this.VarausBtn);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1050, 700);
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
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToimintaAlue)).EndInit();
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
        private vnDataSetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.Panel mokkiPanel;
        private System.Windows.Forms.Button btnHaeMokki;
        private System.Windows.Forms.Button btnPoistaMokki;
        private System.Windows.Forms.Label lblVarustelu;
        private System.Windows.Forms.Label lblHenkilomaara;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.Label lblKatuosoite;
        private System.Windows.Forms.Label lblMokkinimi;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbMokkinimi;
        private System.Windows.Forms.TextBox tbToimintaAlueNimi;
        private System.Windows.Forms.Label lblToimintaAlueNimi;
        private System.Windows.Forms.Button btnPoistaToimintaAlue;
        private System.Windows.Forms.Button btnLisaaToimintaAlue;
        private System.Windows.Forms.DataGridView dataGridViewToimintaAlue;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private System.Windows.Forms.BindingSource mokkiBindingSource1;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbToimintaAlueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbPostiNro;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private vnDataSetTableAdapters.postiTableAdapter postiTableAdapter;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlueenNimi;
        private System.Windows.Forms.Label lblValitseListasta;
        private System.Windows.Forms.Button btnToimintaAlueMuokkaus;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMuokkaaAluetta;
        private System.Windows.Forms.ComboBox cbHenkilomaara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

