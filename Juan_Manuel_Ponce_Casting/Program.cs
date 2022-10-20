using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juan_Manuel_Ponce_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Elegir ejemplo:");
            Console.WriteLine("Escribir 1 para casting implicito");
            Console.WriteLine("Escribir 2 para casting explicito");
            Console.WriteLine("Escribir 3 para metodo de conversion");

            string codeEjemplo = Console.ReadLine();

            if (codeEjemplo == "1") // Implicito
            {
                int myInt = 256;
                double myDouble = myInt;       // Casting automatico int a doble, int ocupa menos memoria que double entoces es pocible el cating implicito

                Console.WriteLine(myInt);      // Valor antes de la conversion || Outputs 256
                Console.WriteLine(myDouble);   // Valor despues de la conversion || Outputs 256
                Console.ReadKey(); 
            }
            else if (codeEjemplo == "2") //Explicito
            {
                double numDouble = 1.23;
                int numInt = (int)numDouble;
              
                Console.WriteLine(numDouble);// Valor antes de la conversion || Outputs 1.23
                Console.WriteLine(numInt);// Valor despues de la conversion || Outputs 1
                Console.ReadKey();
            }
            else if (codeEjemplo =="3")
            {
                int myInt = 10;
                double myDouble = 5.25;
                bool myBool = true;

                Console.WriteLine(Convert.ToString(myInt));    // Convierte int a string
                Console.WriteLine(Convert.ToDouble(myInt));    // Convierte int a double
                Console.WriteLine(Convert.ToInt32(myDouble));  // Convierte double a int32
                Console.WriteLine(Convert.ToString(myBool));   // Convierte bool a string
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Elejir un ejemplo valido. Pulse una tecla para finalizar");
                Console.ReadKey();
            }
        }
    }
}
