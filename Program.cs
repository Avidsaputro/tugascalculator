using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int  bill1, bill2;
            int pilihan;
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");

            Console.WriteLine("masukkan kode operasi");
            pilihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            if (pilihan == 1)
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                bill1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                bill2 = Convert.ToInt32 (Console.ReadLine()); ;
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah : " + Penambahan (bill1, bill2) + "			");
                Console.WriteLine(" ========================================");
            }
            else if (pilihan == 2)
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                bill1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                bill2 = Convert.ToInt32(Console.ReadLine()); ;
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah : " + pengurangan(bill1, bill2) + "			");
                Console.WriteLine(" ========================================");
            }
            else if (pilihan == 3)
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                bill1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                bill2 = Convert.ToInt32(Console.ReadLine()); ;
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah : " + perkalian  (bill1, bill2) + "			");
                Console.WriteLine(" ========================================");
            }
            else if (pilihan == 4)
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                bill1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                bill2 = Convert.ToInt32(Console.ReadLine()); ;
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah : " + pembagian (bill1, bill2) + "			");
                Console.WriteLine(" ========================================");
            }
            Console.WriteLine("\n");
            Console.WriteLine(" ========================================");
            Console.WriteLine("        | see you |		");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" ");
            Console.ReadLine();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b )
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
