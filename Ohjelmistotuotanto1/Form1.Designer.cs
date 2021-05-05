
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
            this.PanelAloitusMokki = new System.Windows.Forms.Panel();
            this.btnMokinMuokkaus = new Ohjelmistotuotanto1.CustomButton();
            this.btnMokinPoisto = new Ohjelmistotuotanto1.CustomButton();
            this.btnMokinLisays = new Ohjelmistotuotanto1.CustomButton();
            this.btnValitseToimintaAlue = new Ohjelmistotuotanto1.CustomButton();
            this.PanelToimintaAlue = new System.Windows.Forms.Panel();
            this.dataGridViewToimintaAlue = new System.Windows.Forms.DataGridView();
            this.vnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vn = new Ohjelmistotuotanto1.vn();
            this.btnPalaa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbToimintaAlueNimi = new System.Windows.Forms.TextBox();
            this.btnLisaaToimintaAlue = new System.Windows.Forms.Button();
            this.btnMuokkaaAluetta = new System.Windows.Forms.Button();
            this.btnPoistaToimintaAlue = new System.Windows.Forms.Button();
            this.lblAlueenNimi = new System.Windows.Forms.Label();
            this.tbToimintaAlueID = new System.Windows.Forms.TextBox();
            this.btnToimintaAlueMuokkaus = new System.Windows.Forms.Button();
            this.PanelMokki = new System.Windows.Forms.Panel();
            this.lblMokinHinta = new System.Windows.Forms.Label();
            this.tbMokinHinta = new System.Windows.Forms.TextBox();
            this.cbHenkilomaara = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPostiNro = new System.Windows.Forms.ComboBox();
            this.btnMuokkaaMokkia = new System.Windows.Forms.Button();
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
            this.dataGridViewMokki = new System.Windows.Forms.DataGridView();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiHintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiAlvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLisaaMokki = new System.Windows.Forms.Button();
            this.LaskutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.AsiakkaatBtn = new Ohjelmistotuotanto1.CustomButton();
            this.PalvelutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.MokitBtn = new Ohjelmistotuotanto1.CustomButton();
            this.VarausBtn = new Ohjelmistotuotanto1.CustomButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mokkiTableAdapter = new Ohjelmistotuotanto1.vnTableAdapters.mokkiTableAdapter();
            this.postiTableAdapter = new Ohjelmistotuotanto1.vnTableAdapters.postiTableAdapter();
            this.toimintaalueTableAdapter = new Ohjelmistotuotanto1.vnTableAdapters.toimintaalueTableAdapter();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbToimintaAlueMokille = new System.Windows.Forms.ComboBox();
            this.toimintaalueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblToimintaAlue = new System.Windows.Forms.Label();
            this.toimintaalueidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelAloitusMokki.SuspendLayout();
            this.PanelToimintaAlue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToimintaAlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vn)).BeginInit();
            this.PanelMokki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParentPanel.Location = new System.Drawing.Point(155, 58);
            this.ParentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(72, 63);
            this.ParentPanel.TabIndex = 5;
            // 
            // PanelAloitusMokki
            // 
            this.PanelAloitusMokki.Controls.Add(this.btnMokinMuokkaus);
            this.PanelAloitusMokki.Controls.Add(this.btnMokinPoisto);
            this.PanelAloitusMokki.Controls.Add(this.PanelMokki);
            this.PanelAloitusMokki.Controls.Add(this.btnMokinLisays);
            this.PanelAloitusMokki.Controls.Add(this.btnValitseToimintaAlue);
            this.PanelAloitusMokki.Location = new System.Drawing.Point(246, 58);
            this.PanelAloitusMokki.Name = "PanelAloitusMokki";
            this.PanelAloitusMokki.Size = new System.Drawing.Size(1103, 571);
            this.PanelAloitusMokki.TabIndex = 7;
            this.PanelAloitusMokki.Visible = false;
            // 
            // btnMokinMuokkaus
            // 
            this.btnMokinMuokkaus.Location = new System.Drawing.Point(614, 20);
            this.btnMokinMuokkaus.Name = "btnMokinMuokkaus";
            this.btnMokinMuokkaus.Size = new System.Drawing.Size(186, 75);
            this.btnMokinMuokkaus.TabIndex = 3;
            this.btnMokinMuokkaus.Text = "Muokkaa mökkiä";
            this.btnMokinMuokkaus.Click += new System.EventHandler(this.btnMokinMuokkaus_Click);
            // 
            // btnMokinPoisto
            // 
            this.btnMokinPoisto.Location = new System.Drawing.Point(423, 20);
            this.btnMokinPoisto.Name = "btnMokinPoisto";
            this.btnMokinPoisto.Size = new System.Drawing.Size(165, 75);
            this.btnMokinPoisto.TabIndex = 2;
            this.btnMokinPoisto.Text = "Poista mökki";
            this.btnMokinPoisto.Click += new System.EventHandler(this.btnMokinPoisto_Click);
            // 
            // btnMokinLisays
            // 
            this.btnMokinLisays.Location = new System.Drawing.Point(226, 20);
            this.btnMokinLisays.Name = "btnMokinLisays";
            this.btnMokinLisays.Size = new System.Drawing.Size(176, 74);
            this.btnMokinLisays.TabIndex = 1;
            this.btnMokinLisays.Text = "Lisää mökki";
            this.btnMokinLisays.Click += new System.EventHandler(this.btnMokinLisays_Click);
            // 
            // btnValitseToimintaAlue
            // 
            this.btnValitseToimintaAlue.Location = new System.Drawing.Point(39, 20);
            this.btnValitseToimintaAlue.Name = "btnValitseToimintaAlue";
            this.btnValitseToimintaAlue.Size = new System.Drawing.Size(165, 74);
            this.btnValitseToimintaAlue.TabIndex = 0;
            this.btnValitseToimintaAlue.Text = "Toiminta-alueiden hallinta";
            this.btnValitseToimintaAlue.Click += new System.EventHandler(this.btnValitseToimintaAlue_Click);
            // 
            // PanelToimintaAlue
            // 
            this.PanelToimintaAlue.Controls.Add(this.dataGridViewToimintaAlue);
            this.PanelToimintaAlue.Controls.Add(this.label4);
            this.PanelToimintaAlue.Controls.Add(this.tbToimintaAlueNimi);
            this.PanelToimintaAlue.Controls.Add(this.btnLisaaToimintaAlue);
            this.PanelToimintaAlue.Controls.Add(this.btnMuokkaaAluetta);
            this.PanelToimintaAlue.Controls.Add(this.btnPoistaToimintaAlue);
            this.PanelToimintaAlue.Controls.Add(this.lblAlueenNimi);
            this.PanelToimintaAlue.Controls.Add(this.tbToimintaAlueID);
            this.PanelToimintaAlue.Controls.Add(this.btnToimintaAlueMuokkaus);
            this.PanelToimintaAlue.Location = new System.Drawing.Point(110, 635);
            this.PanelToimintaAlue.Name = "PanelToimintaAlue";
            this.PanelToimintaAlue.Size = new System.Drawing.Size(1080, 450);
            this.PanelToimintaAlue.TabIndex = 8;
            this.PanelToimintaAlue.Visible = false;
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
            this.dataGridViewToimintaAlue.Location = new System.Drawing.Point(399, 46);
            this.dataGridViewToimintaAlue.MultiSelect = false;
            this.dataGridViewToimintaAlue.Name = "dataGridViewToimintaAlue";
            this.dataGridViewToimintaAlue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewToimintaAlue.Size = new System.Drawing.Size(328, 180);
            this.dataGridViewToimintaAlue.TabIndex = 21;
            // 
            // vnBindingSource
            // 
            this.vnBindingSource.DataSource = this.vn;
            this.vnBindingSource.Position = 0;
            // 
            // vn
            // 
            this.vn.DataSetName = "vn";
            this.vn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPalaa
            // 
            this.btnPalaa.Location = new System.Drawing.Point(1274, 635);
            this.btnPalaa.Name = "btnPalaa";
            this.btnPalaa.Size = new System.Drawing.Size(75, 23);
            this.btnPalaa.TabIndex = 37;
            this.btnPalaa.Text = "Palaa";
            this.btnPalaa.UseVisualStyleBackColor = true;
            this.btnPalaa.Click += new System.EventHandler(this.btnPalaa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "Valittu ID";
            // 
            // tbToimintaAlueNimi
            // 
            this.tbToimintaAlueNimi.Enabled = false;
            this.tbToimintaAlueNimi.Location = new System.Drawing.Point(108, 46);
            this.tbToimintaAlueNimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbToimintaAlueNimi.MaxLength = 40;
            this.tbToimintaAlueNimi.Name = "tbToimintaAlueNimi";
            this.tbToimintaAlueNimi.Size = new System.Drawing.Size(186, 20);
            this.tbToimintaAlueNimi.TabIndex = 20;
            this.tbToimintaAlueNimi.Text = "Lisää tai muokkaa alueen nimeä";
            // 
            // btnLisaaToimintaAlue
            // 
            this.btnLisaaToimintaAlue.Enabled = false;
            this.btnLisaaToimintaAlue.Location = new System.Drawing.Point(300, 45);
            this.btnLisaaToimintaAlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLisaaToimintaAlue.Name = "btnLisaaToimintaAlue";
            this.btnLisaaToimintaAlue.Size = new System.Drawing.Size(72, 25);
            this.btnLisaaToimintaAlue.TabIndex = 22;
            this.btnLisaaToimintaAlue.Text = "Lisää";
            this.btnLisaaToimintaAlue.UseVisualStyleBackColor = true;
            this.btnLisaaToimintaAlue.Click += new System.EventHandler(this.btnLisaaToimintaAlue_Click);
            // 
            // btnMuokkaaAluetta
            // 
            this.btnMuokkaaAluetta.Enabled = false;
            this.btnMuokkaaAluetta.Location = new System.Drawing.Point(300, 78);
            this.btnMuokkaaAluetta.Name = "btnMuokkaaAluetta";
            this.btnMuokkaaAluetta.Size = new System.Drawing.Size(72, 23);
            this.btnMuokkaaAluetta.TabIndex = 33;
            this.btnMuokkaaAluetta.Text = "Muokkaa";
            this.btnMuokkaaAluetta.UseVisualStyleBackColor = true;
            this.btnMuokkaaAluetta.Click += new System.EventHandler(this.btnMuokkaaAluetta_Click);
            // 
            // btnPoistaToimintaAlue
            // 
            this.btnPoistaToimintaAlue.Enabled = false;
            this.btnPoistaToimintaAlue.Location = new System.Drawing.Point(300, 106);
            this.btnPoistaToimintaAlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoistaToimintaAlue.Name = "btnPoistaToimintaAlue";
            this.btnPoistaToimintaAlue.Size = new System.Drawing.Size(72, 25);
            this.btnPoistaToimintaAlue.TabIndex = 23;
            this.btnPoistaToimintaAlue.Text = "Poista";
            this.btnPoistaToimintaAlue.UseVisualStyleBackColor = true;
            this.btnPoistaToimintaAlue.Click += new System.EventHandler(this.btnPoistaToimintaAlue_Click);
            // 
            // lblAlueenNimi
            // 
            this.lblAlueenNimi.AutoSize = true;
            this.lblAlueenNimi.Enabled = false;
            this.lblAlueenNimi.Location = new System.Drawing.Point(29, 51);
            this.lblAlueenNimi.Name = "lblAlueenNimi";
            this.lblAlueenNimi.Size = new System.Drawing.Size(73, 12);
            this.lblAlueenNimi.TabIndex = 32;
            this.lblAlueenNimi.Text = "Alueen nimi:";
            // 
            // tbToimintaAlueID
            // 
            this.tbToimintaAlueID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource, "toimintaalue_id", true));
            this.tbToimintaAlueID.Enabled = false;
            this.tbToimintaAlueID.Location = new System.Drawing.Point(105, 80);
            this.tbToimintaAlueID.Name = "tbToimintaAlueID";
            this.tbToimintaAlueID.ReadOnly = true;
            this.tbToimintaAlueID.Size = new System.Drawing.Size(31, 20);
            this.tbToimintaAlueID.TabIndex = 26;
            // 
            // btnToimintaAlueMuokkaus
            // 
            this.btnToimintaAlueMuokkaus.Location = new System.Drawing.Point(31, 18);
            this.btnToimintaAlueMuokkaus.Name = "btnToimintaAlueMuokkaus";
            this.btnToimintaAlueMuokkaus.Size = new System.Drawing.Size(123, 23);
            this.btnToimintaAlueMuokkaus.TabIndex = 30;
            this.btnToimintaAlueMuokkaus.Text = "Hallitse alueita";
            this.btnToimintaAlueMuokkaus.UseVisualStyleBackColor = true;
            this.btnToimintaAlueMuokkaus.Click += new System.EventHandler(this.btnToimintaAlueMuokkaus_Click);
            // 
            // PanelMokki
            // 
            this.PanelMokki.Controls.Add(this.lblToimintaAlue);
            this.PanelMokki.Controls.Add(this.cbToimintaAlueMokille);
            this.PanelMokki.Controls.Add(this.lblMokinHinta);
            this.PanelMokki.Controls.Add(this.tbMokinHinta);
            this.PanelMokki.Controls.Add(this.cbHenkilomaara);
            this.PanelMokki.Controls.Add(this.label2);
            this.PanelMokki.Controls.Add(this.lblPostitoimipaikka);
            this.PanelMokki.Controls.Add(this.cbPostiNro);
            this.PanelMokki.Controls.Add(this.btnMuokkaaMokkia);
            this.PanelMokki.Controls.Add(this.lblVarustelu);
            this.PanelMokki.Controls.Add(this.lblHenkilomaara);
            this.PanelMokki.Controls.Add(this.lblKuvaus);
            this.PanelMokki.Controls.Add(this.lblKatuosoite);
            this.PanelMokki.Controls.Add(this.lblMokkinimi);
            this.PanelMokki.Controls.Add(this.tbVarustelu);
            this.PanelMokki.Controls.Add(this.tbKuvaus);
            this.PanelMokki.Controls.Add(this.tbKatuosoite);
            this.PanelMokki.Controls.Add(this.tbMokkinimi);
            this.PanelMokki.Controls.Add(this.btnHaeMokki);
            this.PanelMokki.Controls.Add(this.btnPoistaMokki);
            this.PanelMokki.Controls.Add(this.dataGridViewMokki);
            this.PanelMokki.Controls.Add(this.btnLisaaMokki);
            this.PanelMokki.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMokki.Location = new System.Drawing.Point(0, 121);
            this.PanelMokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMokki.MinimumSize = new System.Drawing.Size(840, 400);
            this.PanelMokki.Name = "PanelMokki";
            this.PanelMokki.Size = new System.Drawing.Size(1103, 450);
            this.PanelMokki.TabIndex = 6;
            this.PanelMokki.Visible = false;
            // 
            // lblMokinHinta
            // 
            this.lblMokinHinta.AutoSize = true;
            this.lblMokinHinta.Location = new System.Drawing.Point(16, 141);
            this.lblMokinHinta.Name = "lblMokinHinta";
            this.lblMokinHinta.Size = new System.Drawing.Size(119, 12);
            this.lblMokinHinta.TabIndex = 36;
            this.lblMokinHinta.Text = "Vuokrahinta (alv0 %)";
            // 
            // tbMokinHinta
            // 
            this.tbMokinHinta.Location = new System.Drawing.Point(173, 138);
            this.tbMokinHinta.Name = "tbMokinHinta";
            this.tbMokinHinta.Size = new System.Drawing.Size(107, 20);
            this.tbMokinHinta.TabIndex = 35;
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
            this.cbHenkilomaara.Location = new System.Drawing.Point(173, 164);
            this.cbHenkilomaara.Name = "cbHenkilomaara";
            this.cbHenkilomaara.Size = new System.Drawing.Size(107, 20);
            this.cbHenkilomaara.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "Postinumero";
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postiBindingSource, "toimipaikka", true));
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(185, 112);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(95, 12);
            this.lblPostitoimipaikka.TabIndex = 28;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // postiBindingSource
            // 
            this.postiBindingSource.DataMember = "posti";
            this.postiBindingSource.DataSource = this.vn;
            // 
            // cbPostiNro
            // 
            this.cbPostiNro.DataSource = this.postiBindingSource;
            this.cbPostiNro.DisplayMember = "postinro";
            this.cbPostiNro.FormattingEnabled = true;
            this.cbPostiNro.Location = new System.Drawing.Point(173, 89);
            this.cbPostiNro.Name = "cbPostiNro";
            this.cbPostiNro.Size = new System.Drawing.Size(107, 20);
            this.cbPostiNro.TabIndex = 27;
            this.cbPostiNro.ValueMember = "postinro";
            // 
            // btnMuokkaaMokkia
            // 
            this.btnMuokkaaMokkia.Location = new System.Drawing.Point(103, 196);
            this.btnMuokkaaMokkia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMuokkaaMokkia.Name = "btnMuokkaaMokkia";
            this.btnMuokkaaMokkia.Size = new System.Drawing.Size(86, 25);
            this.btnMuokkaaMokkia.TabIndex = 25;
            this.btnMuokkaaMokkia.Text = "Muokkaa";
            this.btnMuokkaaMokkia.UseVisualStyleBackColor = true;
            this.btnMuokkaaMokkia.Visible = false;
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(311, 18);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(59, 12);
            this.lblVarustelu.TabIndex = 16;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Location = new System.Drawing.Point(16, 165);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(82, 12);
            this.lblHenkilomaara.TabIndex = 15;
            this.lblHenkilomaara.Text = "Henkilomäärä";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(311, 130);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(46, 12);
            this.lblKuvaus.TabIndex = 14;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Location = new System.Drawing.Point(17, 67);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(65, 12);
            this.lblKatuosoite.TabIndex = 13;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // lblMokkinimi
            // 
            this.lblMokkinimi.AutoSize = true;
            this.lblMokkinimi.Location = new System.Drawing.Point(17, 43);
            this.lblMokkinimi.Name = "lblMokkinimi";
            this.lblMokkinimi.Size = new System.Drawing.Size(63, 12);
            this.lblMokkinimi.TabIndex = 12;
            this.lblMokkinimi.Text = "Mökin nimi";
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(399, 15);
            this.tbVarustelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVarustelu.MaxLength = 100;
            this.tbVarustelu.Multiline = true;
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(640, 88);
            this.tbVarustelu.TabIndex = 10;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(399, 130);
            this.tbKuvaus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKuvaus.MaxLength = 150;
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(640, 91);
            this.tbKuvaus.TabIndex = 8;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(105, 64);
            this.tbKatuosoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKatuosoite.MaxLength = 45;
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(176, 20);
            this.tbKatuosoite.TabIndex = 7;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Location = new System.Drawing.Point(105, 40);
            this.tbMokkinimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMokkinimi.MaxLength = 45;
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(176, 20);
            this.tbMokkinimi.TabIndex = 6;
            // 
            // btnHaeMokki
            // 
            this.btnHaeMokki.Location = new System.Drawing.Point(6, 196);
            this.btnHaeMokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHaeMokki.Name = "btnHaeMokki";
            this.btnHaeMokki.Size = new System.Drawing.Size(85, 25);
            this.btnHaeMokki.TabIndex = 5;
            this.btnHaeMokki.Text = "Hae";
            this.btnHaeMokki.UseVisualStyleBackColor = true;
            this.btnHaeMokki.Visible = false;
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.Location = new System.Drawing.Point(287, 196);
            this.btnPoistaMokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(85, 25);
            this.btnPoistaMokki.TabIndex = 4;
            this.btnPoistaMokki.Text = "Poista";
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            this.btnPoistaMokki.Visible = false;
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
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
            this.varusteluDataGridViewTextBoxColumn,
            this.mokkiHintaDataGridViewTextBoxColumn,
            this.mokkiAlvDataGridViewTextBoxColumn});
            this.dataGridViewMokki.DataSource = this.mokkiBindingSource;
            this.dataGridViewMokki.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMokki.Location = new System.Drawing.Point(6, 248);
            this.dataGridViewMokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMokki.MultiSelect = false;
            this.dataGridViewMokki.Name = "dataGridViewMokki";
            this.dataGridViewMokki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMokki.Size = new System.Drawing.Size(1042, 199);
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
            // mokkiHintaDataGridViewTextBoxColumn
            // 
            this.mokkiHintaDataGridViewTextBoxColumn.DataPropertyName = "mokkiHinta";
            this.mokkiHintaDataGridViewTextBoxColumn.HeaderText = "mokkiHinta";
            this.mokkiHintaDataGridViewTextBoxColumn.Name = "mokkiHintaDataGridViewTextBoxColumn";
            // 
            // mokkiAlvDataGridViewTextBoxColumn
            // 
            this.mokkiAlvDataGridViewTextBoxColumn.DataPropertyName = "mokkiAlv";
            this.mokkiAlvDataGridViewTextBoxColumn.HeaderText = "mokkiAlv";
            this.mokkiAlvDataGridViewTextBoxColumn.Name = "mokkiAlvDataGridViewTextBoxColumn";
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.vn;
            // 
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.Location = new System.Drawing.Point(195, 196);
            this.btnLisaaMokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.Size = new System.Drawing.Size(86, 25);
            this.btnLisaaMokki.TabIndex = 3;
            this.btnLisaaMokki.Text = "Lisää";
            this.btnLisaaMokki.UseVisualStyleBackColor = true;
            this.btnLisaaMokki.Visible = false;
            this.btnLisaaMokki.Click += new System.EventHandler(this.btnLisaa_Click);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 688);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1443, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // postiTableAdapter
            // 
            this.postiTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.vnBindingSource;
            // 
            // cbToimintaAlueMokille
            // 
            this.cbToimintaAlueMokille.DataSource = this.toimintaalueBindingSource1;
            this.cbToimintaAlueMokille.DisplayMember = "nimi";
            this.cbToimintaAlueMokille.FormattingEnabled = true;
            this.cbToimintaAlueMokille.Location = new System.Drawing.Point(105, 15);
            this.cbToimintaAlueMokille.Name = "cbToimintaAlueMokille";
            this.cbToimintaAlueMokille.Size = new System.Drawing.Size(176, 20);
            this.cbToimintaAlueMokille.TabIndex = 37;
            this.cbToimintaAlueMokille.ValueMember = "toimintaalue_id";
            // 
            // toimintaalueBindingSource1
            // 
            this.toimintaalueBindingSource1.DataMember = "toimintaalue";
            this.toimintaalueBindingSource1.DataSource = this.vnBindingSource;
            // 
            // lblToimintaAlue
            // 
            this.lblToimintaAlue.AutoSize = true;
            this.lblToimintaAlue.Location = new System.Drawing.Point(17, 18);
            this.lblToimintaAlue.Name = "lblToimintaAlue";
            this.lblToimintaAlue.Size = new System.Drawing.Size(81, 12);
            this.lblToimintaAlue.TabIndex = 38;
            this.lblToimintaAlue.Text = "Toiminta-alue";
            // 
            // toimintaalueidDataGridViewTextBoxColumn1
            // 
            this.toimintaalueidDataGridViewTextBoxColumn1.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.toimintaalueidDataGridViewTextBoxColumn1.Name = "toimintaalueidDataGridViewTextBoxColumn1";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "Nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 710);
            this.Controls.Add(this.PanelAloitusMokki);
            this.Controls.Add(this.btnPalaa);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PanelToimintaAlue);
            this.Controls.Add(this.ParentPanel);
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
            this.PanelAloitusMokki.ResumeLayout(false);
            this.PanelToimintaAlue.ResumeLayout(false);
            this.PanelToimintaAlue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToimintaAlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vn)).EndInit();
            this.PanelMokki.ResumeLayout(false);
            this.PanelMokki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton VarausBtn;
        private CustomButton MokitBtn;
        private CustomButton PalvelutBtn;
        private CustomButton AsiakkaatBtn;
        private CustomButton LaskutBtn;
        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.DataGridView dataGridViewMokki;
        private System.Windows.Forms.BindingSource vnBindingSource;
        private System.Windows.Forms.Button btnLisaaMokki;
        private System.Windows.Forms.Panel PanelMokki;
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
        private System.Windows.Forms.Button btnPoistaToimintaAlue;
        private System.Windows.Forms.Button btnLisaaToimintaAlue;
        private System.Windows.Forms.DataGridView dataGridViewToimintaAlue;
        private System.Windows.Forms.Button btnMuokkaaMokkia;
        private System.Windows.Forms.TextBox tbToimintaAlueID;
        private System.Windows.Forms.ComboBox cbPostiNro;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlueenNimi;
        private System.Windows.Forms.Button btnToimintaAlueMuokkaus;
        private System.Windows.Forms.Button btnMuokkaaAluetta;
        private System.Windows.Forms.ComboBox cbHenkilomaara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelAloitusMokki;
        private CustomButton btnValitseToimintaAlue;
        private System.Windows.Forms.Panel PanelToimintaAlue;
        private CustomButton btnMokinMuokkaus;
        private CustomButton btnMokinPoisto;
        private CustomButton btnMokinLisays;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnPalaa;
        private vn vn;
        private vnTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiHintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiAlvDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private vnTableAdapters.postiTableAdapter postiTableAdapter;
        private vnTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.Label lblMokinHinta;
        private System.Windows.Forms.TextBox tbMokinHinta;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private System.Windows.Forms.Label lblToimintaAlue;
        private System.Windows.Forms.ComboBox cbToimintaAlueMokille;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
    }
}

