using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170816_1Win_DXBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int X = 3,Y = 3;

        // formun genişliği ve yüksekliği hesaplanırken çerçeveler dahil edilmektedir. (height,width)
        //Eğer elemanın X değerini formun yüksekliğine göre kıyaslarsak daha farklı bir noktada bulunur.
        //çerçeveler hariç kullanılan alanı almak için CLIENTSIZE özelliğini kullanabiliriz. böylece çerçeveler dahil olmadan hesaplanmış olan yükseklik ve genişlik değerlerini alırız.

            /*
             BU TÜR İŞLEMLER İÇİN WPF KULLANMAK DAHA İYİ BİR SONUÇ ELDE ETMEMİZİ SAĞLAR.
             WPF : GÖRÜNTÜYÜ OLUŞTURMAK İÇİN GPU KULLANIR
             WİNFORM : CPU KULLANIR.
             */
        private void timer1_Tick(object sender, EventArgs e)
        {
            top.Left += X;
            top.Top += Y;

            if (top.Left <= 0 || top.Right >= this.ClientSize.Width)
            {
                X *= -1;
            }

            if (top.Top <= 0 || top.Bottom >= this.ClientSize.Height)
            {
                Y *= -1;
            }
            
        }
    }
}
