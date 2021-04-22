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
        #region Form Load
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.posti' table. You can move, or remove it, as needed.
            this.postiTableAdapter.Fill(this.vnDataSet.posti);
            // TODO: This line of code loads data into the 'vnDataSet.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.vnDataSet.varaus);
            // Lataa mökkien ja toimnta-alueiden tiedot tietokannasta datagrid
            this.mokkiTableAdapter.Fill(this.vnDataSet.mokki);
            this.toimintaalueTableAdapter.Fill(this.vnDataSet.toimintaalue);
        }
        #endregion

        #region Pääpainikkeet
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
        #endregion

        #region MokkiPanel

        //Uuden mökin lisääminen
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            Validate();
            mokkiBindingSource.EndEdit();
            mokkiTableAdapter.Update(this.vnDataSet);
            mokkiTableAdapter.Insert(
                long.Parse(tbToimintaAlueID.Text), 
                cbPostiNro.Text, 
                tbMokkinimi.Text, 
                tbKatuosoite.Text, 
                tbKuvaus.Text, 
                int.Parse(tbHenkilomaara.Text), 
                tbVarustelu.Text);

            //kenttien tyhjennys
            tbMokkinimi.Text = string.Empty;
            tbKatuosoite.Text = string.Empty;
            tbKuvaus.Text = string.Empty;
            tbHenkilomaara.Text = string.Empty;
            tbVarustelu.Text = string.Empty;

            this.mokkiTableAdapter.Fill(vnDataSet.mokki);
            
        }

        //Uuden toiminta-alueen lisääminen
        private void btnLisaaToimintaAlue_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vnDataSet);
            toimintaalueTableAdapter.Insert(tbToimintaAlueNimi.Text);
            this.toimintaalueTableAdapter.Fill(this.vnDataSet.toimintaalue);

            tbToimintaAlueNimi.Text = string.Empty;
        }

        //Toiminta-alueen poistaminen
        private void btnPoistaToimintaAlue_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vnDataSet);

            vnDataSet.toimintaalueRow toimintaalueRow = vnDataSet.toimintaalue.FindBytoimintaalue_id(long.Parse(tbToimintaAlueID.Text));
            toimintaalueTableAdapter.Delete(toimintaalueRow.toimintaalue_id, toimintaalueRow.nimi);

            this.toimintaalueTableAdapter.Fill(this.vnDataSet.toimintaalue);
        }

        #endregion

        //Mökkejä voi lisätä. MökkiId tb turha? 
    }
}
