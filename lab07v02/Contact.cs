using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab07v02
{
    internal class Contact
    {
        //Dans un second temps, nous allons écrire une classe nommée Contact.Un contact est
        //caractérisé par son code (entier), son nom (chaîne), son prénom (chaîne), son téléphone
        //(entier) et son adresse (Adresse). Vous devez prendre en considération les règles suivantes
        //pour les attributs :
        //- Le code s’incrémente lors de la création d’un nouveau contact.
        //- Les prénoms sont en minuscules et les noms en majuscules.- Le téléphone, S’il existe, doit être composé de dix chiffres. Sinon on affecte la
        //valeur « 6131111111 » comme valeur par défaut.
        //On vous demande de :
        //1- Définir la classe Contact et ses attributs.
        private int code;
        private string nom;
        private string prenom;
        private long telephone;
        private Adresse adresse;
        public static int countContact = 0;



        //2- Définir les propriétés associées aux attributs.
        public int Code { get => code; }
        public string Nom { get => nom; set => nom = value.ToUpper(); }
        public string Prenom { get => prenom; set => prenom = value.ToLower(); }
        public long Telephone { get => telephone; set => telephone = (value == null || value.ToString().Length != 10) ? 6131111111 : value; }
        public Adresse Adresse { get => adresse; set => adresse = value; }



        //3- Définir un constructeur initialisant le nom et le prénom.
        public Contact(string nom, string prenom)
        {
            code = ++countContact;
            Nom = nom;
            Prenom = prenom;
            Telephone = 6131111111;
        }

        //4- Définir un constructeur initialisant le nom, le prénom et le téléphone.
        public Contact(string nom, string prenom, long telephone):this (nom,prenom)
        {            
            Telephone = telephone;
        }

        //5- Définir un constructeur initialisant le nom, le prénom, le téléphone et l’adresse.
        public Contact(string nom, string prenom, long telephone, Adresse adresse) : this(nom, prenom, telephone)
        {
            Adresse =adresse;
        }

        //6- Définir une méthode nommée HasPhone permettant de retourner true si le contact
        //courant possède un numéro de téléphone et false sinon.
        public bool HasPhone()
        {
            return !(Telephone == 6131111111);
        }

        //7- Définir la méthode ToString permettant de convertir un objet contact vers une chaine
        //de caractères.La représentation du contact est comme suit :
        //Code : 1
        //Nom : BOUHLEL mohamed
        //Tèlèphone : (613)123-4567
        //Adresse : 91, boulevard de la Gappe, Gatineau, QC, J8T-0B5
        
        public override string ToString()
        {
            return $"Code: {Code}\nNom:{Nom} {Prenom}\nTéléphone: ({Telephone.ToString().Substring(0,3)}){Telephone.ToString().Substring(3, 3)}-{Telephone.ToString().Substring(6, 4)}\n" +
                $"Adresse: {this.Adresse.ToString()}";
        }

        //8- Définir une méthode nommée Egalite permettant de tester l’égalité du contact courant
        //avec le contact passé comme paramètre.Deux contacts sont égaux s’ils ont le même
        //code et le même prénom.

        public bool Egalite(Contact autreContact)
        {
            return (autreContact != null && Code == autreContact.Code && Prenom == autreContact.Prenom);
        }
    }
}
