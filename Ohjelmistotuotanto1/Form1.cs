﻿using System;
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
        }

        //LaskutBtn toiminnallisuus

        private void LaskutBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Laskut";
        }
    }
}