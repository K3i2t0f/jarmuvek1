using System.Collections.Concurrent;

namespace BuszOOP
{
    public class Busz
    {
        private string szin;
        private int evjarat;
        private string hajtas;
        private int szekek;

        public Busz(string szin, int evjarat, string hajtas, int szekek){
            this.szin = szin;
            this.evjarat = evjarat;
            this.hajtas = hajtas;
            this.szekek = szekek;
        }

        public Busz(string szin, int szekek)
        {
            this.szin = szin;
            this.evjarat = 0;
            this.hajtas = "Gázolaj";
            this.szekek = szekek;
        }

        public string Szin{get => szin;}
        public int Evjarat{get => evjarat; set => evjarat = value;}
        public string Hajtas{get => hajtas;}
        public int Szekek{get => szekek; set => szekek = value;}


        public int Kor{
            get => DateTime.Now.Year- this.evjarat;
        }

        public string Allapot{
            get{
                if(this.Kor < 10){
                    return "Uj";
                }else if(this.Kor < 20){
                    return "Kozepkoru";
                }else{
                    return "Oreg";
                }
            }
        }

        public override string ToString()
        {
            return $"{this.szin}, evjarat: {this.evjarat}, hajtas: {this.hajtas}, szekek szama: {this.szekek}";
        }
    }
}