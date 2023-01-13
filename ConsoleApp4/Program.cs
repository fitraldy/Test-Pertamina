using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Deret Fibonaci dengan inputan 10

            int x = 1, y = 0, z = 0;

            Console.Write("Masukan jumlah bilangan fibonacci = ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jumlah + 1; i++)
            {
                Console.Write(z + " ");
                z = x + y;
                x = y;
                y = z;
            }
            Console.Read();


            // perulangan
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                    if (j == 5)
                    {
                        Console.Write(" ");
                        for (int k = 1; k <= 1; k++)
                        {
                            for (int l = 5; l >= 1; l--)
                            {
                                Console.Write(l);
                                if (l == 1)
                                {
                                    Console.Write(" ");
                                }

                            }


                        }

                    }

                }

            }

            //segitiga sama siku

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
