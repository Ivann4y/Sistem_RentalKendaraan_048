namespace Sistem_RentalKendaraan_048
{
    class Rental
    {
        public string NamaPenyewa { get; set; }
        public Kendaraan KendaraanDisewa { get; set; }  // <-- Composition

        public Rental(string namaPenyewa, Kendaraan kendaraan)
        {
            NamaPenyewa = namaPenyewa;
            KendaraanDisewa = kendaraan;
        }

        public void TampilkanRentalInfo()
        {
            Console.WriteLine($"Penyewa: {NamaPenyewa}");
            Console.WriteLine("Kendaraan yang disewa:");
            KendaraanDisewa.TampilkanInfo(); 
        }
    }
}
