using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmistotuotanto1.Properties
{
    class Asiakkaat
    {
      
      //  private char postinro;
        public string etunimi;
        public string sukunimi;
        public string lahiosoite;
        public string email;
        public string puhelinnro;

        public string Etunimi { get { return etunimi; } }
        public string Sukunimi {  get { return sukunimi; } }
        public string Lähiosoite { get { return lahiosoite; } }
        public string Sähköposti { get { return email; } }
        public string Puhelinnumero { get { return puhelinnro; } }

    }
}
