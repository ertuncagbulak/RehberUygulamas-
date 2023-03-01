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
    public partial class cami : Form
    {
        public cami()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Ayasofya, eski adıyla Kutsal Bilgelik Kilisesi ve Ayasofya Müzesi veya günümüzdeki resmî adıyla Ayasofya-i Kebîr Câmi-i Şerîfi, İstanbul'da yer alan bir cami ve eski bazilika, katedral ve müzedir.";
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Sultan Ahmet Camii veya Sultânahmed Camiî, 1609-1617 yılları arasında Osmanlı Padişahı I. Ahmed tarafından İstanbul'daki tarihî yarımadada, Mimar Sedefkâr Mehmed Ağa'ya yaptırılmıştır.";
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Süleymaniye Camii, Kanuni Sultan Süleyman adına 1551-1557 yılları arasında İstanbul'da Mimar Sinan tarafından inşa edilen camidir.";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void cami_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
    }
}
