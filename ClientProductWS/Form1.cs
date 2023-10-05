using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientProductWS.ProductWSConsumer;
using ClientProductWS.MusteriWSConsumer;

namespace ClientProductWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductWSSoapClient proxy = new ProductWSSoapClient();
            string msg = proxy.HelloWorld();
            MessageBox.Show(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductWSSoapClient urungetir = new ProductWSSoapClient();//Server Kısımında yeni metot oluşturduğumuzdan Client kısımından Connected kısmından güncellememiz lazım.
            dataGridView1.DataSource = urungetir.urunGetir();//Bağlantıyı config kısımından Generic List olarak ayarlamamız daha hızlı listeletirir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerWSSoapClient musterigetir = new CustomerWSSoapClient();
            dataGridView1.DataSource = musterigetir.MusteriGetir();
        }
    }
}
