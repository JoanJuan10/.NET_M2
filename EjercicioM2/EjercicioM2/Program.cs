using System;
using System.Collections.Generic;

namespace EjercicioM2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> nom = new List<char>();
            nom.Add('J');
            nom.Add('O');
            nom.Add('A');
            nom.Add('N');


            foreach (char letra in nom)
            {
                if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                    Console.WriteLine("VOCAL");
                }
                else if (Char.IsDigit(letra))
                {
                    Console.WriteLine("Els noms no contenen numeros!");
                }
                else
                {
                    Console.WriteLine("CONSONANT");
                }
                

            }
        }
    }
}
