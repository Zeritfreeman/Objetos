using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string texto1 = "perra";
                string texto2 = "perra";
                DateTime hoy = DateTime.Today;
                float nrof = 0.0f;
                double nrod = 0.0d;
                int nroi = 0, caradado = 1;
                string nrotxt = "105";
                bool condicion = true;
                char caracter = 'C';
                short corto;
                
                if (Char.IsDigit(caracter)) Console.WriteLine("Es digito");
                else if (Char.IsLetter(caracter)) Console.WriteLine("Es letra");
                else if (Char.IsLetter(caracter)) Console.WriteLine("Es minúscula");
                else if (Char.IsLetter(caracter)) Console.WriteLine("Es mayúscula");
                else Console.WriteLine("No es digito, ni es letra");

                nroi = (int)caracter;
                corto = (short)caracter;

                nrof = (float)nrod;
                nroi = (int)nrof;

                nroi = Int32.Parse(nrotxt) + 10;
                texto1 = nroi.ToString();

                if (condicion) Console.WriteLine("Es verdad");
                else Console.WriteLine("Es falso");

                if (!condicion) Console.WriteLine("Es verdad");
                else Console.WriteLine("Es falso");

                if (condicion) Console.WriteLine(1);
                else if (!condicion) Console.WriteLine(2);
                else Console.WriteLine(3);

                switch (caradado)
                {
                    case 1: Console.WriteLine("Uno");
                        break;

                    case 2:
                        Console.WriteLine("Dos");
                        break;
                    case 3:
                        Console.WriteLine("Tres");
                        break;
                    case 4:
                        Console.WriteLine("Cuatro");
                        break;
                    case 5:
                        Console.WriteLine("Cinco");
                        break;
                    case 6:
                        Console.WriteLine("Seis");
                        break;
                    default:
                        Console.WriteLine("Cuatro");
                        break;
                }

                Console.WriteLine(hoy);
                Console.WriteLine(hoy.ToString("d"));
                Console.WriteLine(hoy.ToString("D"));
                Console.WriteLine(hoy.ToString("g"));
                if (texto1.Equals(texto2))
                {
                    Console.WriteLine("iguales");
                }
                else Console.WriteLine("diferentes");

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }

                nroi = 5;
                while (nroi >= 0)
                {
                    Console.WriteLine(nroi);
                    nroi--;
                }

                do
                    Console.WriteLine(nroi);
                while (nroi >= 0);

                var fibnumeros = new List<int> { 0, 1, 1, 2, 3, 5, 8, 11 };

                nroi = 0;

                foreach (int i in fibnumeros)
                {
                    Console.WriteLine(i);
                }

                fibnumeros.Add(19);

                int[] puntuacion = new int[] { 96, 95, 92, 88 };
                string[] vectortxt = new string[100];
                string[] dias = { "lun", "mar", "mie", "jue", "vie", "sab", "dom" };

                for (int i = 0; i < dias.Length; i++)
                {
                    Console.WriteLine(dias[i]);
                }

                foreach (string i in dias)
                {
                    Console.WriteLine(i);
                }

                int[,] matriz1 = new int[5, 5];

                int[,] matriz2 = new int[,] { { 4, 5 }, { 0, 6 }, { 8, 7 } };

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine(matriz2[i, j]);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                Console.ReadKey();
            }
            
        }
        
    }
}
