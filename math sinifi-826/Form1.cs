using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sinifi_826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToSingle(txtSayi.Text);

            //işlemler 
            double sayiMutlak = Math.Abs(sayi);
            double sayiUs = Math.Pow(sayi, 2); // txt içindeki sayının karesi(2.kuvveti)
            double sayiKarekok = Math.Sqrt(sayi);
            double sayiYukariYuvarla = Math.Ceiling(sayi);
            //Round,Floor,Ceil
            double asagiyuvarlama = Math.Floor(sayi);
            double yuvarlama = Math.Round(sayi);


            //sonuçları yazdır
            lblMutlak.Text = "sayısnın mutlak değeri:" + sayiMutlak.ToString();
            lblUst.Text = "sayısının kuvveti :" + sayiUs.ToString();
            lblKok.Text = "sayısnın kare kökü:" + sayiKarekok.ToString();
            lblYukari.Text = "sayısnı yukarı yuvarla:" + sayiYukariYuvarla.ToString();
            lblAsagi.Text = "sayısnın aşağı yuvarla:" + sayi.ToString();
            lblYuvarlama.Text = "sayı yuvarla :" + sayi.ToString();


                


        }
    }
}
