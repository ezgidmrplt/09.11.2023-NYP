using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._11._2023_NYP
{
    internal class isci:Personel
    {
        string tur;
        public string Tur 
        { 

            get { return tur; }
            set { tur = value; } 
        }

        public int ucretHesapla2()
        {
            return this.Mesai * 100+5000;

            if (this.tur=="Gündelik")
            {
                return this.Mesai * 1000;

            }
        }
    }
}
