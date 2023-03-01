namespace RehberUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            muze form2= new muze();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cami form3 = new cami();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tarih form4 = new tarih();
            form4.Show();
        }
    }
}