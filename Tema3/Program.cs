using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i = 100;
            long I = i;
            float f = I;
            Console.WriteLine("Int value " + i);
            Console.WriteLine("Long value " + I);
            Console.WriteLine("Float value " + f);
            Console.Read();*/

            /*double d = 100.09;
            long I = (long)d;
            int i = (int)d;
            Console.WriteLine("Long value " + I);
            Console.WriteLine("Double value " + d);
            Console.Read();*/

            /*int i = 12;
            double d = 765.12;
            float f = 56.123F;
            Console.WriteLine(Convert.ToString(f));
            Console.WriteLine(Convert.ToInt32(d));
            Console.WriteLine(Convert.ToUInt32(f));
            Console.WriteLine(Convert.ToDouble(i));
            Console.Read();*/

            /*int[] vector1;
            vector1 = new int[5];
            vector1[0] = 100;
            vector1[1] = 200;
            vector1[2] = 300;
            vector1[3] = 243;
            vector1[4] = 9;
            Console.Read();*/

            /*int[] numere = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(numere[3]);
            Console.Read();*/

            /*int[] arr;
            arr = new int[5];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("Element at index " + i + " : " + arr[i]);
            Console.Read();*/

            /* int[,] arr = new int[,]{{2,7,9},{3,6,1},{7,4,2}};
             for (int i=0; i<arr.Length;i++)
             { for (int j = 0; j < arr.Length; j++)
                     Console.WriteLine(arr[i,j] + " ");
                 Console.WriteLine();
             }
             Console.Read();
             //pe asta nu am inteles-o deloc; am scris la fel, dar imi da erori */

            /*string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.ReadLine();*/

            /*String text = "Numele meu este";
            String nume = " Ana";
            String textConcatenat = text + nume;
            Console.WriteLine(textConcatenat);
            Console.Read();*/

            //Tema 3
            // Ex.1 	Scrieti un program care stocheaza intr-un vector 3 variabile de tip double declarate de voi si le afiseaza parcurgand vectorul


            /*string[] zecimale = { "2.3", "1.1", "3.15" };
            for (int i = 0; i < zecimale.Length; i++)
            {
                Console.WriteLine(Convert.ToDouble(zecimale[i]));
            }
            Console.Read();*/

            //Ex.2 Scrieti un program care afiseaza minimul , respectiv maximul dintr-un array de lungime 10

            /* int[] arr = { 1,2,3,4,5,6,7,8,9,123 };
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine("Minim "+arr.Min());
                 Console.WriteLine("Maxim " + arr.Max());
             }
                 Console.Read();
             }*/



            //Ex.3 Scrieti o clasa ce declara un array de tip int cu o singura valoare negativa si restul pozitive. Afisati pozitia valorii negative din array.

            /*int[] arr = { -10, 2, 3, 4, 5, 7, 8, 9 };
            for (int i=0; i<arr.Length;i++)
            { if (arr[i] < 0) { Console.WriteLine(+i);
                    Console.WriteLine(arr[i]);
                }
            }
            Console.Read();*/

            //ex. 4 Scrieti o clasa ce transforma un String intr-un array de caractere.

            /*string text = "etc";
            char[] arr ;
            arr = new char[3];
            arr[0] = text[0];
            arr[1] = text[1];
            arr[2] = text[2];
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }
            Console.Read();*/

            //ex. 5	Transformati un sir de caractere astfel: fiecare litera de pe pozitie para sa fie uppercase
            /*string text = "asaceva";
            Console.WriteLine(text.ToUpper());
            Console.Read();*/
        }

    }
}

