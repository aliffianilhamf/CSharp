// See https://aka.ms/new-console-template for more information

/*
//CONSTRUCTOR OVERLOADING
class Mobil
{
    public string merk;
    public string warna;
    public int thnPembuatan;

    // constructor pertama
    public Mobil()
    {
        merk = "Hino";
        warna = "Hitam";
        thnPembuatan = 2018;
    }

    //constructor kedua
    public Mobil(string merk, string warna, int thnPembuatan)
    {
        this.merk = merk;
        this.warna = warna;
        this.thnPembuatan = thnPembuatan;
    }
}
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Objek pertama");
        Mobil toyota = new Mobil("Toyota", "Putih", 2020);
        Console.WriteLine(toyota.merk);
        Console.WriteLine(toyota.warna);
        Console.WriteLine(toyota.thnPembuatan);

        Console.WriteLine("Objek kedua");
        Mobil hino = new Mobil();
        Console.WriteLine(hino.merk);
        Console.WriteLine(hino.warna);
        Console.WriteLine(hino.thnPembuatan);



        Console.ReadLine();


    }
}
*/
/*
//CONSTRUCTOR CHAINING
class Mobil
{
    public string merk;
    public string hrgJual;

    public Mobil() : this("Sedan")
    {

    }
    public Mobil(string merk) : this(merk, "200.000.000")
    {

    }
    public Mobil(string merk, string hrgJual)
    {
        this.merk = merk;
        this.hrgJual = hrgJual;
    }
}
class Program
{
    static void Main(string[] args)
    {
        //objek pertama hanya untuk  MERK SEDAN DENGAN HARGA 200.000.000
        Mobil mobilSatu = new Mobil();
        Console.WriteLine("Merk Mobil Satu = {0}", mobilSatu.merk);
        Console.WriteLine("Harga Jual Mobil Satu = {0}\n", mobilSatu.hrgJual);

        //objek kedua dengan MERK YANG BERVARIASI DAN HANYA UNTUK HARGA 200.000.000
        Mobil mobilDua = new Mobil("Hino");
        Console.WriteLine("Merk Mobil Dua = {0}", mobilDua.merk);
        Console.WriteLine("Harga Jual Mobil Dua = {0}\n", mobilDua.hrgJual);

        //objek untuk kedua mobil YANG MEMILIKI MERK DAN HARGA YANG BERVARIASI 
        Mobil mobilTiga = new Mobil("Honda", "300.000.000");
        Console.WriteLine("Merk Mobil Tiga = {0}", mobilTiga.merk);
        Console.WriteLine("Harga Jual Mobil Tiga = {0}", mobilTiga.hrgJual);






    }
}
*/
/*
//UTILITY CLASS
class KonversiSuhu
{
    public static double celciusKeFahrenheit(string suhuCelcius)
    {
        //konversi(parse) ke bentuk double
        double celcius = double.Parse(suhuCelcius);

        //masukkan rumus
        double fahrenheit = (celcius * 9 / 5) + 32;

        //return
        return fahrenheit;

    }

    public static double fahrenheitKeCelcius(string suhuFahrenheit)
    {
        double fahrenheit = double.Parse(suhuFahrenheit);

        double celcius = (fahrenheit - 32) * 5 / 9;

        return celcius;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAM KONVERSI SUHU");
        Console.WriteLine("Pilih 1 Untuk konversi dari celcius ke fahrenheit");
        Console.WriteLine("Pilih 2 Untuk konversi dari celcius ke fahrenheit");
        Console.Write("Masukkan Pilihan Anda : ");

        string pilihan = Console.ReadLine();
        double c, f;

        switch (pilihan)
        {
            case "1":
                Console.Write("Masukkan Angka : ");
                f = KonversiSuhu.celciusKeFahrenheit(Console.ReadLine());
                Console.WriteLine("Hasilnya Adalah : {0:F2}", f);


                break;
            case "2":
                Console.Write("Masukkan Angka : ");
                c = KonversiSuhu.fahrenheitKeCelcius(Console.ReadLine());
                Console.WriteLine("Hasilnya Adalah : {0:F2}", c);

                break;
            default:
                Console.WriteLine("Silahkan Pilih 1 atau 2!");

                break;

        }
        Console.WriteLine("Tekan enter untuk keluar!");
        Console.ReadLine();





    }
}
*/
/*
//STATIC CLASS
// Sebuah non static class , Bukan karakteristik ataupun perilaku object dari class tersebut
// Melainkan perilaku atau kharakteristik dari class itu sendiri.

// non-static class
class Mobil
{
    // anggota penyusun class yang dideklarasikan sebagai static
    // static field
    private static int JmlObjMobil = 0;
    // constructor
    public Mobil()
    {
        JmlObjMobil++;
    }
    // anggota penyusun class yang dideklarasikan sebagai static
    // static method
    public static void TotalObjMobil()
    {
        Console.WriteLine("Ada {0} mobil", JmlObjMobil);
    }
}
class Program
{
    static void Main(string[] args)
    {

        Mobil.TotalObjMobil();
        Mobil sedan = new Mobil();
        Mobil.TotalObjMobil();
        Mobil pickup = new Mobil();
        Mobil.TotalObjMobil();
        Console.ReadLine();
    }
}
*/
/*
class Mobil
{
    private int JmlObjMobil = 0;
    public Mobil()
    {
        JmlObjMobil++;
    }
    public void TotalObjMobil()
    {
        Console.WriteLine("Ada {0} mobil", JmlObjMobil);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Method non-static tidak bisa dipanggil dengan cara ini
        // Mobil.TotalObjMobil();
        Mobil sedan = new Mobil();
        // Mobil.TotalObjMobil();
        // method TotalObjMobil() yang terkait dengan objek sedan
        sedan.TotalObjMobil();
        Mobil pickup = new Mobil();
        // Mobil.TotalObjMobil();
        // method TotalObjMobil() yang terkait dengan objek pickup
        pickup.TotalObjMobil();
        Console.ReadLine();
    }
}
// Mengapa keluarannya berbeda dengan kode program sebelumnya?
//Karena kini field JmlObjMobil merupakan non-static field, maka field tersebut akan menjadi 
//terkait dengan masing-masing objek yang dibuat dari class Mobil.
*/

/*
//STATIC CONSTRUCTOR
class Mobil
{
    public string pabrikan;
    public string tipe;
    public int thnPembuatan;
    public static int kecepatanMax;
    // static constructor
    static Mobil()
    {
        kecepatanMax = 200; //km per jam
        Console.WriteLine("Kecepatan maximum pada speedometer adalah {0}", kecepatanMax);
    }
    // Parameterized Constructor
    public Mobil(string pabrikan, string tipe, int thnPembuatan)
    {
        this.pabrikan = pabrikan;
        this.tipe = tipe;
        this.thnPembuatan = thnPembuatan;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // objek mobilToyota
        Console.WriteLine("--- objek mobilToyota1 ---");
        Mobil mobilToyota = new Mobil("Toyota", "Hatchback", 2019);
        Console.WriteLine(mobilToyota.pabrikan);
        Console.WriteLine(mobilToyota.tipe);
        Console.WriteLine(mobilToyota.thnPembuatan);
        // objek mobilMazda
        Console.WriteLine("--- objek mobilToyota1 ---");
        Mobil mobilMazda = new Mobil("Mazda", "SUV", 2019);
        Console.WriteLine(mobilMazda.pabrikan);
        Console.WriteLine(mobilMazda.tipe);
        Console.WriteLine(mobilMazda.thnPembuatan);
        Console.WriteLine("\nTekan Enter untuk keluar..");
        Console.ReadLine();
    }
}
*/
/*
//PEWARISAN
class KendaraanBermotor
{
    public int JmlRoda { get; set; }
    public string BahanBakar { get; set; }
    public string NoPolisi { get; set; }
    public string Transmisi { get; set; }
    public void HidupkanMesin()
    {
        Console.WriteLine("Mesin Kendaraan dihidupkan");
    }
    public void MatikanMesin()
    {
        Console.WriteLine("Mesin Kendaraan dimatikan");
    }
    public void Jalan()
    {
        Console.WriteLine("Berjalan");
    }
}
class Mobil : KendaraanBermotor
{
    public Mobil()
    {
        this.JmlRoda = 4;
        this.BahanBakar = "Pertalite";
        this.Transmisi = "Otomatis";
    }
}
class Motor : KendaraanBermotor
{
    public Motor()
    {
        this.JmlRoda = 2;
        this.BahanBakar = "Premium";
        this.Transmisi = "Otomatis";
    }
}
class Program
{
    static void Main(string[] args)
    {
        // instantiasi objek mobil
        Mobil mobil = new Mobil();
        mobil.NoPolisi = "AB 1234 CD";
        Console.WriteLine("Objek Mobil:");
        Console.WriteLine("Jumlah roda: {0}", mobil.JmlRoda);
        Console.WriteLine("Bahan bakar: {0}", mobil.BahanBakar);
        Console.WriteLine("Nomor polisi: {0}", mobil.NoPolisi);
        Console.WriteLine("Transmisi: {0}", mobil.Transmisi);
        mobil.HidupkanMesin();
        mobil.Jalan();
        mobil.MatikanMesin();
        // instantiasi objek motor
        Motor motor = new Motor();
        motor.NoPolisi = "AB 5678 CD";
        Console.WriteLine("\nObjek Motor:");
        Console.WriteLine("Jumlah roda: {0}", motor.JmlRoda);
        Console.WriteLine("Bahan bakar: {0}", motor.BahanBakar);
        Console.WriteLine("Nomor Polisi: {0}", motor.NoPolisi);
        Console.WriteLine("Transmisi: {0}", motor.Transmisi);
        motor.HidupkanMesin();
        motor.Jalan();
        motor.MatikanMesin();
        Console.ReadLine();
    }
}
//Perhatikan bahwa dengan membuat objek mobil dari class Mobil dan objek motor dari class Motor, 
//kita bahkan bisa mengakses seluruh properti dan method dari class KendaraanBermotor melalui kedua
//objek tersebut. Ini dimungkinkan karena class Mobil yang menjadi blueprint dari objek mobil dan
//class Motor yang menjadi blueprint dari objek motor mewarisi seluruh karakteristik dan perilaku
//dari class KendaraanBermotor
*/

/*
//METHOD HIDING
abstract class KendaraanBermotor
{
    public void Jalan()
    {
        Console.WriteLine("Berjalan maju");
    }
}
class Mobil : KendaraanBermotor
{
    public new void Jalan()
    {
        Console.WriteLine("Menjalankan sebuah mobil:");
        Console.WriteLine("1.Memindah tuas transmisi dari N ke D");
        Console.WriteLine("2.Injak pedal gas");
    }
}
class Motor : KendaraanBermotor
{
    public new void Jalan()
    {
        Console.WriteLine("Menjalankan sebuah motor:");
        Console.WriteLine("1.Putar handle gas");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Mobil mobil = new Mobil();
        Motor motor = new Motor();
        mobil.Jalan();
        Console.WriteLine("");
        motor.Jalan();
        Console.ReadLine();
    }
}
*/
/*
//METHOD OVERIDING
//Abstract Method
abstract class KendaraanBermotor
{
    public abstract void Jalan();
}
class Mobil : KendaraanBermotor
{
    public override void Jalan()
    {
        Console.WriteLine("Menjalankan sebuah mobil:");
        Console.WriteLine("1.Memindah tuas transmisi dari N ke D");
        Console.WriteLine("2.Injak pedal gas");
    }
}
class Motor : KendaraanBermotor
{
    public override void Jalan()
    {
        Console.WriteLine("Menjalankan sebuah motor:");
        Console.WriteLine("1.Putar handle gas");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Mobil mobil = new Mobil();
        Motor motor = new Motor();

        mobil.Jalan();
        Console.WriteLine("");
        motor.Jalan();
        Console.ReadLine();
    }
}

//Virtual Method
abstract class KendaraanBermotor
{
    public virtual void Jalan()
    {
        Console.WriteLine("Berjalan maju");
    }
}
class Mobil : KendaraanBermotor
{
    public override void Jalan()
    {
        Console.WriteLine("Menjalankan sebuah mobil:");
        Console.WriteLine("1.Memindah tuas transmisi dari N ke D");
        Console.WriteLine("2.Injak pedal gas");
    }
}
class Motor : KendaraanBermotor
{
    public override void Jalan()
    {
        Console.WriteLine("Menjalankan sebuah motor:");
        Console.WriteLine("1.Putar handle gas");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Mobil mobil = new Mobil();
        Motor motor = new Motor();
        mobil.Jalan();
        Console.WriteLine("");
        motor.Jalan();
        Console.ReadLine();
    }
}
*/