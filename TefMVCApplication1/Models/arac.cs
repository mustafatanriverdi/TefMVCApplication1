namespace TefMVCApplication1.Models
{
    public class arac
    {
        public arac()
        {
            
        }
        public arac(string renk, int agirlik, string Ulke)
        {
            Renk = renk;
            Agirlik = agirlik;
            this.Ulke = Ulke;
        }   

        public string Renk { get; set; }
        public int Agirlik { get; set; }

        public string Ulke { get; set; }

        public bool MuayeneVarmı()
        {
            return true;
        }
    }
}
