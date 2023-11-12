using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _09._11._2023_NYP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel(adTxt.Text, adresTxt.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt.Text), cmbbox1.Text);

            if (cmbbox1.Text == "İşçi")
            {
                MessageBox.Show(pers.ucretHesapla().ToString());

            }
            else
            {
                pers.ucretHesapla(1000);
            }
            cmbbox1.Items.Add("İşçi");

            cmbbox1.Items.Add("Mühendis");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            muhendis muh=new muhendis();
            muh.Ad = adTxt2.Text;
            muh.Adres = adresTxt2.Text;
            muh.Unvan = cmbbox2.Text;
            muh.birim = cmbboxmuh.Text;
            muh.Yas = Convert.ToInt32(yasTxt2.Text);
            muh.Mesai=Convert.ToInt32(mesaiTxt2.Text);
            MessageBox.Show(muh.ucretHesapla().ToString());
            MessageBox.Show("Ad=" + muh.Ad +
             "\nAdres=" + muh.Adres +
             "\nYaş=" + muh.Yas
             );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isci iscim=new isci();  
            iscim.Ad= adTxt3.Text;
            iscim.Adres= adresTxt3.Text;
            iscim.Unvan= cmbbox3.Text;
            iscim.Tur= cmbboxisci.Text;
            iscim.Yas= Convert.ToInt32(yasTxt3.Text);
            iscim.Mesai=Convert.ToInt32(mesaiTxt3.Text);
            MessageBox.Show(iscim.ucretHesapla2().ToString());

        }


        /*  Personel prs1 = new Personel();    //personel classından bir nesne oluşturmak için yani yapıcı method
          prs1.Ad = adTxt.Text;                       
          prs1.Adres = adresTxt.Text;
          prs1.Yas = Convert.ToInt32(yasTxt.Text);
        */


        /*  MessageBox.Show("Ad=" + prs1.Ad +
              "\nAdres=" + prs1.Adres +
              "\nYaş=" + prs1.Yas
              );
        */
    }
}










