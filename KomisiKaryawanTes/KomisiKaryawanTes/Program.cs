using System;

namespace KomisiKaryawanTes
{
    class Program
    {
        static void Main()
        {
            var karyawan = new KomisiKaryawan("Dede", "Sunandar",
                "325-346-3456", 10000.00M, .06M);

            Console.WriteLine("Informasi karyawan diperoleh dengan properti dan metode: \n");
            Console.WriteLine($"Nama depan          : { karyawan.NamaDepan}");
            Console.WriteLine($"Nama belakang       : {karyawan.NamaBelakang}");
            Console.WriteLine($"No Jaminan Sosial   : { karyawan.NoJaminanSosial}");
            Console.WriteLine($"Penjualan kotor     : {karyawan.PenjualanKotor:C}");
            Console.WriteLine($"Presentase komisi   : {karyawan.PresentaseKomisi:F2}");
            Console.WriteLine($"Pendapatan          : {karyawan.Pendapatan():C}");

            karyawan.PenjualanKotor = 5000.00M;
            karyawan.PresentaseKomisi = .1M;

            Console.WriteLine("\nInformasi karyawan yang diperbarui diperoleh oleh ToString:\n");
            Console.WriteLine(karyawan);
            Console.WriteLine($"Pendapatan: {karyawan.Pendapatan():C}");

            Console.ReadLine();

        }
    }
}
