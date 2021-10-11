using System;
using System.Collections.Generic;
using System.Text;

namespace SistemPenggajianTes
{
    public class DasarKomisiKaryawan : KomisiKaryawan
    {
        private decimal dasarGaji;

        public DasarKomisiKaryawan (string namaDepan, string namaBelakang,
            string noIdentitas, decimal bruto,
            decimal presentaseKomisi, decimal dasarGaji)
            : base(namaDepan, namaBelakang, noIdentitas,
                  bruto, presentaseKomisi)
        {
            DasarGaji = dasarGaji;
        }

        public decimal DasarGaji
        {
            get
            {
                return dasarGaji;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(DasarGaji)} harus >= 0");
                }
                dasarGaji = value;
            }
        }
        public override decimal Pendapatan() => DasarGaji + base.Pendapatan();
        public override string ToString() =>
            $"Gaji-Pokok {base.ToString()}\nGaji Pokok      : {DasarGaji:C}";
    }
}
