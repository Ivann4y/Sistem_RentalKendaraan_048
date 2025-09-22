namespace Sistem_RentalKendaraan_048
{
    class Kendaraan
    {
        private string _merk = string.Empty;
        private string _jenis = string.Empty;
        private int _tahun;

        public string Merk
        {
            get => _merk;
            set => _merk = string.IsNullOrWhiteSpace(value) ? "Merk tidak boleh kosong!" : value;
        }

        public string Jenis
        {
            get => _jenis;
            set => _jenis = string.IsNullOrWhiteSpace(value) ? "Jenis tidak boleh kosong!" : value;
            // Jika ga ada kondisi 
            // set => _jenis = value;
        }

        public int Tahun
        {
            get => _tahun;
            set => _tahun = value < 2000 ? 0 : value;
        }

        // Constructor
        public Kendaraan(string merk, string jenis, int tahun)
        {
            Merk = merk;
            Jenis = jenis;
            Tahun = tahun;
        }

        // Overriding method
        public virtual void TampilkanInfo()
        {
            if (_tahun == 0)
            {
                Console.WriteLine("Tahun kendaraan minimal 2000!");
            }

            if (Merk == "Merk tidak boleh kosong!" && Jenis == "Jenis tidak boleh kosong!" && Tahun == 0)
            {
                Console.WriteLine("Data kendaraan tidak valid!");
            }

            string merkDisplay = string.IsNullOrWhiteSpace(Merk) ? "NULL" : Merk;
            string jenisDisplay = string.IsNullOrWhiteSpace(Jenis) ? "NULL" : Jenis;
            string tahunDisplay = Tahun < 2000 ? "NULL" : Tahun.ToString();

            Console.WriteLine($"Merk: {merkDisplay}, Jenis: {jenisDisplay}, Tahun: {tahunDisplay}");
        }

        // overloading method (method dengan nama sama, tapi parameter berbeda)
        public void TampilkanInfo(string tambahanInfo)
        {
            // TampilkanInfo();
            Console.WriteLine($"Info Tambahan: {tambahanInfo}");
        }

        public void TampilkanInfo(bool ringkas)
        { 
            if (ringkas)
            {
                Console.WriteLine($"[{Merk} - {Jenis}]");
            }
            else
            {
                TampilkanInfo();
            }
        }
    }
}