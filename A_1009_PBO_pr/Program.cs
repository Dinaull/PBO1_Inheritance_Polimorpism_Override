using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Simbaassad", 5, 4);
        Gajah gajah = new Gajah("Trunk", 10, 4);
        Ular ular = new Ular("Orochimaru", 7, 20.2);
        Buaya buaya = new Buaya("Wally Gator", 10, 7.5);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine("Penerapan Polimorphism:");
        singa.Mengaum();
        ular.Merayap();

        Console.WriteLine();
        Reptil reptil = new Buaya("Wally Gator", 10, 7.5);
        reptil.Suara();

        Console.ReadKey();
    }
}

public class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string _Nama, int _Umur)
    {
        this.Nama = _Nama;
        this.Umur = _Umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara.";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

public class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string _Nama, int _Umur, int _JumlahKaki) : base(_Nama, _Umur)
    {
        this.JumlahKaki = _JumlahKaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

public class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string _Nama, int _Umur, double _PanjangTubuh) : base(_Nama, _Umur)
    {
        this.PanjangTubuh = _PanjangTubuh;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}

public class Singa : Mamalia
{
    public Singa(string _Nama, int _Umur, int _JumlahKaki) : base(_Nama, _Umur, _JumlahKaki)
    {
    }

    public override string Suara()
    {
    return $"{Nama} mengaum Roar!";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} sedang mengaum keras!");
    }
}

public class Gajah : Mamalia
{
    public Gajah(string _Nama, int _Umur, int _JumlahKaki) : base(_Nama, _Umur, _JumlahKaki)
    {
    }

    public override string Suara()
    {
        return $"{Nama} menggeru bruuuah!";
    }
}

public class Ular : Reptil
{
    public Ular(string _Nama, int _Umur, double _PanjangTubuh) : base(_Nama, _Umur, _PanjangTubuh)
    {
    }

    public override string Suara()
    {
        return $"{Nama} mendesis siissss!";
    }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap pelan-pelan.");
    }
}

public class Buaya : Reptil
{
    public Buaya(string _Nama, int _Umur, double _PanjangTubuh) : base(_Nama, _Umur, _PanjangTubuh)
    {
    }

    public override string Suara()
    {
        return $"{Nama} bersuara Grrrrr!";
    }
}

public class KebunBinatang
{
    public List<Hewan> KoleksiHewan;

    public KebunBinatang()
    {
        KoleksiHewan = new List<Hewan>();
    }

    public void TambahHewan(Hewan hewan)
    {
        KoleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        if (KoleksiHewan.Count == 0)
        {
            Console.WriteLine("Tidak ada hewan di kebun binatang.");
        }
        else
        {
            Console.WriteLine("Daftar Hewan di Kebun Binatang:");
            for (int i = 0; i < KoleksiHewan.Count; i++)
            {
                Console.WriteLine(KoleksiHewan[i].InfoHewan());
                Console.WriteLine(KoleksiHewan[i].Suara());
                Console.WriteLine();
            }
        }
    }
}

