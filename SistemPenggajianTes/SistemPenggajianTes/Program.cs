using System;
using System.Collections.Generic;

namespace SistemPenggajianTes
{
    class Program
    {
        static void Main()
        {
            var gajiKaryawan = new GajiKaryawan("Budi", "Doremi",
                "111-11-1111", 800.00M);
            var karyawanPerJam = new KaryawanPerJam("Surti", "Asmina",
                "222-22-2222", 16.75M, 40.0M);
            var komisiKaryawan = new KomisiKaryawan("Danu", "Darto",
                "333-33-3333", 10000.00M, .06M);
            var dasarKomisiKaryawan = new DasarKomisiKaryawan("Damar", "Rehanda",
                "444-44-4444", 5000.00M, .05M, 300.00M);

            Console.WriteLine("Karyawan diporses secara individual:\n");

            Console.WriteLine($"{gajiKaryawan}\nMendapatkan     :" +
                $"{gajiKaryawan.Pendapatan():C}\n");
            Console.WriteLine($"{karyawanPerJam}\nMendapatkan     :" +
                $"{karyawanPerJam.Pendapatan():C}\n");
            Console.WriteLine($"{komisiKaryawan}\nMendapatkan     :" +
                $"{komisiKaryawan.Pendapatan():C}\n");
            Console.WriteLine($"{dasarKomisiKaryawan}\nMendapatkan     :" +
                $"{dasarKomisiKaryawan.Pendapatan():C}\n");

            var karyawans = new List<Karyawan>() { gajiKaryawan,
            karyawanPerJam, komisiKaryawan, dasarKomisiKaryawan };

            Console.WriteLine("Karyawan diproses secara polimorfisme");

            foreach (var karyawanSaatIni in karyawans )
            {
                Console.WriteLine(karyawanSaatIni);

                if (karyawanSaatIni is DasarKomisiKaryawan)
                {
                    var karyawan = (DasarKomisiKaryawan)karyawanSaatIni;

                    karyawan.DasarGaji *= 1.10M;
                    Console.WriteLine("Dasar gahji dengan kenaikan 10%  : " +
                        $"{karyawan.DasarGaji:C}");
                }
                Console.WriteLine($"Mendapatkan     : {karyawanSaatIni.Pendapatan():C}\n");
            }
            for (int j = 0; j < karyawans.Count; j++)
            {
                Console.WriteLine($"Karyawan {j} adalah {karyawans[j].GetType()}");
            }
            Console.ReadLine();
        }
    }
}
