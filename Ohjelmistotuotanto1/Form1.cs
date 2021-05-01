using Ohjelmistotuotanto1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmistotuotanto1
{
    public partial class Form : System.Windows.Forms.Form
    {
       private List<Asiakkaat> asiakas = new List<Asiakkaat>(); //asiakashallintalista

        public Form()
        {
            InitializeComponent();
        }

        //VarausBtn toiminnallisuus

        private void VarausBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Varaus";

        }

        //MökitBtn toiminnallisuus

        private void MokitBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Mökit";
        }

        //PalvelutBtn toiminnallisuus

        private void PalvelutBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Palvelut";
        }

        //AsiakkaatBtn toiminnallisuus

        private void AsiakkaatBtn_Click(object sender, EventArgs e)
        {       
            this.Text = "Asiakkaat";
            AloitusPaneeli.Visible = true;          
        }

        //LaskutBtn toiminnallisuus

        private void LaskutBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Laskut";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.asiakas' table. You can move, or remove it, as needed.
            this.MuokkaaTableAdapter.Fill(this.vnDdataSet1.asiakas);
            // TODO: This line of code loads data into the 'dataSet1.asiakas' table. You can move, or remove it, as needed.
            this.poistaTableAdapter.Fill(this.vnDataSet.asiakas);

        }

        //Asiakashallinta

        private void CbtnLisaaAsiakas_Click(object sender, EventArgs e)
        {
            PanelLisaaAsiakas.Visible = true;
            PanelMuokkaaAsiakasta.Visible = false;
            PanelPoistaAsiakas.Visible = false;

            tbEtunimi.Text = " ";
            tbSukunimi.Text = " ";
            tbLahiosoite.Text = " ";
            tbPuhelinnro.Text = " ";
            tbEmail.Text = " ";
        }
        private void CbtnMuokkaaAsiakas_Click(object sender, EventArgs e)
        {
            PanelMuokkaaAsiakasta.Visible = true;
            PanelLisaaAsiakas.Visible = false;
            PanelPoistaAsiakas.Visible = false;

            MiniPanelMuokkaa.Visible = false;
        }    
        private void CbtnPoistaAsiakas_Click(object sender, EventArgs e)
        {
            PanelPoistaAsiakas.Visible = true;
            PanelLisaaAsiakas.Visible = false;
            PanelMuokkaaAsiakasta.Visible = false;
        }

        //Palaa Asiakashallintaan
        private void btnPalaaAsiakasHallintaan2_Click(object sender, EventArgs e)
        {
            PanelMuokkaaAsiakasta.Visible = false;
            PanelLisaaAsiakas.Visible = false;
            PanelPoistaAsiakas.Visible = false;
        }

        private void btnPalaaAsiakasHallintaan3_Click(object sender, EventArgs e)
        {
            PanelMuokkaaAsiakasta.Visible = false;
            PanelLisaaAsiakas.Visible = false;
            PanelPoistaAsiakas.Visible = false;
        }
        private void btnPalaaAsiakasHallintaan_Click(object sender, EventArgs e)
        {
            PanelLisaaAsiakas.Visible = false;
            PanelMuokkaaAsiakasta.Visible = false;
            PanelPoistaAsiakas.Visible = false;
        }

        //Lisää Tietoja
        private void btnTallennaUusiAsiakas_Click(object sender, EventArgs e)
        {
            Validate();
            Asiakkaat Uusiasiakas = new Asiakkaat(); //Asiakkaat luokan olio

            Uusiasiakas.etunimi = tbEtunimi.Text;
            Uusiasiakas.sukunimi = tbSukunimi.Text;
            Uusiasiakas.lahiosoite = tbLahiosoite.Text;
            Uusiasiakas.puhelinnro = tbPuhelinnro.Text;
            Uusiasiakas.email = tbEmail.Text;
            asiakas.Add(Uusiasiakas); //lisäään listaan

            asiakasBindingSource.EndEdit();
            asiakasBindingSource1.EndEdit();
            MuokkaaTableAdapter.Update(this.vnDdataSet1);
            poistaTableAdapter.Update(this.vnDataSet);
            MuokkaaTableAdapter.Insert(asiakas);
          //  this.MuokkaaTableAdapter.Fill(this.vnDdataSet)
        }

        private void tbPuhelinnro_KeyPress(object sender, KeyPressEventArgs e)
        { //Sallii vain numeroiden kirjoittamisen
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Muokkaa Tietoja
        private void BtnMuokkaaAsiakkaanTietoja_Click(object sender, EventArgs e)
        {
            MiniPanelMuokkaa.Visible = true;
        }

       
    }     
    
}
