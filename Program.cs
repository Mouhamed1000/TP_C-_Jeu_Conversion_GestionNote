using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UsageCollections;

namespace UsageCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int reponse = 10;
            SortedList liste2;
            //Debut
            Etudiant e1 = new Etudiant();
            liste2 = e1.AddStudents();
            while (!reponse.Equals(3) )
            {
                Console.WriteLine("Menu");
                //Permettre d'afficher le nom, les notes et la moyenne d'un étudiant
                Console.WriteLine("1. Voulez-vous afficher le nom, les notes et la moyenne d'un étudiant de la classe");
                //Permettre de terminer
                Console.WriteLine ("2. Souhaitez-vous terminer le programme");
                 //Infos de tous les étudiants
                Console.WriteLine("3. Voulez-vous afficher le nom, les notes et la moyenne de tous les étudiants de la classe");

                reponse = Convert.ToInt32(Console.ReadLine());

                if (reponse.Equals("3"))
                {
                    break;
                }
                else
                {
                    if (reponse.Equals (1))
                    {
                        AfficherUn(liste2);
                    }
                    if (reponse.Equals(2))
                    {
                        afficherTout(liste2);
                    }
                    while ( (!(reponse.Equals(1))) && (!(reponse.Equals(1))) && (!(reponse.Equals(1))) )
                    {
                        Console.WriteLine("Saisissez un nombre entre entre 1 et 3");
                        reponse = Convert.ToInt32(Console.ReadLine());
                    }
                }
            } 
        }

        public static void AfficherUn(SortedList liste)
        {
            Console.WriteLine("Veuillez entrer le nom d'un étudiant");
            string unEtudiant = Console.ReadLine();
            Console.WriteLine("-----------Infos d'un étudiant de la classe-----------");
            foreach (DictionaryEntry etudiant in liste)
            {
                Etudiant e3 = (Etudiant)etudiant.Value;
                if (e3 != null && e3.nom != null  && e3.nom.Equals(unEtudiant))
                {
                    Console.WriteLine(e3);
                }
            }
        }
        public static void afficherTout(SortedList liste)
        {
            Console.WriteLine("-----------Infos des étudiants de la classe-----------");
            foreach (DictionaryEntry etudiant in liste)
            {
                Etudiant e2 = (Etudiant)etudiant.Value;
                Console.WriteLine(e2);
            }
        }

    }

}
