using lab07v02;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System;

namespace labRevisionUA2
{
    internal class TestCarnet
    {
        static void Main(string[] args)
        {
            //1 - Créer deux adresses nommées respectivement d1 et d2.
            Adresse d1 = new Adresse(91, "boulevard de la Gappe", "Gatineau", "J8T0B5", "QC");
            Adresse d2 = new Adresse(92, "rue Principale", "Montreal", "H1", "QBC");

            //2 - Afficher l’adresse d1.
            Console.WriteLine(d1.ToString()); 
            Console.WriteLine(d2.ToString());

            //3 - Créer 4 contacts nommés respectivement c1, c2, c3 et c4. Utiliser différents constructeurs pour créer vos objets.
            Contact c1 = new Contact("Itim", "Hamou");
            Contact c2 = new Contact("Mana", "Safia",215824, new Adresse(400,"Stewart St","Ottawa","K1N6L2","ON"));
            Contact c3 = new Contact("Aissani", "Kheira", 4131216725);
            Contact c4 = new Contact("Drif", "Mohand",9786573124,d1);

            //4 - Afficher les contacts c1 et c2.
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());

            //5 - Tester l’égalité de c1 et c2 et afficher le résultat.
            Console.WriteLine($"Test Egalité c1 et c2: {c1.Egalite(c2)}");

            //6 - Est - ce que c1 possède un téléphone.
            Console.WriteLine($"Test si c1 possede un telephoen:{c1.HasPhone()}");
            Console.WriteLine($"Test si c4 possede un telephoen:{c4.HasPhone()}");
            Console.WriteLine("Modification a approuver!");

            //7 - Définir le carnet d’adresse cd1.
            //8 - Ajouter vos contacts c1, c2, c3 et c4 à cd1.
            //9 - Ajouter d’autres contacts en appelant les autres méthodes d’ajout de contact (AddContact).Vous devez utiliser toutes les méthodes.
            //10 - Chercher et afficher le contact dont le numéro est 5.
            //11 - Chercher et afficher le contact dont le numéro est 500.
            //12 - Chercher et afficher le contact dont le nom est « Bouhlel » et la province est « QC »
            //13 - Afficher le nombre de contact de la province « QC ».
            //14 - Afficher la liste des contacts de la province « ON ».
            //15 - Afficher la liste des contacts de la province « QC ».
            //16 - Supprimer le contact dont le numéro est 5.
            //17 - Supprimer le contact dont le numéro est 500.
            //18 - Afficher le carnet de contact.

        }
    }
}
