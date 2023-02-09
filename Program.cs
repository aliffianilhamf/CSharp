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