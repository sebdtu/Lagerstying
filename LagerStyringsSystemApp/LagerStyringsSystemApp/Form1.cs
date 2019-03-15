using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LagerStyringsSystemApp.ServiceReference1;

namespace LagerStyringsSystemApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lagervare lagervare = new Lagervare();
            lagervare.Id = Convert.ToInt32(txtId.Text);
            lagervare.name = txtNavn.Text;
            lagervare.price = Convert.ToInt32(txtPris.Text);
            lagervare.quantity = Convert.ToInt32(txtQuantity.Text);

            Service1Client service = new Service1Client();

            if (service.InsertVare(lagervare)==1){
                MessageBox.Show("Varer insert succesfull");
            }
        }
    }
}
