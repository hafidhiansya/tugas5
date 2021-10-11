using System;
using System.Collections.Generic;
using System.Text;

namespace KreditInterfaceTes
{
    public class Tagihan : IKredit
    {
        public string BagianNomor { get; }
        public string BagianDeskripsi { get; }
        private int jumlah;
        private decimal hargaPerItem;

        public Tagihan(string bagianNomor, string bagianDeskripsi,
            int jumlah, decimal hargaPerItem)
        {
            BagianNomor = bagianNomor;
            BagianDeskripsi = bagianDeskripsi;
            Jumlah = jumlah;
            HargaPerItem = hargaPerItem;
        }

        public int Jumlah
        {
            get
            {
                return jumlah;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Jumlah)} harus >= 0");
                }
                jumlah = value;
            }
        }
        public decimal HargaPerItem
        {
            get
            {
                return hargaPerItem;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(HargaPerItem)} harus >= 0");
                }
                hargaPerItem = value;
            }
        }
        public override string ToString() =>
            $"Tagihan:\nBagian nomor    : {BagianNomor} ({BagianDeskripsi})\n" +
            $"Jumlah          : {Jumlah}\nHarga per Item  : {HargaPerItem:C}";

        public decimal MengambilJumlahPembayaran() => Jumlah * HargaPerItem;
    }
}
