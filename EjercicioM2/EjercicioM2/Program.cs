using System;
using System.Collections.Generic;
using System.Threading;

namespace EjercicioM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Milestone3();
        }
        static void Milestone1 ()
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
        static void Milestone2()
        {
            Console.WriteLine("Introduce la altura");
            int altura = Convert.ToInt32(Console.ReadLine());

            string piramideNums = "";
            for (int i = 1; i <= altura; i++) 
            {
                piramideNums += i;
                Console.WriteLine(piramideNums);
            }

            int numEstrelles = 1 + (2 * (altura - 1));

            piramideNums = "";
            int numEspacios = 0;

            for (int i = numEstrelles; i >= 1; i -= 2)
            {
                
                for (int j = 0; j < i; j++)
                {
                    piramideNums += "*";

                }
                Console.WriteLine(piramideNums);
                piramideNums = "";
                numEspacios++;
                for (int j = 0; j < numEspacios; j++)
                {
                    piramideNums += " ";
                }
            }
        }
        static void Milestone3()
        {
            int seconds = 0;
            int minutes = 0;
            int hours = 0;

            while (true)
            {
                Console.Clear();

                if (hours < 10)
                {
                    Console.Write("0{0}",hours);
                }
                else
                {
                    Console.Write("{0}", hours);
                }
                Console.Write(":");
                if (minutes < 10)
                {
                    Console.Write("0{0}", minutes);
                }
                else
                {
                    Console.Write("{0}", minutes);
                }
                Console.Write(":");
                if (seconds < 10)
                {
                    Console.Write("0{0}", seconds);
                }
                else
                {
                    Console.Write("{0}", seconds);
                }
                Thread.Sleep(1000);
                seconds++;
                if (seconds >= 60)
                {
                    seconds = 0;
                    minutes++;
                    if (minutes >= 60)
                    {
                        minutes = 0;
                        hours++;
                        if (hours >= 24)
                        {
                            hours = 0;
                        }
                    }
                }
            }
        }
    }
}
