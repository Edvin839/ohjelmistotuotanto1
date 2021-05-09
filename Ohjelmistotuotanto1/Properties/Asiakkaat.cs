using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmistotuotanto1.Properties
{
    class Asiakkaat
    {
        private string etunimi;
        private string sukunimi;
        private string lahiosoite;
        private string email;
        private string puhelinnro;
        private char postinnro;

        private string Etunimi { get { return etunimi; } }
        private string Sukunimi { get { return sukunimi; } }
        private string Lähiosoite { get { return lahiosoite; } }
        private string Sähköposti { get { return email; } }
        private string Puhelinnumero { get { return puhelinnro; } }
        private char Postinumero { get { return postinnro; } }
    }
}
