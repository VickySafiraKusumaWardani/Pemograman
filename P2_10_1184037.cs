using System;
using System.Collections.Generic;
using System.Linq;
namespace Product_1184110
{
    public class P2_2_1184110
    {
        static void Main(string[] args)
        {

        double a, b;
        int pilih;

        Console.WriteLine("1. Penjumlahan");
        Console.WriteLine("2. Pengurangan");            
        Console.WriteLine("3. Perkalian");           
        Console.WriteLine("4. Pembagian");            
        Console.Write("Pilih Proses yang akan dilakukan : ");           
        pilih = int.Parse(Console.ReadLine());

        switch (pilih)
        {
             case 1:
                Console.Write("Masukkan Bilangan Pertama : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan Bilangan Kedua : ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasil Penjumlahan " + (a + b));
                break;
            case 2:
                Console.Write("Masukkan Bilangan Pertama : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan Bilangan Kedua : ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan " + (a - b));
                break;
            case 3:
                Console.Write("Masukkan Bilangan Pertama : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan Bilangan Kedua : ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian " + (a * b));
                break;
            case 4:
                Console.Write("Masukkan Bilangan Pertama : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan Bilangan Kedua : ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian " + (a / b));
                break;
        }

        Console.ReadLine();
    }
}
}