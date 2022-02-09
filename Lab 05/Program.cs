using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A. Demande à l’utilisateur le fruit qu’il préfère pour ensuite afficher à
                l’écran : « Merci, beaucoup de gens aiment aussi les » et ajouter à la
                suite de cette phrase le nom du fruit saisi à l’écran par l’utilisateur.
            */
            /*
            string fruit;
            Console.WriteLine("Quel est votre fruit preferée ? ");
            fruit = Console.ReadLine();

            Console.WriteLine("Merci, beaucoup de gens aiment aussi les "+fruit);
            */


            /*
             B. Demande à l’utilisateur le numéro de la page où il est rendu dans son
            livre, puis stock cette information dans une variable appropriée. Puis,
            l’application demande à la personne d’entrer le nombre de jour que
            cela lui a pris pour lire ce nombre de page, et stock cette information.
            Ensuite, l’instruction se poursuit, effectuant un calcul pour découvrir le
            nombre page ayant été lu par jour. Une instruction affiche ensuite à
            l’écran « Vous avez lu __ page par jour! »
            */
            /*
            int pageInitial;
            string convertInt;
            Console.WriteLine("Vous etes rendu a quel page de votre livre ?");
            convertInt = Console.ReadLine();
            pageInitial = int.Parse(convertInt);

            Console.WriteLine("Combien de jours ca vous a pris pour lires ces pages ?");
            int tempsLu = Convert.ToInt32(Console.ReadLine());

            int parjours = pageInitial / tempsLu;
            Console.WriteLine("Avec "+pageInitial+" de lu en "+ tempsLu+" jours, Vous lisez "+parjours+ " pages par jour.");
            */
            /*
            C. Simule un guichet automatique en demandant à la personne le montant
            de son retrait. Puis effectuer un calcul pour savoir si le montant du client
            est bien un multiple de 20$. Afficher le résultat du calcul à l’écran pour
            le montrer au client.
             */
            /*
            Console.WriteLine("Vous voulez retirer combien(Un montant qui est un multiple de 20 SVP)?");
            string input = Console.ReadLine();
            int montant;
            Int32.TryParse(input, out montant);
            int multiple = montant % 20;
            if (multiple == 0)
            {
                Console.WriteLine("Merci d'avoir entrer un multiple de 20$, voici "+(montant/20)+" billets de 20$");
            }
            else
                Console.WriteLine("Vous avez entree un montant qui n'est pas un multiple de 20.");
            */
            /*
             D. Demande à l’utilisateur d’entrer le montant d’une transaction et
                stocker ce montant dans une variable. Puis le système demande à
                l’utilisateur le pourcentage de la première taxe à appliquer et le stock
                en mémoire. Fait de même pour la deuxième taxe applicable. Le
                système effectue ensuite un calcul où : la première taxe sera appliquée
                et donnera un premier montant taxe incluse. Puis, appliquera la
                deuxième taxe sur ce résultat. Enfin, le système affichera ce grand total
                à l’écran.
             */
            /*
            Console.WriteLine("Le montant du transaction avant taxes :");
            double montant = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quel est pourcentage to premier tax (0.00-1.00):");
            double tax1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quel est pourcentage to deuxieme tax (0.00-1.00):");
            double tax2 = Convert.ToDouble(Console.ReadLine());


            double montantApresTaxes = montant + (montant * tax1) + (montant * tax2);

            Console.WriteLine("Le montant initial est de : "+montant+"$");
            Console.WriteLine("Le premier tax appliquer est de : "+tax1);
            Console.WriteLine("Le premier tax appliquer est de: "+tax2);
            Console.WriteLine("Le montant final est : "+montantApresTaxes);
            */
            /*
             E. Demande à l’utilisateur d’introduire un chiffre, et une largeur qui va
            représenter la base d’un triangle affiché en utilisant le chiffre entré.
            666666
            66666
            6666
            666
            66
            6 
             */
            /*
            Console.WriteLine("Produit un chiffre :");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maintenant la largeur de la base du triangle: ");
             int horizontal = Convert.ToInt32(Console.ReadLine());
            int vertical = 0;
           
            do {
                for(int i=0; i < horizontal; i++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
                vertical++;
                horizontal--;
            } while (vertical<20 );
            */
            /*f. Demande à l’utilisateur d’introduire un chiffre, et une largeur pour le carré qui sera affiché avec le chiffre entré.*/

            Console.WriteLine("Produit un chiffre :");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maintenant la largeur de la base du rectangle: ");
            int horizontal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maintenant la largeur de la base du rectangle: ");
            int maxhauteur = Convert.ToInt32(Console.ReadLine());
            int vertical = 0;

            do
            {
                for (int i = 0; i < horizontal; i++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
                vertical++;
                //horizontal--;
            } while (vertical < maxhauteur);



            Console.ReadKey();
        }
    }
}
