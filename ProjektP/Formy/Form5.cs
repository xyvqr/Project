using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektP.Formy
{
    public partial class Form5 : Form
    {
        private readonly Random _random = new Random();
        public Form5(string total, bool Karta, bool Gotowka)
        {

            InitializeComponent();
           
            if (Karta == true)
            {
                
                label7.Text = "Płatność gotowka";
            }

            
            if (Gotowka == true)

            {
                
                label7.Text = "Płatność kartą";
            }
            label5.Text = total;

            label6.Text = RandomNumber(1000, 9999).ToString();
        }
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
