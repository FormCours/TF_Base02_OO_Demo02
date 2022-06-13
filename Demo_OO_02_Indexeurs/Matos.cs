using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_02_Indexeurs
{
    class Matos
    {
        private string _Nom;
        private string _Categorie;

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        public string Categorie
        {
            get { return _Categorie; }
            set { _Categorie = value; }
        }

        public Matos(string nom, string utilite)
        {
            this.Nom = nom;
            this.Categorie = utilite;
        }
    }
}
