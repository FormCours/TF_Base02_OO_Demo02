using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_02_Indexeurs
{
    class Casier
    {
        // Diconnaire symbolisant les casiers disponible
        private Dictionary<int, List<Matos>> _Contenu;


        // Initialisation des casiers
        public Casier(int numeroDepart, int nombre)
        {
            _Contenu = new Dictionary<int, List<Matos>>();

            int numero = numeroDepart;
            for (int i = 0; i < nombre; i++)
            {
                _Contenu.Add(numero, new List<Matos>());
                numero++;
            }
        }

        // Méthode pour ajouter du matos dans un casier
        public bool AjouterMatos(int numero, Matos matos)
        {
            if(!_Contenu.ContainsKey(numero))
            {
                return false;
            }

            List<Matos> m = _Contenu[numero];
            m.Add(matos);

            return true;
        }

        // Méthode pour vider un casier
        public bool Vider(int numero)
        {
            if (!_Contenu.ContainsKey(numero))
            {
                return false;
            }

            _Contenu[numero].Clear();
            return true;
        }


        // Récuperation d'un casier (Sans utiliser le principe d'indexeur)
        public List<Matos> GetMatos(int numero)
        {
            if (!_Contenu.ContainsKey(numero))
            {
                return null;
            }

            return _Contenu[numero];
        }

        // Récuperation d'un casier (Via un Indexeur d'acces)
        public List<Matos> this[int numero]
        {
            get
            {
                if (!_Contenu.ContainsKey(numero))
                {
                    return null;
                }

                return _Contenu[numero];
            }
        }

    }
}
