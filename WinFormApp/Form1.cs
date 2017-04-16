using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.House house = new ServiceReference1.House();
            house.Name = "汤臣一品";
            ServiceReference1.Service1Client client=new ServiceReference1.Service1Client();
            var newHouse = client.GetHouseName(house);
            MessageBox.Show(newHouse.Name);
        }
    }
}
