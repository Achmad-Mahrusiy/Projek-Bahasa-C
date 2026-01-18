using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double num3 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("--- Calculator ---");
                Console.WriteLine("------------------");

                Console.Write("Masukkan angka pertama: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan angka kedua: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan angka ketiga: ");
                num3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Masukkan Opsi: ");
                Console.WriteLine("\t1. + : tambah");
                Console.WriteLine("\t2. - : kurang"); 
                Console.WriteLine("\t3. * : kali");
                Console.WriteLine("\t4.  / : bagi");
                Console.Write("Masukkan opsi: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        result = num1 + num2 + num3;
                        Console.WriteLine($"Hasilnya : {num1} + {num2} + {num3} = " + result);
                        break;
                    case "2":
                        result = num1 - num2 - num3;
                        Console.WriteLine($"Hasilnya : {num1} - {num2} - {num3} = " + result);
                        break;
                    case "3":
                        result = num1 * num2 * num3;
                        Console.WriteLine($"Hasilnya : {num1} * {num2} * {num3}= " + result);
                        break;
                    case "4":
                        result = num1 / num2 / num3;
                        Console.WriteLine($"Hasilnya : {num1} / {num2} / {num3}= " + result);
                        break;
                    default:
                        Console.WriteLine("Opsi tidak valid");
                        break;
                }
                Console.WriteLine("apakah kamu mau melanjutkannya? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
