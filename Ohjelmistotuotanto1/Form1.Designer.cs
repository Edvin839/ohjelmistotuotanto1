
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
            this.rbMuokkaaAsiakkaanTietoja = new System.Windows.Forms.RadioButton();
            this.rbPoistaAsiakas = new System.Windows.Forms.RadioButton();
            this.rbLisaaAsiakas = new System.Windows.Forms.RadioButton();
            this.PanelLisaaAsiakas = new System.Windows.Forms.Panel();
            this.LblEtunimi = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSposti = new System.Windows.Forms.Label();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbSposti = new System.Windows.Forms.TextBox();
            this.lblPuhelinnumero = new System.Windows.Forms.Label();
            this.tbPuhNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelPoistaAsiakas = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelMuokkaatietoja = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Ohjelmistotuotanto1.DataSet1();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new Ohjelmistotuotanto1.DataSet1TableAdapters.asiakasTableAdapter();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet2 = new Ohjelmistotuotanto1.DataSet2();
            this.asiakasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter1 = new Ohjelmistotuotanto1.DataSet2TableAdapters.asiakasTableAdapter();
            this.btnPoistaAsiakas = new System.Windows.Forms.Button();
            this.LaskutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.AsiakkaatBtn = new Ohjelmistotuotanto1.CustomButton();
            this.PalvelutBtn = new Ohjelmistotuotanto1.CustomButton();
            this.MokitBtn = new Ohjelmistotuotanto1.CustomButton();
            this.VarausBtn = new Ohjelmistotuotanto1.CustomButton();
            this.btnTallennaAsiakkaanTiedot = new System.Windows.Forms.Button();
            this.btnMuokkaaTietoja = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbHaeAsiakas = new System.Windows.Forms.TextBox();
            this.btnTallennaMuokatutTiedot = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ParentPanel.SuspendLayout();
            this.PanelLisaaAsiakas.SuspendLayout();
            this.PanelPoistaAsiakas.SuspendLayout();
            this.PanelMuokkaatietoja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.label5);
            this.ParentPanel.Controls.Add(this.rbMuokkaaAsiakkaanTietoja);
            this.ParentPanel.Controls.Add(this.rbPoistaAsiakas);
            this.ParentPanel.Controls.Add(this.rbLisaaAsiakas);
            this.ParentPanel.Location = new System.Drawing.Point(194, 40);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(630, 425);
            this.ParentPanel.TabIndex = 5;
            // 
            // rbMuokkaaAsiakkaanTietoja
            // 
            this.rbMuokkaaAsiakkaanTietoja.AutoSize = true;
            this.rbMuokkaaAsiakkaanTietoja.Location = new System.Drawing.Point(46, 240);
            this.rbMuokkaaAsiakkaanTietoja.Name = "rbMuokkaaAsiakkaanTietoja";
            this.rbMuokkaaAsiakkaanTietoja.Size = new System.Drawing.Size(215, 23);
            this.rbMuokkaaAsiakkaanTietoja.TabIndex = 9;
            this.rbMuokkaaAsiakkaanTietoja.TabStop = true;
            this.rbMuokkaaAsiakkaanTietoja.Text = "Muokkaa asiakkaan tietoja";
            this.rbMuokkaaAsiakkaanTietoja.UseVisualStyleBackColor = true;
            // 
            // rbPoistaAsiakas
            // 
            this.rbPoistaAsiakas.AutoSize = true;
            this.rbPoistaAsiakas.Location = new System.Drawing.Point(46, 177);
            this.rbPoistaAsiakas.Name = "rbPoistaAsiakas";
            this.rbPoistaAsiakas.Size = new System.Drawing.Size(127, 23);
            this.rbPoistaAsiakas.TabIndex = 8;
            this.rbPoistaAsiakas.TabStop = true;
            this.rbPoistaAsiakas.Text = "Poista asiakas";
            this.rbPoistaAsiakas.UseVisualStyleBackColor = true;
            // 
            // rbLisaaAsiakas
            // 
            this.rbLisaaAsiakas.AutoSize = true;
            this.rbLisaaAsiakas.Location = new System.Drawing.Point(46, 117);
            this.rbLisaaAsiakas.Name = "rbLisaaAsiakas";
            this.rbLisaaAsiakas.Size = new System.Drawing.Size(152, 23);
            this.rbLisaaAsiakas.TabIndex = 7;
            this.rbLisaaAsiakas.TabStop = true;
            this.rbLisaaAsiakas.Text = "Lisää uusi asiakas";
            this.rbLisaaAsiakas.UseVisualStyleBackColor = true;
            // 
            // PanelLisaaAsiakas
            // 
            this.PanelLisaaAsiakas.Controls.Add(this.btnTallennaAsiakkaanTiedot);
            this.PanelLisaaAsiakas.Controls.Add(this.label2);
            this.PanelLisaaAsiakas.Controls.Add(this.tbPuhNumero);
            this.PanelLisaaAsiakas.Controls.Add(this.lblPuhelinnumero);
            this.PanelLisaaAsiakas.Controls.Add(this.tbSposti);
            this.PanelLisaaAsiakas.Controls.Add(this.lblSposti);
            this.PanelLisaaAsiakas.Controls.Add(this.tbLahiosoite);
            this.PanelLisaaAsiakas.Controls.Add(this.label1);
            this.PanelLisaaAsiakas.Controls.Add(this.tbSukunimi);
            this.PanelLisaaAsiakas.Controls.Add(this.lblSukunimi);
            this.PanelLisaaAsiakas.Controls.Add(this.tbNimi);
            this.PanelLisaaAsiakas.Controls.Add(this.LblEtunimi);
            this.PanelLisaaAsiakas.Location = new System.Drawing.Point(12, 471);
            this.PanelLisaaAsiakas.Name = "PanelLisaaAsiakas";
            this.PanelLisaaAsiakas.Size = new System.Drawing.Size(630, 425);
            this.PanelLisaaAsiakas.TabIndex = 6;
            this.PanelLisaaAsiakas.Visible = false;
            // 
            // LblEtunimi
            // 
            this.LblEtunimi.AutoSize = true;
            this.LblEtunimi.Location = new System.Drawing.Point(53, 120);
            this.LblEtunimi.Name = "LblEtunimi";
            this.LblEtunimi.Size = new System.Drawing.Size(63, 19);
            this.LblEtunimi.TabIndex = 0;
            this.LblEtunimi.Text = "Etunimi";
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(189, 113);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(191, 26);
            this.tbNimi.TabIndex = 1;
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(53, 165);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(74, 19);
            this.lblSukunimi.TabIndex = 2;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(189, 158);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(191, 26);
            this.tbSukunimi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lähiosoite";
            // 
            // lblSposti
            // 
            this.lblSposti.AutoSize = true;
            this.lblSposti.Location = new System.Drawing.Point(48, 296);
            this.lblSposti.Name = "lblSposti";
            this.lblSposti.Size = new System.Drawing.Size(86, 19);
            this.lblSposti.TabIndex = 6;
            this.lblSposti.Text = "Sähköposti";
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(189, 244);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(191, 26);
            this.tbLahiosoite.TabIndex = 5;
            // 
            // tbSposti
            // 
            this.tbSposti.Location = new System.Drawing.Point(189, 289);
            this.tbSposti.Name = "tbSposti";
            this.tbSposti.Size = new System.Drawing.Size(191, 26);
            this.tbSposti.TabIndex = 7;
            // 
            // lblPuhelinnumero
            // 
            this.lblPuhelinnumero.AutoSize = true;
            this.lblPuhelinnumero.Location = new System.Drawing.Point(48, 211);
            this.lblPuhelinnumero.Name = "lblPuhelinnumero";
            this.lblPuhelinnumero.Size = new System.Drawing.Size(116, 19);
            this.lblPuhelinnumero.TabIndex = 8;
            this.lblPuhelinnumero.Text = "Puhelinnumero";
            // 
            // tbPuhNumero
            // 
            this.tbPuhNumero.Location = new System.Drawing.Point(189, 204);
            this.tbPuhNumero.Name = "tbPuhNumero";
            this.tbPuhNumero.Size = new System.Drawing.Size(191, 26);
            this.tbPuhNumero.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lisää uuden asiakkaan tiedot";
            // 
            // PanelPoistaAsiakas
            // 
            this.PanelPoistaAsiakas.Controls.Add(this.btnPoistaAsiakas);
            this.PanelPoistaAsiakas.Controls.Add(this.dataGridView1);
            this.PanelPoistaAsiakas.Controls.Add(this.label3);
            this.PanelPoistaAsiakas.Location = new System.Drawing.Point(671, 474);
            this.PanelPoistaAsiakas.Name = "PanelPoistaAsiakas";
            this.PanelPoistaAsiakas.Size = new System.Drawing.Size(652, 435);
            this.PanelPoistaAsiakas.TabIndex = 10;
            this.PanelPoistaAsiakas.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Poista asiakas järjestelmästä";
            // 
            // PanelMuokkaatietoja
            // 
            this.PanelMuokkaatietoja.Controls.Add(this.label11);
            this.PanelMuokkaatietoja.Controls.Add(this.btnTallennaMuokatutTiedot);
            this.PanelMuokkaatietoja.Controls.Add(this.tbHaeAsiakas);
            this.PanelMuokkaatietoja.Controls.Add(this.textBox1);
            this.PanelMuokkaatietoja.Controls.Add(this.btnMuokkaaTietoja);
            this.PanelMuokkaatietoja.Controls.Add(this.label6);
            this.PanelMuokkaatietoja.Controls.Add(this.dataGridView2);
            this.PanelMuokkaatietoja.Controls.Add(this.textBox2);
            this.PanelMuokkaatietoja.Controls.Add(this.label4);
            this.PanelMuokkaatietoja.Controls.Add(this.label7);
            this.PanelMuokkaatietoja.Controls.Add(this.textBox4);
            this.PanelMuokkaatietoja.Controls.Add(this.textBox3);
            this.PanelMuokkaatietoja.Controls.Add(this.label10);
            this.PanelMuokkaatietoja.Controls.Add(this.label8);
            this.PanelMuokkaatietoja.Controls.Add(this.textBox5);
            this.PanelMuokkaatietoja.Controls.Add(this.label9);
            this.PanelMuokkaatietoja.Location = new System.Drawing.Point(830, 40);
            this.PanelMuokkaatietoja.Name = "PanelMuokkaatietoja";
            this.PanelMuokkaatietoja.Size = new System.Drawing.Size(630, 425);
            this.PanelMuokkaatietoja.TabIndex = 10;
            this.PanelMuokkaatietoja.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Muokkaa asiakkaan tietoja";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asiakasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 157);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.dataSet1;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            this.asiakasidDataGridViewTextBoxColumn.Width = 125;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.Width = 125;
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            this.etunimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            this.sukunimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            this.lahiosoiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            this.puhelinnroDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.DataSource = this.asiakasBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(13, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(610, 123);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "asiakas_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "asiakas_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "postinro";
            this.dataGridViewTextBoxColumn2.HeaderText = "postinro";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "etunimi";
            this.dataGridViewTextBoxColumn3.HeaderText = "etunimi";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sukunimi";
            this.dataGridViewTextBoxColumn4.HeaderText = "sukunimi";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "lahiosoite";
            this.dataGridViewTextBoxColumn5.HeaderText = "lahiosoite";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "email";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "puhelinnro";
            this.dataGridViewTextBoxColumn7.HeaderText = "puhelinnro";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasBindingSource1
            // 
            this.asiakasBindingSource1.DataMember = "asiakas";
            this.asiakasBindingSource1.DataSource = this.dataSet2;
            // 
            // asiakasTableAdapter1
            // 
            this.asiakasTableAdapter1.ClearBeforeFill = true;
            // 
            // btnPoistaAsiakas
            // 
            this.btnPoistaAsiakas.Location = new System.Drawing.Point(501, 374);
            this.btnPoistaAsiakas.Name = "btnPoistaAsiakas";
            this.btnPoistaAsiakas.Size = new System.Drawing.Size(119, 51);
            this.btnPoistaAsiakas.TabIndex = 2;
            this.btnPoistaAsiakas.Text = "Poista tiedot";
            this.btnPoistaAsiakas.UseVisualStyleBackColor = true;
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
            // btnTallennaAsiakkaanTiedot
            // 
            this.btnTallennaAsiakkaanTiedot.Location = new System.Drawing.Point(469, 359);
            this.btnTallennaAsiakkaanTiedot.Name = "btnTallennaAsiakkaanTiedot";
            this.btnTallennaAsiakkaanTiedot.Size = new System.Drawing.Size(132, 44);
            this.btnTallennaAsiakkaanTiedot.TabIndex = 11;
            this.btnTallennaAsiakkaanTiedot.Text = "Lisää tiedot";
            this.btnTallennaAsiakkaanTiedot.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaaTietoja
            // 
            this.btnMuokkaaTietoja.Location = new System.Drawing.Point(358, 68);
            this.btnMuokkaaTietoja.Name = "btnMuokkaaTietoja";
            this.btnMuokkaaTietoja.Size = new System.Drawing.Size(96, 35);
            this.btnMuokkaaTietoja.TabIndex = 3;
            this.btnMuokkaaTietoja.Text = "Muokkaa";
            this.btnMuokkaaTietoja.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(618, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Village Newbies Oy asiakkaiden hallinta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 26);
            this.textBox1.TabIndex = 21;
            this.textBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Puhelinnumero";
            this.label6.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 402);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 26);
            this.textBox2.TabIndex = 19;
            this.textBox2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sähköposti";
            this.label7.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 362);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 26);
            this.textBox3.TabIndex = 17;
            this.textBox3.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Lähiosoite";
            this.label8.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 284);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 26);
            this.textBox4.TabIndex = 15;
            this.textBox4.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sukunimi";
            this.label9.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 249);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 26);
            this.textBox5.TabIndex = 13;
            this.textBox5.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Etunimi";
            this.label10.Visible = false;
            // 
            // tbHaeAsiakas
            // 
            this.tbHaeAsiakas.Location = new System.Drawing.Point(89, 68);
            this.tbHaeAsiakas.Name = "tbHaeAsiakas";
            this.tbHaeAsiakas.Size = new System.Drawing.Size(189, 26);
            this.tbHaeAsiakas.TabIndex = 22;
            // 
            // btnTallennaMuokatutTiedot
            // 
            this.btnTallennaMuokatutTiedot.Location = new System.Drawing.Point(472, 362);
            this.btnTallennaMuokatutTiedot.Name = "btnTallennaMuokatutTiedot";
            this.btnTallennaMuokatutTiedot.Size = new System.Drawing.Size(131, 42);
            this.btnTallennaMuokatutTiedot.TabIndex = 23;
            this.btnTallennaMuokatutTiedot.Text = "Tallenna";
            this.btnTallennaMuokatutTiedot.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Hae";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 1153);
            this.Controls.Add(this.PanelPoistaAsiakas);
            this.Controls.Add(this.PanelMuokkaatietoja);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.LaskutBtn);
            this.Controls.Add(this.AsiakkaatBtn);
            this.Controls.Add(this.PanelLisaaAsiakas);
            this.Controls.Add(this.PalvelutBtn);
            this.Controls.Add(this.MokitBtn);
            this.Controls.Add(this.VarausBtn);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Varaus";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ParentPanel.ResumeLayout(false);
            this.ParentPanel.PerformLayout();
            this.PanelLisaaAsiakas.ResumeLayout(false);
            this.PanelLisaaAsiakas.PerformLayout();
            this.PanelPoistaAsiakas.ResumeLayout(false);
            this.PanelPoistaAsiakas.PerformLayout();
            this.PanelMuokkaatietoja.ResumeLayout(false);
            this.PanelMuokkaatietoja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton VarausBtn;
        private CustomButton MokitBtn;
        private CustomButton PalvelutBtn;
        private CustomButton AsiakkaatBtn;
        private CustomButton LaskutBtn;
        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.RadioButton rbMuokkaaAsiakkaanTietoja;
        private System.Windows.Forms.RadioButton rbPoistaAsiakas;
        private System.Windows.Forms.RadioButton rbLisaaAsiakas;
        private System.Windows.Forms.Panel PanelLisaaAsiakas;
        private System.Windows.Forms.Panel PanelPoistaAsiakas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPuhNumero;
        private System.Windows.Forms.Label lblPuhelinnumero;
        private System.Windows.Forms.TextBox tbSposti;
        private System.Windows.Forms.Label lblSposti;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label LblEtunimi;
        private System.Windows.Forms.Panel PanelMuokkaatietoja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private DataSet1TableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource asiakasBindingSource1;
        private DataSet2TableAdapters.asiakasTableAdapter asiakasTableAdapter1;
        private System.Windows.Forms.Button btnPoistaAsiakas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTallennaAsiakkaanTiedot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTallennaMuokatutTiedot;
        private System.Windows.Forms.TextBox tbHaeAsiakas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMuokkaaTietoja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
    }
}

