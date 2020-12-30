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

            Dictionary<char, int> nomD = new Dictionary<char, int>();

            nomD.Add('J', 0);
            nomD.Add('O', 0);
            nomD.Add('A', 0);
            nomD.Add('N', 0);


            foreach (var letra in nom)
            {
                
                if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                    Console.WriteLine("VOCAL");
                    nomD[letra]++;
                }
                else if (Char.IsDigit(letra))
                {
                    Console.WriteLine("Els noms no contenen numeros!");
                }
                else
                {
                    Console.WriteLine("CONSONANT");
                    nomD[letra]++;
                }
            }
            List<char> cognom = new List<char>();
            cognom.Add('B');
            cognom.Add('A');
            cognom.Add('Z');
            cognom.Add('A');

            List<char> fullName = new List<char>();


            foreach (var letra in nom)
            {
                fullName.Add(letra);
            }
            fullName.Add(' ');
            foreach (var letra in cognom)
            {
                fullName.Add(letra);
            }


        }
    }
}
