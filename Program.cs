//using System;
BankaHesabi hesap = new BankaHesabi(23443306, "Arda Atik", 1000.00);

hesap.ParaYatir(500.00);

Console.WriteLine("Para yatırıldı. Yeni Bakiye  " + hesap.Bakiye+" TL"); // 1500.00

hesap.ParaCek(250.00);

Console.WriteLine("Para Çekildi. Yeni Bakiye  " + hesap.Bakiye+" TL"); // 1250.00
public class BankaHesabi
{

    private int hesapNumarasi;
    private string hesapSahibiAdi;
    public double bakiye;

    public BankaHesabi(int hesapNumarasi, string hesapSahibiAdi, double bakiye)
    {
        this.hesapNumarasi = hesapNumarasi;
        this.hesapSahibiAdi = hesapSahibiAdi;
        this.bakiye = bakiye;
    }

    public int HesapNumarasi
    {
        get { return hesapNumarasi; }
    }

    public string HesapSahibiAdi
    {
        get { return hesapSahibiAdi; }
    }

    public double Bakiye
    {
        get { return bakiye; }
    }

    public void ParaYatir(double miktar)
    {
        if (miktar > 0)
        {
            bakiye += miktar;
        }
    }

    public void ParaCek(double miktar)
    {
        if (miktar > 0 && bakiye >= miktar)
        {
            bakiye -= miktar;
        }
    }

}
