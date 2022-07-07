Using System;
Using System.Collections.Generic;
Using System.Linq;
Using System.Text;
Using System.Threading.Tasks;

Namespace ConsoleApplication5
{
    Class Program
    {
        Static void Main(String[] args)
        {
            //Console.WriteLine("HOLA MUNDO!!!");
            int num1 = 5;
            int numero2 = 6;
            Double numero3 = 2.57;
            Double suma;
            suma = num1 + numero3;

            Console.WriteLine(suma);
            String valor1 = Console.ReadLine();
            Console.WriteLine("El numero introducido es: " + valor1);
            int valorint = Convert.ToInt32(valor1);

            Console.ReadKey();
        }
    }
}
