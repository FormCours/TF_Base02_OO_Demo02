using System;
using System.Collections.Generic;

namespace Demo_OO_02_Indexeurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Matos matos1 = new Matos("Pelle", "Outils");
            Matos matos2 = new Matos("Pince", "Outils");
            Matos matos3 = new Matos("Rateau", "Outils");
            Matos matos4 = new Matos("Marteau", "Outils");
            Matos matos5 = new Matos("Boite à tartine", "Nourriture");
            Matos matos6 = new Matos("Gourde", "Nourriture");


            Casier casier = new Casier(1, 5);

            casier.AjouterMatos(1, matos1);
            casier.AjouterMatos(1, matos3);
            casier.AjouterMatos(2, matos5);
            casier.AjouterMatos(2, matos6);
            casier.AjouterMatos(4, matos4);
            casier.AjouterMatos(5, matos2);


            // Récuperation du contenu du casier "1" via la méthode 
            List<Matos> casier1 = casier.GetMatos(1);

            // Récuperation du contenu du casier "2" via l'indexeur 
            List<Matos> casier2 = casier[2];

        }
    }
}
