using System;

namespace tp_6_eje_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string entrada;
            int num, num1, resultado;
            num = 0;
            num1 = 0;
            resultado=0;
            
            Console.WriteLine("Escriba un numero entero");
            entrada = Console.ReadLine();
            num = Convert.ToInt32(entrada);

            Console.WriteLine("Escriba un numero entero");
            entrada = Console.ReadLine();
            num1 = Convert.ToInt32(entrada);
            
            resultado=sumar(num,num1);

            Console.WriteLine("El resultado de la suma {0} + {1} es {2}",num,num1, resultado);

        }
        static int sumar(int num,int num1){

            int resultado=0;
            resultado=num+num1;
            return resultado;
        }
    }
}
