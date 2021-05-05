using System;

namespace Ohjelmistotuotanto1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public class vakiot
        {
            public const double ALV = 0.1;
        }

        #region Form Load
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

            this.postiTableAdapter.Fill(this.vn.posti);
            this.mokkiTableAdapter.Fill(this.vn.mokki);
            cbPostiNro.SelectedItem = null;
            this.mokkiTableAdapter.Fill(this.vn.mokki);
            this.mokkiBindingSource.Sort = "toimintaalue_id ASC, henkilomaara ASC";
            this.toimintaalueBindingSource.Sort = "toimintaalue_id ASC";
            this.toimintaalueTableAdapter.Fill(this.vn.toimintaalue);
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
            PanelAloitusMokki.Visible = true;
            dataGridViewMokki.CurrentCell = null;
            dataGridViewToimintaAlue.CurrentCell = null;
            PoistaMokinPainikkeetNakyvista();

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

        #region Mökin aloitusvalikko

        private void btnValitseToimintaAlue_Click(object sender, EventArgs e)
        {
            PoistaMokkiPanelitNakyvista();
            PanelToimintaAlue.Visible = true;
            dataGridViewToimintaAlue.CurrentCell = null;
        }

        private void btnMokinLisays_Click(object sender, EventArgs e)
        {
            PoistaMokkiPanelitNakyvista();
            PoistaMokinPainikkeetNakyvista();
            MokkiKenttienTyhjennys();
            PanelMokki.Visible = true;
            dataGridViewMokki.CurrentCell = null;
            btnLisaaMokki.Visible = true;
        }

        private void btnMokinPoisto_Click(object sender, EventArgs e)
        {
            PoistaMokkiPanelitNakyvista();
            PoistaMokinPainikkeetNakyvista();
            MokkiKenttienTyhjennys();
            PanelMokki.Visible = true;
            btnPoistaMokki.Visible = true;
            btnHaeMokki.Visible = true;
        }

        private void btnMokinMuokkaus_Click(object sender, EventArgs e)
        {
            PoistaMokkiPanelitNakyvista();
            PoistaMokinPainikkeetNakyvista();
            MokkiKenttienTyhjennys();
            PanelMokki.Visible = true;
            btnMuokkaaMokkia.Visible = true;
            btnHaeMokki.Visible = true;
        }

        private void PoistaMokkiPanelitNakyvista()
        {
            dataGridViewMokki.CurrentCell = null;
            dataGridViewToimintaAlue.CurrentCell = null;
            PanelToimintaAlue.Visible = false;
            PanelMokki.Visible = false;
        }

        private void PoistaMokinPainikkeetNakyvista()
        {
            dataGridViewMokki.CurrentCell = null;
            dataGridViewToimintaAlue.CurrentCell = null;
            btnPoistaMokki.Visible = false;
            btnMuokkaaMokkia.Visible = false;
            btnLisaaMokki.Visible = false;
            btnHaeMokki.Visible = false;
        }

        #endregion

        #region Mokin hallinta

        //Uuden mökin lisääminen
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            Validate();
            mokkiBindingSource.EndEdit();
            mokkiTableAdapter.Update(this.vn);
            double mokinHinta = double.Parse(tbMokinHinta.Text);
            double mokinAlv = mokinHinta * vakiot.ALV;
            mokkiTableAdapter.Insert(
                long.Parse(cbToimintaAlueMokille.SelectedValue.ToString()), 
                cbPostiNro.Text, 
                tbMokkinimi.Text, 
                tbKatuosoite.Text, 
                tbKuvaus.Text, 
                int.Parse(cbHenkilomaara.Text), 
                tbVarustelu.Text, 
                mokinHinta, 
                mokinAlv);

            Validate();
            mokkiTableAdapter.Update(this.vn.mokki);

            //kenttien tyhjennys
            MokkiKenttienTyhjennys();

            this.mokkiTableAdapter.Fill(vn.mokki);
        }

        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vn);
            vn.mokki.Rows[this.dataGridViewMokki.SelectedRows[0].Index].Delete();

            Validate();
            mokkiTableAdapter.Update(this.vn.mokki);
            this.mokkiTableAdapter.Fill(vn.mokki);
            MokkiKenttienTyhjennys();
        }

        private void MokkiKenttienTyhjennys()
        {
            dataGridViewMokki.CurrentCell = null;
            tbMokkinimi.Text = string.Empty;
            tbKatuosoite.Text = string.Empty;
            tbKuvaus.Text = string.Empty;
            cbHenkilomaara.SelectedItem = null;
            tbVarustelu.Text = string.Empty;
            cbPostiNro.SelectedItem = null;
            tbMokinHinta.Text = string.Empty;
            dataGridViewMokki.CurrentCell = null;
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
            toimintaalueTableAdapter.Update(this.vn);
            toimintaalueTableAdapter.Insert(tbToimintaAlueNimi.Text);
            this.toimintaalueTableAdapter.Fill(this.vn.toimintaalue);

            ToimintaAlueMuokkausEnable();
        }

        //Toiminta-alueen nimen muokkaaminen
        private void btnMuokkaaAluetta_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vn);
            //Muuttaa taulukosta valitun toiminta-alueen nimen.
            vn.toimintaalueRow toimintaalueRow = vn.toimintaalue.FindBytoimintaalue_id(long.Parse(tbToimintaAlueID.Text));
            toimintaalueRow.nimi = tbToimintaAlueNimi.Text;

            Validate();
            toimintaalueTableAdapter.Update(this.vn);
            this.toimintaalueTableAdapter.Fill(this.vn.toimintaalue);

            ToimintaAlueMuokkausEnable();
        }

        //Toiminta-alueen poistaminen
        private void btnPoistaToimintaAlue_Click(object sender, EventArgs e)
        {
            Validate();
            toimintaalueBindingSource.EndEdit();
            toimintaalueTableAdapter.Update(this.vn);

            vn.toimintaalueRow toimintaalueRow = vn.toimintaalue.FindBytoimintaalue_id(long.Parse(tbToimintaAlueID.Text));
            toimintaalueTableAdapter.Delete(toimintaalueRow.toimintaalue_id, toimintaalueRow.nimi);
            Validate();
            toimintaalueTableAdapter.Update(this.vn);

            this.toimintaalueTableAdapter.Fill(this.vn.toimintaalue);

            ToimintaAlueMuokkausEnable();
        }

        //lisää tai poistaa näkyviltä alueen poisto ja lisäyspainikkeet
        private void ToimintaAlueMuokkausEnable()
        {
            if (btnToimintaAlueMuokkaus.Text == "Hallitse alueita")
            {
                dataGridViewToimintaAlue.CurrentCell = null;
                lblAlueenNimi.Enabled = true;
                btnLisaaToimintaAlue.Enabled = true;
                btnPoistaToimintaAlue.Enabled = true;
                btnMuokkaaAluetta.Enabled = true;
                tbToimintaAlueNimi.Enabled = true;
                btnToimintaAlueMuokkaus.Text = "Peruuta";

            }
            else if (btnToimintaAlueMuokkaus.Text == "Peruuta")
            {
                dataGridViewToimintaAlue.CurrentCell = null;
                lblAlueenNimi.Enabled = false;
                btnLisaaToimintaAlue.Enabled = false;
                btnPoistaToimintaAlue.Enabled = false;
                btnMuokkaaAluetta.Enabled = false;
                tbToimintaAlueNimi.Enabled = false;
                btnToimintaAlueMuokkaus.Text = "Hallitse alueita";
                tbToimintaAlueNimi.Text = string.Empty;
            }
        }

        #endregion

        private void btnPalaa_Click(object sender, EventArgs e)
        {
            PoistaMokkiPanelitNakyvista();
            PoistaMokinPainikkeetNakyvista();
        }
    }
}
