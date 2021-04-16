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

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.mokki' table and vnDataSet.toimintaalue. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.vnDataSet.mokki);
            this.toimintaalueTableAdapter.Fill(this.vnDataSet.toimintaalue);

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
        }

        //LaskutBtn toiminnallisuus

        private void LaskutBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Laskut";
        }



        private void btnLisaa_Click(object sender, EventArgs e)
        {
            Validate();
            mokkiBindingSource.EndEdit();
            mokkiTableAdapter.Update(this.vnDataSet);
            //mokkiTableAdapter.Insert();
        }

        private void btnLisaaToimintaAlue_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vnDataSet);
            toimintaalueTableAdapter.Insert(tbToimintaAlueNimi.Text);
            this.toimintaalueTableAdapter.Fill(this.vnDataSet.toimintaalue);

            tbToimintaAlueNimi.Text = string.Empty;
        }

        private void btnPoistaToimintaAlue_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vnDataSet);
            //tästä jatkuu. miten saan deletoinnin toimimaan, tsekkaa datagridview ohjeet.
            //ID pitäisi saada alla olevaan. HUOM Long typpiä
            //toimintaalueTableAdapter.Delete(, tbToimintaAlueNimi.Text);
            this.toimintaalueTableAdapter.Fill(this.vnDataSet.toimintaalue);

            tbToimintaAlueNimi.Text = string.Empty;

        }
    }
}
