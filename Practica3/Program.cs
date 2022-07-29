using System;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables

            string firstname = "Cindy";
            String lastname = "Valencia";
            int edad = 37;
            //Concatenacion de variables
            var name = firstname + " " + lastname;
            //Imprimir variables dentro del texto
            Console.WriteLine("Su nombre es: {0} y su edad es: {1}", name, edad);
        }
    }
}
