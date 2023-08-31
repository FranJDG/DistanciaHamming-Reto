using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaHamming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = "Hola, soy la cadena 1";
            string cadena2 = "Hola, soy la cadena 2";            

            if (cadena1.Length != cadena2.Length)
                throw new Exception("Longitudes distintas");

            int contador = 0;
            int contador2 = 0;
            
            for (int i = 0; i < cadena1.Length; i++)
            {
                if (cadena1[i] == cadena2[i])
                {
                    contador++;
                }
                else
                {
                    contador2++;
                }
            }                        

            Console.WriteLine("la cadena uno coincide con la cadena 2 en " +  contador + " caracteres.");
            Console.WriteLine("se diferencian en " + contador2 + " caracteres.");
            
        }
    }
}
