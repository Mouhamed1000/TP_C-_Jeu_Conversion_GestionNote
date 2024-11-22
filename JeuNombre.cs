using System;
using System.Collections;

namespace Jeu;

class JeuNombres
{
    static void Main()
    {
        int nombre, alea = 5;
        int i = 0, j = 0, borne1 = 1, borne2 = 10, nbrTentative = 0, nbrPossib = 0;
        double  note = 0.0;
        ArrayList choixFaits = new ArrayList();
        while (true)
        {
            try
            {
                if (j == 0)
                {
                    //Debut du jeu
                    Console.WriteLine("Ce programme est un jeu de nombre. Vous devriez saisir 2 nombres (bornes du jeu ) pour commencer");
                    Console.WriteLine("Saisissez un nombre (borne1 de ce jeu)");
                    borne1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Saisissez un autre nombre (borne2 de ce jeu)");
                    borne2 = Convert.ToInt32(Console.ReadLine());
                    if (borne1 >= borne2)
                    {
                        Console.WriteLine("Le premier nombre saisi doit être inférieur au second. Veuillez réessayer !");
                        throw new Exception("Le premier nombre saisi doit être inférieur au second.");
                    }
                    else
                    {
                        //Nombre aleatoire
                        alea = new Random().Next(borne1, borne2 + 1);
                    }
                }
                j++;

                //Differents controles pour ce jeu
                if (borne1 < borne2)
                    Console.WriteLine("saisissez un nombre entre " + borne1 + " et " + borne2);
                nombre = Convert.ToInt32(Console.ReadLine());
                if (nombre == alea)
                {
                    nbrPossib = borne2 - borne1;
                    //Ici on compte le nombre de choix faits
                    nbrTentative = choixFaits.Count;
                    note = nbrPossib / nbrTentative; 
                    Console.WriteLine ("vous avez gagné");
                    Console.WriteLine("Votre note est : " + note);
                    break;
                }
                else 
                {
                    if (nombre < borne1 || nombre > borne2)
                    {
                        throw new ArgumentException("Saisissez un nombre compris entre [" + borne1 + ", " + borne2 + "].");
                    }
                    else
                    {   
                        i++;
                        choixFaits.Add(nombre);
                        Console.WriteLine("vous avez perdu");
                    }
                }
                if (i>=1)
                {
                    Console.WriteLine("Choix déjà effectués : " + string.Join(", ", choixFaits.ToArray()));
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("La donnée saisie doit être un nombre");
            }
            catch (Exception e)
            {
                //On verifie juste que le premier nombre saisi est inferieur au second
                if (borne1 < borne2)
                    Console.WriteLine("Saisissez un nombre compris entre [" + borne1 + ", " + borne2 + "].");
            }
        }


    }
}
