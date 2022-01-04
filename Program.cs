using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ElementdeBase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------Les elements de base de C#---------------*/

            //Les Variables
            /* double note = 5.5;
             Console.WriteLine("la note est = " + note);

             int i = (int)note;
             Console.WriteLine("La note en entier est = " + i);
             Console.Write("Vous avez une note au dessus de la moyenne");
             Console.Write("Bravo!!!!!!");
             Console.ReadKey();
             */
            
            Console.WriteLine("======             Lecture de variable      ======");
            Console.WriteLine("Entrer une valeur = ");
            string var = Console.ReadLine();
            Console.WriteLine("Vous avez tapper = " + var);
            Console.WriteLine("Le type de la variable est = " + var.GetType());
            
            Console.WriteLine("======            Conversion de variable      ======");
            int varInt;
            varInt = Convert.ToInt32(var);
            Console.WriteLine("Votre variable est maintenant de type= " + varInt.GetType());
          

            Console.WriteLine("======            Parsing                     ======");
            int varInt2 = int.Parse(var);
            Console.WriteLine("La variable maintenant a la fin est de type " + varInt2.GetType()); 
            Console.ReadKey();
        }
    }
}
