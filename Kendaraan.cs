namespace Sistem_RentalKendaraan_048
{
    class Kendaraan
    {
        public string? merk { get; set; }
        public string jenis { get; set; } = string.Empty;
        public int tahun { get; set; }

        // Constructor
        public Kendaraan(string merk, string jenis, int tahun)
        {
            this.merk = merk;
            this.jenis = jenis;
            this.tahun = tahun;
        }
        
        public void TampilkanInfo()
        {
            Console.WriteLine($"Merk: {merk}, Jenis: {jenis}, Tahun: {tahun}");
        }
    }
}