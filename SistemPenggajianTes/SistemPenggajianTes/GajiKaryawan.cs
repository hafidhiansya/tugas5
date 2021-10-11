using System;
using System.Collections.Generic;
using System.Text;

namespace SistemPenggajianTes
{
    public class GajiKaryawan : Karyawan
    {
        private decimal gajiMingguan;

        public GajiKaryawan(string namaDepan, string namaBelakang, 
            string noIdentitas, decimal gajiMingguan )
            : base(namaDepan, namaBelakang, noIdentitas)
        {
            GajiMingguan = gajiMingguan;
        }

        public decimal GajiMingguan
        {
            get
            {
                return gajiMingguan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException (nameof(value),
                        value, $"{nameof(GajiMingguan)} harus >= 0");
                }
                gajiMingguan = value;
            }
        }
        public override decimal Pendapatan() => GajiMingguan;
        public override string ToString() =>
            $"Penggajian Karyawan   : {base.ToString()}\n" +
            $"Gaji Mingguan         : {GajiMingguan:C}";
    }
}
