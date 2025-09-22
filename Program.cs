using System;

namespace Sistem_RentalKendaraan_048
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================================
            // Class & Object + Constructor
            // ================================
            Kendaraan kendaraan1 = new Kendaraan("Honda Jazz", "Mobil", 2020);
            Mobil mobil1 = new Mobil("Toyota", 2023, 4);
            Motor motor1 = new Motor("Vario", 2022, true);

            // ================================
            // Encapsulation & Data Hiding
            // ================================
            kendaraan1.Merk = "Suzuki"; // valid, pakai property
            // kendaraan1._merk = "Suzuki"; // tidak bisa diakses langsung karena private

            // ================================
            // Inheritance + Overriding
            // ================================
            Console.WriteLine("== Info Kendaraan ==");
            kendaraan1.TampilkanInfo();

            Console.WriteLine("\n== Info Mobil ==");
            mobil1.TampilkanInfo();  // Override method

            Console.WriteLine("\n== Info Motor ==");
            motor1.TampilkanInfo();  // Override method

            // ================================
            // Polymorphism - Overloading
            // ================================
            Console.WriteLine("\n== Info Mobil Tambahan (Overloading) ==");
            mobil1.TampilkanInfo("Sewa Mingguan");  // Overloading dengan string
            mobil1.TampilkanInfo(true);              // Overloading dengan bool (ringkas)

            Console.WriteLine("\n== Info Motor Tambahan (Overloading) ==");
            motor1.TampilkanInfo("Sewa Harian");
            motor1.TampilkanInfo(true);

            // ================================
            // Composition
            // ================================
            Rental rentalMobil = new Rental("Ivan", mobil1);
            Rental rentalMotor = new Rental("Sohee", motor1);

            Console.WriteLine("\n== Rental Mobil ==");
            rentalMobil.TampilkanRentalInfo();

            Console.WriteLine("\n== Rental Motor ==");
            rentalMotor.TampilkanRentalInfo();
        }
    }
}
