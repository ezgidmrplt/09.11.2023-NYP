using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09._11._2023_NYP
{
    internal class Personel
    {
        public Personel(string gAd, string gAdres, int gYas, int gMesai, string gUnvan)
        {
            this.ad = gAd;
            this.adres = gAdres;
            this.yas = gYas;
            this.mesai = gMesai;
            this.unvan = gUnvan;



        }





        string ad;
        public string Ad
        {
            get => ad;
            set => ad = value;

        }
        string adres;
        public string Adres
        {
            get => adres;
            set => adres = value;

        }
        string unvan;
        public string Unvan
        {
            get => adres;
            set { adres = value; }

        }
        public Personel() { }

        int yas;
        public int Yas
        {
            get => yas;
            set => yas = value;




        }
        int mesai;
        public int Mesai
        {
            get { return mesai; }
            set => mesai = value;
        }

        public virtual int ucretHesapla()
        {
            return this.Mesai * 100;
        }
        public void ucretHesapla(int ekUcret)  //değer döndürmeyeceksen void kullanırız
        {
            MessageBox.Show((this.Mesai * 100 + ekUcret).ToString());

        }


    }
}

