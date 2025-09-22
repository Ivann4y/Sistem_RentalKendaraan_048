namespace Sistem_RentalKendaraan_048
{
    class Motor : Kendaraan
    {
        public bool Electric { get; set; }

        public Motor(string merk, int tahun, bool electric)
            : base(merk, "Motor", tahun)
        {
            Electric = electric;
        }
        
        public override void TampilkanInfo()
        {
            base.TampilkanInfo();
            Console.WriteLine($"Jumlah Bahan Bakar: {(Electric ? "Listrik" : "Bensin")}");
        }
    }
}