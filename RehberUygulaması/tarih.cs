using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehberUygulaması
{
    public partial class tarih : Form
    {
        public tarih()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Galata Kulesi ya da müze olarak kullanılmaya başlaması sonrasındaki adıyla Galata Kulesi Müzesi, İstanbul'un Beyoğlu ilçesinde bulunan bir kuledir. Adını, bulunduğu Galata semtinden alır.";
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Yerebatan Sarnıcı İstanbul'da şehrin su ihtiyacını karşılamak üzere 526-527 senelerinde yaptırılmış kapalı su sarnıcı. Ayasofya'nın güneybatısında, Soğukçeşme Sokağı'ndadır. Suyun içinden yükselen pek çok mermer sütun nedeniyle halk arasında Yerebatan Sarayı olarak isimlendirilmektedir.";
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Kız Kulesi, İstanbul Boğazı'nın Marmara Denizi'ne yakın kısmında, Salacak açıklarında yer alan küçük adacık üzerinde inşa edilmiş yapıdır.";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tarih_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
    }
}
