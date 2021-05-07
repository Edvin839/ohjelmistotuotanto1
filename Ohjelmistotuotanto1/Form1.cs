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
            // TODO: This line of code loads data into the 'dataSet1.asiakas' table. You can move, or remove it, as needed.
            this.AsiakasTableAdapter.Fill(this.vnDataSet.asiakas);
        }

        //Asiakashallinta

        //Paneelien näkyvyys:
        private void CbtnLisaaAsiakas_Click(object sender, EventArgs e)
        {
            AloitusPaneeli.Visible = false;
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
            AloitusPaneeli.Visible = false;
            PanelMuokkaaAsiakasta.Visible = true;
            PanelLisaaAsiakas.Visible = false;
            PanelPoistaAsiakas.Visible = false;

            MiniPanelMuokkaa.Visible = false;
        }    
        private void CbtnPoistaAsiakas_Click(object sender, EventArgs e)
        {
            AloitusPaneeli.Visible = false;
            PanelPoistaAsiakas.Visible = true;
            PanelLisaaAsiakas.Visible = false;
            PanelMuokkaaAsiakasta.Visible = false;
        }

        //Palaa Asiakashallintaan buttonit
        private void btnPalaaAsiakasHallintaan2_Click(object sender, EventArgs e)
        {
            PanelMuokkaaAsiakasta.Visible = false;
            PanelLisaaAsiakas.Visible = false;
            PanelPoistaAsiakas.Visible = false;
            AloitusPaneeli.Visible = true;
        }
        private void btnPalaaAsiakasHallintaan3_Click(object sender, EventArgs e)
        {
            PanelMuokkaaAsiakasta.Visible = false;
            PanelLisaaAsiakas.Visible = false;
            PanelPoistaAsiakas.Visible = false;
            AloitusPaneeli.Visible = true;
        }
        private void btnPalaaAsiakasHallintaan_Click(object sender, EventArgs e)
        {
            PanelLisaaAsiakas.Visible = false;
            PanelMuokkaaAsiakasta.Visible = false;
            PanelPoistaAsiakas.Visible = false;
            AloitusPaneeli.Visible = true;
        }

        //Lisää Asiakas
        private void btnTallennaUusiAsiakas_Click(object sender, EventArgs e)
        {          
            Validate();
            asiakasBindingSource.EndEdit();
            AsiakasTableAdapter.Update(this.vnDataSet);
            AsiakasTableAdapter.Insert(cbPostinro.Text, tbEtunimi.Text, tbSukunimi.Text, tbLahiosoite.Text, tbEmail.Text,tbPuhelinnro.Text);
            AsiakasTableAdapter.Fill(vnDataSet.asiakas);

            MessageBox.Show("Tiedot tallennettu onnistuneesti!");                    
        }

        private void cbPostinro_SelectedIndexChanged(object sender, EventArgs e)
        {   //Postinumero on valittu, näytetään labelissa kaupunki
            List<string> postinumerot = new List<string>();
            postinumerot.Add("HELSINKI");
            postinumerot.Add("KUOPIO");
            postinumerot.Add("KUUSAMO");
            postinumerot.Add("ÄKÄSLOMPOLO");
            postinumerot.Add("TAHKOVUORI");
            lblPostiKaupunki.Text = postinumerot[cbPostinro.SelectedIndex];
        }

        //Muokkaatietoja
       

        //Poista tiedot
        private void btnPoistaAsiakas_Click(object sender, EventArgs e)
        {           
            asiakasBindingSource.RemoveAt(DGPoista.CurrentCell.RowIndex);
            Validate();
            AsiakasTableAdapter.Update(this.vnDataSet);
            this.AsiakasTableAdapter.Fill(vnDataSet.asiakas);
        }

        //Asiakkaan tietojen Rajoituksia
        private void tbPuhelinnro_KeyPress(object sender, KeyPressEventArgs e)
        { //Sallii vain numeroiden kirjoittamisen
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar)) 
                e.Handled = true;
        }
        private void tbEtunimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            string etunimiTeksti = tbEtunimi.Text;
           if (etunimiTeksti.Length > 20)
           {
              MessageBox.Show("Etunimi ei voi olla yli 20 merkkiä!");
           }                  
        }
        private void tbSukunimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sukunimiTeksti = tbSukunimi.Text;
            if (sukunimiTeksti.Length > 40)
            {
                MessageBox.Show("Sukunimi ei voi olla pidempi kuin 40 merkkiä!");
            }
        }
        private void tbLahiosoite_KeyPress(object sender, KeyPressEventArgs e)
        {
            string lahiosoiteTeksi = tbLahiosoite.Text;
            if (lahiosoiteTeksi.Length > 40)
            {
                MessageBox.Show("Lähiosoite ei voi olla pidempi kuin 40 merkkiä!");
            }
        }
        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            string emailTeksti = tbEmail.Text;
            if (emailTeksti.Length > 50)
            {
                MessageBox.Show("Sähköpostiosoite ei voi olla yli kuin 50 merkkiä!");
            }

        }

        private void btnEtsiPoistettava_Click(object sender, EventArgs e) //KESKEN
        {
            string etsiAsiakas = tbHaePoistettavaAsiakas.Text;
            DGPoista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridView rivi in DGPoista.Rows)
                {

                    if (rivi.Columns[4].ValueType.ToString().Equals(etsiAsiakas))
                    {
                        rivi.AllowUserToAddRows = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tällä tiedolla ei löytynyt ketään.");
            }
        }

    

        private void btnTallennaAsiakkaanMuokkaukset_Click(object sender, EventArgs e) //KESKEN tallennukset
        {
            foreach (DataGridViewRow rivit in DGMuokkaa.Rows)
            {
                if (rivit.Cells[1].ToString() == tbEtunimi.Text)
                {
                   // rivit.Cells[1] = tbMuokkaaEtunimi.Text;
                    AsiakasTableAdapter.Update(vnDataSet);
                }
            }
            
            Validate();
            AsiakasTableAdapter.Update(this.vnDataSet);
            AsiakasTableAdapter.Insert(cbMuokkaTietojaPostinro.Text, tbMuokkaaEtunimi.Text, tbMuokkaaSukunimi.Text, tbMuokkaaLahiosoite.Text, tbMuokkaaEmail.Text, tbMuokkaaPuhelinnro.Text);
            //AsiakasTableAdapter.Fill(vnDataSet.asiakas);

            MessageBox.Show("Tiedot tallennettu onnistuneesti!");
        }

        private void DGMuokkaa_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e) //Option 2 hos Muokkaa napin kautta ei lähde  toimimaan
        {
            MiniPanelMuokkaa.Visible = true;
            int i;
            i = e.RowIndex;
            DataGridViewRow rivi = DGMuokkaa.Rows[i];
            tbMuokkaaEtunimi.Text = rivi.Cells[1].Value.ToString();
            tbMuokkaaSukunimi.Text = rivi.Cells[2].Value.ToString();
            tbMuokkaaLahiosoite.Text = rivi.Cells[4].Value.ToString();
            cbMuokkaTietojaPostinro.Text = rivi.Cells[5].Value.ToString();
            tbMuokkaaEmail.Text = rivi.Cells[6].Value.ToString();
            tbMuokkaaPuhelinnro.Text = rivi.Cells[3].Value.ToString();

            List<string> postinumerot2 = new List<string>();
            postinumerot2.Add("HELSINKI");
            postinumerot2.Add("KUOPIO");
            postinumerot2.Add("KUUSAMO");
            postinumerot2.Add("ÄKÄSLOMPOLO");
            postinumerot2.Add("TAHKOVUORI");
            lblMuokkaaTietojaPostinro.Text = postinumerot2[cbMuokkaTietojaPostinro.SelectedIndex];
        }
    }     
}
