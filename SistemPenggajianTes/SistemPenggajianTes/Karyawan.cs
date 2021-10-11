using System;
using System.Collections.Generic;
using System.Text;

namespace SistemPenggajianTes
{
    public abstract class Karyawan
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NoIdentitas { get; }
        public Karyawan(string namaDepan, string namaBelakang, string noIdentitas)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NoIdentitas = noIdentitas;
        }
        public override string ToString() => $"{NamaDepan} {NamaBelakang}\n" +
            $"Nomor Identitas   : {NoIdentitas}";

        public abstract decimal Pendapatan();
    }
}
