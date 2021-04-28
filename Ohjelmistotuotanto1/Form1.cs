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
            this.postiTableAdapter.Fill(this.vnDataSet.posti);
            cbPostiNro.SelectedItem = null;
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

        #region Mokin hallinta

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
                int.Parse(cbHenkilomaara.Text), 
                tbVarustelu.Text);

            Validate();
            mokkiTableAdapter.Update(this.vnDataSet.mokki);

            //kenttien tyhjennys
            tbMokkinimi.Text = string.Empty;
            tbKatuosoite.Text = string.Empty;
            tbKuvaus.Text = string.Empty;
            cbHenkilomaara.SelectedItem = null;
            tbVarustelu.Text = string.Empty;
            cbPostiNro.SelectedItem = null;

            this.mokkiTableAdapter.Fill(vnDataSet.mokki);
        }
        
        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vnDataSet);
            vnDataSet.mokki.Rows[this.dataGridViewMokki.SelectedRows[0].Index].Delete();

            Validate();
            mokkiTableAdapter.Update(this.vnDataSet.mokki);
            this.mokkiTableAdapter.Fill(vnDataSet.mokki);
        }

        #endregion

        #region Toiminta-alueen hallinta

        //Toiminta-alueen muokkaus
        private void btnToimintaAlueMuokkaus_Click(object sender, EventArgs e)
        {
            ToimintaAlueMuokkausEnable();
        }

        //Uuden toiminta-alueen lisääminen
        private void btnLisaaToimintaAlue_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vnDataSet);
            toimintaalueTableAdapter.Insert(tbToimintaAlueNimi.Text);
            this.toimintaalueTableAdapter.Fill(this.vnDataSet.toimintaalue);

            ToimintaAlueMuokkausEnable();
        }

        //Toiminta-alueen nimen muokkaaminen
        private void btnMuokkaaAluetta_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vnDataSet);
            //Muuttaa taulukosta valitun toiminta-alueen nimen.
            vnDataSet.toimintaalueRow toimintaalueRow = vnDataSet.toimintaalue.FindBytoimintaalue_id(long.Parse(tbToimintaAlueID.Text));
            toimintaalueRow.nimi = tbToimintaAlueNimi.Text;

            Validate();
            toimintaalueTableAdapter.Update(this.vnDataSet);
            this.toimintaalueTableAdapter.Fill(this.vnDataSet.toimintaalue);

            ToimintaAlueMuokkausEnable();
        }

        //Toiminta-alueen poistaminen
        private void btnPoistaToimintaAlue_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vnDataSet);

            vnDataSet.toimintaalueRow toimintaalueRow = vnDataSet.toimintaalue.FindBytoimintaalue_id(long.Parse(tbToimintaAlueID.Text));
            toimintaalueTableAdapter.Delete(toimintaalueRow.toimintaalue_id, toimintaalueRow.nimi);
            Validate();
            toimintaalueTableAdapter.Update(this.vnDataSet);

            this.toimintaalueTableAdapter.Fill(this.vnDataSet.toimintaalue);

            ToimintaAlueMuokkausEnable();
        }

        //lisää tai poistaa näkyviltä alueen poisto ja lisäyspainikkeet
        private void ToimintaAlueMuokkausEnable()
        {
            if (btnToimintaAlueMuokkaus.Text == "Lisää tai poista")
            {
                lblAlueenNimi.Enabled = true;
                lblValitseListasta.Enabled = true;
                btnLisaaToimintaAlue.Enabled = true;
                btnToimintaAlueMuokkaus.Enabled = true;
                btnPoistaToimintaAlue.Enabled = true;
                tbToimintaAlueNimi.Enabled = true;
                btnToimintaAlueMuokkaus.Text = "Peruuta";

            }
            else if (btnToimintaAlueMuokkaus.Text == "Peruuta")
            {
                lblAlueenNimi.Enabled = false;
                lblValitseListasta.Enabled = false;
                btnLisaaToimintaAlue.Enabled = false;
                btnToimintaAlueMuokkaus.Enabled = false;
                btnPoistaToimintaAlue.Enabled = false;
                tbToimintaAlueNimi.Enabled = false;
                btnToimintaAlueMuokkaus.Text = "Lisää tai poista";
                tbToimintaAlueNimi.Text = string.Empty;
            }
        }

        #endregion
    }
}
