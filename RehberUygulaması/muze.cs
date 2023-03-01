using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Net.Mime.MediaTypeNames.Image;

namespace RehberUygulaması
{
    public partial class muze : Form
    {
        public muze()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Topkapı Sarayı, İstanbul Sarayburnu'nda, Osmanlı İmparatorluğu'nun 600 yıllık tarihinin 400 yılı boyunca, devletin idare merkezi olarak kullanılan ve Osmanlı padişahlarının yaşadığı saraydır. Bir zamanlar içinde 4.000'e yakın insan yaşamıştır.";
            pictureBox1.Visible = true;
            pictureBox2.Visible = false; 
            pictureBox3.Visible = false;
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "İstanbul Arkeoloji Müzesi, çeşitli kültürlere ait bir milyonu aşkın eserle, dünyanın en büyük müzeleri arasındadır. Türkiye'nin müze olarak inşa edilen en eski binasıdır.";
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Masumiyet Müzesi, Orhan Pamuk'un aynı adlı eserinden yola çıkarak oluşturduğu müzedir. İstanbul'da 19. yüzyıldan kalma bir ev yazar tarafından müzeye dönüştürüldü. Müze, bir romanın kurmaca evreninden yola çıkılarak oluşturulan ilk müzedir. 17 Mayıs 2014'te Avrupa Yılın Müzesi Ödülü'nü aldı.";
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
        }

        private void muze_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
    }
}
