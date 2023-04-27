using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string inputTexto;
            int opc,cont;
            opc = cont=  0;

            Console.WriteLine("Escribir algo: ");
            inputTexto = Console.ReadLine();
            Console.WriteLine("Ingresar 1 para Mayusculas - 2 para Minusculas - 3 para contar");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    inputTexto = inputTexto.ToUpper();
                    Console.WriteLine(inputTexto);
                    break;
                case 2:
                    inputTexto = inputTexto.ToLower();
                    Console.WriteLine(inputTexto);
                    break;
                case 3:
                    for ( int i= 0; i < inputTexto.Length; i++ )
                    {
                        cont++;
                        
                    }

                    Console.WriteLine("La cantidad de caracteres es: " + cont);
                    break;
            }
             if (inputTexto == string.Empty)
            {
                Console.WriteLine("No se ha ingresado texto");
            }
            
            

            
        }
    }
}
