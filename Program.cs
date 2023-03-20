using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        public static void Calculator() {
            Console.Title = "Aplikasi Calculator";  // Judul pada Console

            Console.WriteLine("Pilih Menu Calculator");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            int a;
            int b;

            Console.Write("\nInput Nomor Menu: ");
            int pilihan = Convert.ToInt32(Console.ReadLine());      // Input data ke variable "pilihan" dari user
                                                                    // Convert.ToInt32() Berfungsi untuk mengubah nilai string ke int

            switch(pilihan)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n--- PENAMBAHAN --- ");
                    Console.WriteLine("\nA + B");
                    Console.WriteLine("\nMasukan Nilai A: ");
                    a = Convert.ToInt32(Console.ReadLine());    // Input data ke variable A dari user
                    Console.WriteLine("\nMasukan Nilai B: ");
                    b = Convert.ToInt32(Console.ReadLine());    // Input data ke variable B dari user
                    Console.Write("\nHasil Penambahan " + a + " + " + b + " = " + (a + b));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("\n--- PENGURANGAN --- ");
                    Console.WriteLine("\nA - B");
                    Console.WriteLine("\nMasukan Nilai A: ");
                    a = Convert.ToInt32(Console.ReadLine());    // Input data ke variable A dari user
                    Console.WriteLine("\nMasukan Nilai B: ");
                    b = Convert.ToInt32(Console.ReadLine());    // Input data ke variable B dari user
                    Console.Write("\nHasil Pengurangan {0} - {1} = {2}", a, b, (a - b));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\n--- PERKALIAN --- ");
                    Console.WriteLine("\nA x B");
                    Console.WriteLine("\nMasukan Nilai A: ");
                    a = Convert.ToInt32(Console.ReadLine());    // Input data ke variable A dari user
                    Console.WriteLine("\nMasukan Nilai B: ");
                    b = Convert.ToInt32(Console.ReadLine());    // Input data ke variable B dari user
                    Console.Write("\nHasil Perkalian {0} x {1} = {2}", a, b, (a * b));
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\n--- PEMBAGIAN --- ");
                    Console.WriteLine("\nA / B");
                    Console.WriteLine("\nMasukan Nilai A: ");
                    a = Convert.ToInt32(Console.ReadLine());    // Input data ke variable A dari user
                    Console.WriteLine("\nMasukan Nilai B: ");
                    b = Convert.ToInt32(Console.ReadLine());    // Input data ke variable B dari user
                    Console.Write("\nHasil Pembagian {0} / {1} = {2}", a, b, (a / b));
                    break;
                default:
                // Ketika user menginputkan nilai yang tidak sesuai dengan nomor yang ditampilkan maka akan menampilkan hasil dari blok kode dibawah ini
                    Console.WriteLine("Masukan Pilihan Yang Benar!");
                    break;
            }

            Console.WriteLine("\nTekan Sembarang Untuk Keluar");
            Console.ReadKey();
        }
    }
};
