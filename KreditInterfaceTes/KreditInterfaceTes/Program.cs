using System;
using System.Collections.Generic;

namespace KreditInterfaceTes
{
    class Program
    {
        static void Main()
        {
            var objekYangHarusDibayar = new List<IKredit>() {
                new Tagihan("01234", "Kursi", 2, 375.00M),
                new Tagihan("56789", "Ban", 4, 79.95M),
                new GajiKaryawan("Budi", "Rehan", "111-11-1111", 800.00M),
                new GajiKaryawan("Lisa", "Blekping", "888-88-8888", 1200.00M)};

            Console.WriteLine("Tagihan dan Karyawan diproses dengan polimorfisme:\n");
             foreach (var kredit in objekYangHarusDibayar)
            {
                Console.WriteLine($"{kredit}");
                Console.WriteLine(
                    $"Jatuh Tempo     : {kredit.MengambilJumlahPembayaran():C}\n");
            }
            Console.ReadLine();

        }
    }
}
