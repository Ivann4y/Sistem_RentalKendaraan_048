namespace Sistem_RentalKendaraan_048
{
    class Mobil : Kendaraan
    {
        public int JumlahPintu { get; set; }

        public Mobil(string merk, int tahun, int jumlahPintu)
            : base(merk, "Mobil", tahun)
        {
            JumlahPintu = jumlahPintu;
        }
        
        public override void TampilkanInfo()
        {
            base.TampilkanInfo();
            Console.WriteLine($"Jumlah Pintu: {JumlahPintu}");
        }
    }
}