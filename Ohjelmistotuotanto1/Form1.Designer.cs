
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
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
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPoistaToimintaAlue = new System.Windows.Forms.Button();
            this.btnLisaaToimintaAlue = new System.Windows.Forms.Button();
            this.dataGridViewToimintaAlue = new System.Windows.Forms.DataGridView();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbToimintaAlueNimi = new System.Windows.Forms.TextBox();
            this.lblToimintaAlueNimi = new System.Windows.Forms.Label();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblMokkinimi = new System.Windows.Forms.Label();
            this.lblMokkiID = new System.Windows.Forms.Label();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausTableAdapter = new Ohjelmistotuotanto1.vnDataSetTableAdapters.varausTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tbToimintaAlueID = new System.Windows.Forms.TextBox();
            this.toimintaalueidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPostiNro = new System.Windows.Forms.ComboBox();
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postiTableAdapter = new Ohjelmistotuotanto1.vnDataSetTableAdapters.postiTableAdapter();
            this.ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            this.mokkiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToimintaAlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
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
            this.ParentPanel.Size = new System.Drawing.Size(233, 217);
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
            this.label1.Location = new System.Drawing.Point(660, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hallitse mökkejä";
            // 
            // btnPoistaToimintaAlue
            // 
            this.btnPoistaToimintaAlue.Location = new System.Drawing.Point(710, 80);
            this.btnPoistaToimintaAlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoistaToimintaAlue.Name = "btnPoistaToimintaAlue";
            this.btnPoistaToimintaAlue.Size = new System.Drawing.Size(85, 25);
            this.btnPoistaToimintaAlue.TabIndex = 23;
            this.btnPoistaToimintaAlue.Text = "Poista alue";
            this.btnPoistaToimintaAlue.UseVisualStyleBackColor = true;
            this.btnPoistaToimintaAlue.Click += new System.EventHandler(this.btnPoistaToimintaAlue_Click);
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
            // dataGridViewToimintaAlue
            // 
            this.dataGridViewToimintaAlue.AutoGenerateColumns = false;
            this.dataGridViewToimintaAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToimintaAlue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toimintaalueidDataGridViewTextBoxColumn1,
            this.nimiDataGridViewTextBoxColumn});
            this.dataGridViewToimintaAlue.DataSource = this.toimintaalueBindingSource;
            this.dataGridViewToimintaAlue.Location = new System.Drawing.Point(298, 107);
            this.dataGridViewToimintaAlue.Name = "dataGridViewToimintaAlue";
            this.dataGridViewToimintaAlue.Size = new System.Drawing.Size(248, 116);
            this.dataGridViewToimintaAlue.TabIndex = 21;
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.vnDataSet;
            // 
            // tbToimintaAlueNimi
            // 
            this.tbToimintaAlueNimi.Location = new System.Drawing.Point(580, 47);
            this.tbToimintaAlueNimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbToimintaAlueNimi.Name = "tbToimintaAlueNimi";
            this.tbToimintaAlueNimi.Size = new System.Drawing.Size(123, 20);
            this.tbToimintaAlueNimi.TabIndex = 20;
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
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(17, 206);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(59, 12);
            this.lblVarustelu.TabIndex = 16;
            this.lblVarustelu.Text = "Varustelu";
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
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(17, 136);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(46, 12);
            this.lblKuvaus.TabIndex = 14;
            this.lblKuvaus.Text = "Kuvaus";
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
            // lblMokkinimi
            // 
            this.lblMokkinimi.AutoSize = true;
            this.lblMokkinimi.Location = new System.Drawing.Point(17, 66);
            this.lblMokkinimi.Name = "lblMokkinimi";
            this.lblMokkinimi.Size = new System.Drawing.Size(63, 12);
            this.lblMokkinimi.TabIndex = 12;
            this.lblMokkinimi.Text = "Mökin nimi";
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
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(105, 203);
            this.tbVarustelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(176, 20);
            this.tbVarustelu.TabIndex = 10;
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(105, 169);
            this.tbHenkilomaara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(176, 20);
            this.tbHenkilomaara.TabIndex = 9;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(105, 133);
            this.tbKuvaus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(176, 20);
            this.tbKuvaus.TabIndex = 8;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(105, 96);
            this.tbKatuosoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(176, 20);
            this.tbKatuosoite.TabIndex = 7;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Location = new System.Drawing.Point(105, 63);
            this.tbMokkinimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(176, 20);
            this.tbMokkinimi.TabIndex = 6;
            // 
            // btnHaeMokki
            // 
            this.btnHaeMokki.Location = new System.Drawing.Point(196, 233);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattupvmDataGridViewTextBoxColumn,
            this.vahvistuspvmDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.varausBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(174, 500);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 72);
            this.dataGridView1.TabIndex = 7;
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // mokkimokkiidDataGridViewTextBoxColumn
            // 
            this.mokkimokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.Name = "mokkimokkiidDataGridViewTextBoxColumn";
            // 
            // varattupvmDataGridViewTextBoxColumn
            // 
            this.varattupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.HeaderText = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.Name = "varattupvmDataGridViewTextBoxColumn";
            // 
            // vahvistuspvmDataGridViewTextBoxColumn
            // 
            this.vahvistuspvmDataGridViewTextBoxColumn.DataPropertyName = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.HeaderText = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.Name = "vahvistuspvmDataGridViewTextBoxColumn";
            // 
            // varattualkupvmDataGridViewTextBoxColumn
            // 
            this.varattualkupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.HeaderText = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.Name = "varattualkupvmDataGridViewTextBoxColumn";
            // 
            // varattuloppupvmDataGridViewTextBoxColumn
            // 
            this.varattuloppupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.HeaderText = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.Name = "varattuloppupvmDataGridViewTextBoxColumn";
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.vnDataSet;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.toimintaalueBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1033, 25);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // tbToimintaAlueID
            // 
            this.tbToimintaAlueID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource, "toimintaalue_id", true));
            this.tbToimintaAlueID.Enabled = false;
            this.tbToimintaAlueID.Location = new System.Drawing.Point(672, 83);
            this.tbToimintaAlueID.Name = "tbToimintaAlueID";
            this.tbToimintaAlueID.Size = new System.Drawing.Size(31, 20);
            this.tbToimintaAlueID.TabIndex = 26;
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
            // cbPostiNro
            // 
            this.cbPostiNro.DataSource = this.postiBindingSource;
            this.cbPostiNro.DisplayMember = "postinro";
            this.cbPostiNro.FormattingEnabled = true;
            this.cbPostiNro.Location = new System.Drawing.Point(393, 47);
            this.cbPostiNro.Name = "cbPostiNro";
            this.cbPostiNro.Size = new System.Drawing.Size(121, 20);
            this.cbPostiNro.TabIndex = 27;
            this.cbPostiNro.ValueMember = "postinro";
            // 
            // postiBindingSource
            // 
            this.postiBindingSource.DataMember = "posti";
            this.postiBindingSource.DataSource = this.vnDataSet;
            // 
            // postiTableAdapter
            // 
            this.postiTableAdapter.ClearBeforeFill = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 666);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private System.Windows.Forms.BindingSource mokkiBindingSource1;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private vnDataSetTableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.TextBox tbToimintaAlueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbPostiNro;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private vnDataSetTableAdapters.postiTableAdapter postiTableAdapter;
    }
}

