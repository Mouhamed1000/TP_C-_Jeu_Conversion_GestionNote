namespace Tp1;

using System;
using System.Collections;
using System.Linq.Expressions;

class Conversion
{
    static void Main()
    {
        string reponse = "oui";
        ArrayList allNombre = new ArrayList();

        int nombre = 1, j = 0;
        string chaines = "";

        while (reponse.ToLower().Equals("oui"))
        {


            Console.WriteLine("Ce programme convertit un entier en une chaîne hexadécimale");
            Console.WriteLine("Ecrivez un nombre pour commencer");
            // int nombre;
            bool verite = int.TryParse(Console.ReadLine(), out nombre) ;
            while (verite == false)
            {
                Console.WriteLine("La valeur saisie doit être un nombre");
                Console.WriteLine("Entrez un nombre");
                verite = int.TryParse(Console.ReadLine(), out nombre) ;
            }  

            int chiffre1 = nombre % 16;

            ArrayList chiffres = new ArrayList();

            int i = 0;

            string chiffre = getChiffre (chiffre1);
            chiffres.Add(chiffre);

            int quotient = (nombre / 16);

            int ResteQuotient = 19;

            while (ResteQuotient != 0) 
            {
                i++;

                ResteQuotient  = quotient % 16;

                string chiffreSuiv = getChiffre (ResteQuotient);
                chiffres.Add(chiffreSuiv);

                quotient /= 16;

                Console.WriteLine( "i : " + i);

            }

            chaines = "";

            Console.WriteLine ("Ensemble des restes de la division hexadécimale de " + nombre );

            for (int l = i; l >= 0; l--)
            {
                Console.WriteLine ("Reste (" + l + ") = " + chiffres[l]);
                chaines += chiffres[l];
            }
            
            allNombre.Add(nombre + " (décimale) = " + chaines + " (hexadécimale)");

            Console.WriteLine ("Voulez-vous entrer un autre nombre (oui/non)");
            reponse = Console.ReadLine();

            while (!(reponse.ToLower().Equals("oui")) && (!(reponse.ToLower().Equals("non"))))
            {
                Console.WriteLine("Veuillez saisir oui ou non si vous souhaiter entrez un autre numéro ? (oui ou non)");
                reponse = Console.ReadLine();
            }
            j++;

        }

        Console.WriteLine("-----Liste de tous les nombres convertis en hexadécimale-----");
        
        for (int m = 0; m < j; m++)
        {
            Console.WriteLine (allNombre[m]);
        }

    }

    public static string getChiffre (int unChiffre)
    {
        switch (unChiffre)
        {
            case 10 : return "A";

            case 11 : return "B";

            case 12 : return "C";

            case 13 : return "D";

            case 14 : return "E";

            case 15 : return "F";

            default : return unChiffre.ToString();                  
        }
    }


}   
