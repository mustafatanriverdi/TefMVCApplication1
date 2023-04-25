namespace TefMVCApplication1.Models
{
    public class TefClass
    {
        public int deger;

        public void hesapla(Int32 sayi1, Int32 sayi2)
        {
            deger= sayi1 + sayi2;
        }
        public int topla(Int32 sayi1, Int32 sayi2)
        {
            return sayi1 + sayi2;
        }

        public int topla(Int32 sayi1, Int32 sayi2,int sayi3)
        {
            return sayi1 + sayi2+sayi3;
        }
    }
}
