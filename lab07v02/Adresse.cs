using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab07v02
{
    class Adresse
    {
        // Dans un premier temps, nous allons écrire une classe nommée Adresse.Une adresse est
        //caractérisée par un numéro (entier), le nom de la rue (chaîne), la ville (chaîne), le code
        //postal (chaîne) et la province (chaîne). Vous devez prendre en considération les règles
        //suivantes pour les attributs :
        //- Le code postal est une chaîne composée de 6 caractères.Sinon on affecte la valeur
        //« K1K1K1 ».
        //- La province est une chaine composée de deux lettres en majuscule.Sinon on affecte
        //la valeur « QC ».
        //On vous demande de :
        //1- Définir la classe Adresse et ses attributs.

        private int numero;
        private string nomRue;
        private string ville;
        private string codePostal;
        private string province;


        //2- Définir les propriétés associées aux attributs.
        public int Numero { get => numero; set => numero = value; }
        public string NomRue { get => nomRue; set => nomRue = value; }
        public string Ville { get => ville; set => ville = value; }
        public string CodePostal { get => codePostal; set => codePostal = (value.Length == 6) ? value : "K1K1K1"; }
        public string Province { get => province; set => province = (value.Length == 2) ? value.ToUpper() : "QC"; }
        
        //3- Définir un constructeur initialisant le numéro, le nom de rue, la ville, le code postal et la province.
        public Adresse(int numero,string nomRue, string ville, string codePostal, string province)
        {
            Numero = numero;
            NomRue = nomRue;
            Ville = ville;
            CodePostal = codePostal;
            Province = province;
        }


        //4- Définir une méthode nommée Egalite permettant de tester l’égalité de l’adresse courante avec l’adresse passée comme paramètre.
        //Deux adresses sont égales se elles ont le même numéro, le même nom de rue et la même province.
        public bool Egalite(Adresse autreAdresse)
        {
            if (autreAdresse != null && Numero == autreAdresse.Numero && NomRue ==autreAdresse.NomRue && Province==autreAdresse.Province) return true;
            else return false;
        }

        //5- Définir la méthode ToString permettant de convertir un objet adresse vers une chaine de caractères.La représentation de l’adresse est comme suit :
        //91, boulevard de la Gappe, Gatineau, QC, J8T-0B5
        
        public override string ToString()
        {
            if (this != null){ 
            return $"{Numero}, {NomRue}, {Ville},{Province}, {CodePostal.Substring(0,3)}-{CodePostal.Substring(3,3)}";}
            



        }

        //6- Surcharger l’opérateur « == » pour comparer deux adresses.
        public static bool operator ==(Adresse adresse1, Adresse adresse2)
        {
            // Vérifier si les deux adresses sont null
            if (ReferenceEquals(adresse1, null) && ReferenceEquals(adresse2, null))
            {
                return true; // Les deux adresses sont null, donc elles sont égales
            }

            // Si seulement l'une des adresses est null, elles ne sont pas égales
            if (ReferenceEquals(adresse1, null) || ReferenceEquals(adresse2, null))
            {
                return false;
            }
            return (adresse1.Egalite(adresse2));

        }
        public static bool operator !=(Adresse adresse1, Adresse adresse2)
        {
            return !(adresse1 == adresse2);

        }

    }
}
