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

            EkaPaneeliAsiakas.Visible = true;
            PanelPoistaAsiakas.Visible = false;
            PanelMuokkaaAsiakasta.Visible = false;
            PanelLisaaAsiakas.Visible = false;
        }

        //LaskutBtn toiminnallisuus

        private void LaskutBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Laskut";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter1.Fill(this.dataSet2.asiakas);
            // TODO: This line of code loads data into the 'dataSet1.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.dataSet1.asiakas);

        }

        //Asiakashallinta
        private void rbLisaaUusiAsiakas_CheckedChanged(object sender, EventArgs e)
        {
            PanelLisaaAsiakas.Visible = true;
            EkaPaneeliAsiakas.Visible = false;
            PanelPoistaAsiakas.Visible = false;
            PanelMuokkaaAsiakasta.Visible = false;

        }

        private void rbMuokkaaAsiakkaanTietoja_CheckedChanged(object sender, EventArgs e)
        {
            PanelMuokkaaAsiakasta.Visible = true;
            PanelLisaaAsiakas.Visible = false;
            EkaPaneeliAsiakas.Visible = false;
            PanelPoistaAsiakas.Visible = false;
        }

        private void rbPoistaAsiakas_CheckedChanged(object sender, EventArgs e)
        {
            PanelPoistaAsiakas.Visible = true;
            PanelLisaaAsiakas.Visible = false;
            EkaPaneeliAsiakas.Visible = false;
            PanelMuokkaaAsiakasta.Visible = false;
        }
    }
}
