using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Visto actualmente: 
        Mostrar en pantalla
        Crear variables
        Operar con variables
        Condicionales
        Arrays
        Bucles

    Siguientes temas:
        Objetos, clases, atributos y metodos
        Encapsulamiento
        Herencia
        Polimorfismo
        Abstraccion
        Interfaz
        Sobrecarga de operadores
*/

namespace PrimerAvistamiento
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Tipos de variables
            int entero = 10;
            float flotante = 3.14f;
            double doble = 3.14159265359;
            char caracter = 'A';
            string cadena = "Hola, mundo!";
            short corto = 100;

            //Mostrar en consola
            Console.WriteLine("Valor de entero: " + entero);
            Console.WriteLine("Valor de flotante: " + flotante);
            Console.WriteLine("Valor de doble: " + doble);
            Console.WriteLine("Valor de caracter: " + caracter);
            Console.WriteLine("Valor de cadena: " + cadena);
            Console.WriteLine("Valor de corto: " + corto);
            //Operacion
            Console.WriteLine("Valor de suma entre entero y 10 = " + (entero + 10));

            //Cambio de tipo de variable
            cadena = "10";
            int entero2 = int.Parse(cadena);

            //Condicionales
            if (entero == entero2)
                Console.WriteLine(entero + " es igual a " + entero2);
            else
                Console.WriteLine(entero + " es diferente a " + entero2);

            //Vectores
            int[] vec = new int[10];
            int i;

            //Bucles
            for (i = 0; i < 10; i++)
                vec[i] = i + 1;

            while (i > 0)
            {
                Console.WriteLine("Vec[" + i + "] = " + vec[i - 1]);
                i--;
            }
            //Espera que se toque una letra
            Console.ReadKey();
        }
    }
}

