using System;

namespace Sistem_RentalKendaraan_048
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sebelum ada constructor
            // Kendaraan mobil = new Kendaraan
            // {
            //     merk = "Honda Jazz",
            //     jenis = "Mobil",
            //     tahun = 2020
            // };

            // Kendaraan motor = new Kendaraan
            // {
            //     merk = "Vario",
            //     jenis = "Motor",
            //     tahun = 2019
            // };

            Kendaraan mobil = new Kendaraan("Honda Jazz", "Mobil", 2020);
            Kendaraan motor = new Kendaraan("Vario", "Motor", 2019);

            mobil.TampilkanInfo();
            motor.TampilkanInfo();
        }
    }
}   