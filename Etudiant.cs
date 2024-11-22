using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UsageCollections
{
    public class Etudiant
    {
        private string Nom;
        private double NoteCC;
        private double NoteDevoir;
        public string nom { get; set; }
        public double noteCC { get; set; }
        public double noteDevoir { get; set; }

        SortedList liste1 = new SortedList();

        public int Age { get; set; }

        public Etudiant () {}
        public Etudiant (string nom, double noteCC, double noteDevoir)
        {
            Nom = nom;
            NoteCC = noteCC;
            NoteDevoir = noteDevoir;
        }

        // Trie par somme des notes avec un Comparer
        public class ComparerEtudiantParNote : IComparer<Etudiant>
        {
            public int Compare(Etudiant x, Etudiant y)
            {
                double totalX = x.NoteCC + x.NoteDevoir;
                double totalY = y.NoteCC + y.NoteDevoir;
                return totalX.CompareTo(totalY);  
            }
        }

        //Une méthode ToString() pour afficher les infos de l'etudiant
        public override string ToString()
        {
            double moyenne = (NoteCC * (33.0/100) ) + (NoteDevoir * (67.0/100));
            return $"Nom: {Nom} , Note CC: {NoteCC} , Note Devoir: {NoteDevoir} , Moyenne: {moyenne} ";
        }

        public SortedList AddStudents()
        {
            Console.WriteLine("Bienvenue dans le menu d'enregistrements des infos des étudiants");
            Console.WriteLine("Combien d'étudiants voulez-vous enregistrer");
            int nbreEtud = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<= nbreEtud; i++)
            {

                Console.WriteLine("Veuillez entrer le nom d'un étudiant : ");
                Nom = Console.ReadLine();

                Console.WriteLine("Veuillez entrer la note CC d'un étudiant : ");
                bool verite1 = Double.TryParse(Console.ReadLine(), out NoteCC);

                while(verite1 == false)
                {
                    Console.WriteLine("La valeur saisie doit être un nombre entier ou réel (x) ou (x,y)");
                    Console.WriteLine("Veuillez entrez un nombre");
                    verite1 = Double.TryParse(Console.ReadLine(), out NoteCC) ;
                }

                Console.WriteLine("Veuillez entrer la note Devoir d'un étudiant : ");
                bool verite2 = Double.TryParse(Console.ReadLine(), out NoteDevoir);

                while(verite2 == false)
                {
                    Console.WriteLine("La valeur saisie doit être un nombre entier ou réel (x) ou (x,y)");
                    Console.WriteLine("Veuillez entrez un nombre");
                    verite2 = Double.TryParse(Console.ReadLine(), out NoteDevoir) ;
                }

                var etudiant = new Etudiant(Nom, NoteCC, NoteDevoir);

                liste1.Add(Nom, etudiant);

                Console.WriteLine(Nom + " enregistré !");

            }
            return liste1;

        }

    }
    
}
