using System;
using System.Collections.Generic;
using System.Text;

namespace SistemPenggajianTes
{
    public class KomisiKaryawan : Karyawan
    {
        private decimal bruto;
        private decimal presentaseKomisi;

        public KomisiKaryawan(string namaDepan, string namaBelakang,
            string noIdentitas, decimal bruto,
            decimal presentaseKomisi)
            : base (namaDepan, namaBelakang, noIdentitas)
        {
            Bruto = bruto;
            PresentaseKomisi = presentaseKomisi;
        }

        public decimal Bruto
        {
            get
            {
                return bruto;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Bruto)} harus >= 0");
                }

                bruto = value;
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
        public override decimal Pendapatan() => PresentaseKomisi * Bruto;
        public override string ToString() =>
            $"Komisi karyawan   : {base.ToString()}\n" +
            $"Bruto             : {Bruto:C}\n" +
            $"Presentase Komisi : {PresentaseKomisi:F2}";
    }
}
