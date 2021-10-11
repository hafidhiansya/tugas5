using System;
using System.Collections.Generic;
using System.Text;

namespace KomisiKaryawanTes
{
    public class KomisiKaryawan : object
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NoJaminanSosial { get; }
        private decimal penjualanKotor;
        private decimal presentaseKomisi;

        public KomisiKaryawan (string namaDepan, string namaBelakang,
            string noJaminanSosial, decimal penjualanKotor,
            decimal presentaseKomisi)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NoJaminanSosial = noJaminanSosial;
            PenjualanKotor = penjualanKotor;
            PresentaseKomisi = presentaseKomisi;
        }

        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(PenjualanKotor)} harus >= 0");
                }
                penjualanKotor = value;
            }
        }
        public decimal PresentaseKomisi
        {
            get
            {
                return presentaseKomisi;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(PresentaseKomisi)} harus > 0 dan < 1");
                }
                presentaseKomisi = value;
            }
        }

        public decimal Pendapatan() => presentaseKomisi * penjualanKotor;

        public override string ToString() =>
            $"Komisi Karyawan       : {NamaDepan} {NamaBelakang}\n" +
            $"Nomor Jaminan Sosial  : {NoJaminanSosial}\n" +
            $"Penjualan Kotor       : {penjualanKotor:C}\n" +
            $"Tingkat Komisi        : {presentaseKomisi:F2}";
        
    }
}
