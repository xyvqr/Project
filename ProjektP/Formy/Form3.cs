using ProjektP.Formy;
using ProjektP.Modele;
using ProjektP.Serwis;
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
    public partial class Form3 : Form
    {
        AccModel globalAccModel = new AccModel();

        public Form3()
        {
            InitializeComponent();
        }

    
      

        private void buttonPlus1_Click_1(object sender, EventArgs e)
        {
            int dodawanie = Convert.ToInt32(textBoxQuantity1.Text);
            dodawanie++;
            textBoxQuantity1.Text = dodawanie.ToString();
            Counting();
        }

        private void buttonMinus1_Click(object sender, EventArgs e)
        {
            int odejmowanie = Convert.ToInt32(textBoxQuantity1.Text);
            odejmowanie--;
            textBoxQuantity1.Text = odejmowanie.ToString();
            if (odejmowanie<0)
            {
                textBoxQuantity1.Text = "0";
            }
            Counting();
        }

        private void buttonOrderEnd_Click(object sender, EventArgs e)
        {
            string total = textBoxTotalPrice.Text;
            bool ZamowienieGotowka = checkBoxCash.Checked;
            bool ZamowienieKarta = checkBoxCreditCard.Checked;
            if (total == "")
            {
                MessageBox.Show("Brak");
            }
            else
            {
                Form5 form5 = new Form5(total, ZamowienieGotowka, ZamowienieKarta);
                form5.ShowDialog();

            }
        }

        private void buttonPlus2_Click(object sender, EventArgs e)
        {
            int dodawanie = Convert.ToInt32(textBoxQuantity2.Text);
            dodawanie++;
            textBoxQuantity2.Text = dodawanie.ToString();
            Counting();
        }

        private void buttonMinus2_Click(object sender, EventArgs e)
        {
            int odejmowanie = Convert.ToInt32(textBoxQuantity2.Text);
            odejmowanie--;
            textBoxQuantity2.Text = odejmowanie.ToString();
            if (odejmowanie < 0)
            {
                textBoxQuantity2.Text = "0";
            }
            Counting();

        }

        private void buttonPlus3_Click(object sender, EventArgs e)
        {
            int dodawanie = Convert.ToInt32(textBoxQuantity3.Text);
            dodawanie++;
            textBoxQuantity3.Text = dodawanie.ToString();
            Counting();
        }

        private void buttonMinus3_Click(object sender, EventArgs e)
        {
            int odejmowanie = Convert.ToInt32(textBoxQuantity3.Text);
            odejmowanie--;
            textBoxQuantity2.Text = odejmowanie.ToString();
            if (odejmowanie < 0)
            {
                textBoxQuantity3.Text = "0";
            }
           Counting();

        }

        private void buttonPlus4_Click(object sender, EventArgs e)
        {
            int dodawanie = Convert.ToInt32(textBoxQuantity4.Text);
            dodawanie++;
            textBoxQuantity4.Text = dodawanie.ToString();
            Counting();
        }

        private void buttonMinus4_Click(object sender, EventArgs e)
        {
            int odejmowanie = Convert.ToInt32(textBoxQuantity4.Text);
            odejmowanie--;
            textBoxQuantity4.Text = odejmowanie.ToString();
            if (odejmowanie < 0)
            {
                textBoxQuantity4.Text = "0";
            }
            Counting();
        }

        private void buttonPlus5_Click(object sender, EventArgs e)
        {
            int dodawanie = Convert.ToInt32(textBoxQuantity5.Text);
            dodawanie++;
            textBoxQuantity5.Text = dodawanie.ToString();
            Counting();
        }

        private void buttonMinus5_Click(object sender, EventArgs e)
        {
            int odejmowanie = Convert.ToInt32(textBoxQuantity5.Text);
            odejmowanie--;
            textBoxQuantity5.Text = odejmowanie.ToString();
            if (odejmowanie < 0)
            {
                textBoxQuantity5.Text = "0";
            }
           Counting();
        }

        private void buttonPlus6_Click(object sender, EventArgs e)
        {
            int dodawanie = Convert.ToInt32(textBoxQuantity6.Text);
            dodawanie++;
            textBoxQuantity6.Text = dodawanie.ToString();
            Counting();
        }

        private void buttonMinus6_Click(object sender, EventArgs e)
        {
            int odejmowanie = Convert.ToInt32(textBoxQuantity6.Text);
            odejmowanie--;
            textBoxQuantity6.Text = odejmowanie.ToString();
            if (odejmowanie < 0)
            {
                textBoxQuantity6.Text = "0";
            }
            Counting();
        }

        private void buttonPlus7_Click(object sender, EventArgs e)
        {
            int dodawanie = Convert.ToInt32(textBoxQuantity7.Text);
            dodawanie++;
            textBoxQuantity7.Text = dodawanie.ToString();
            Counting();
        }

        private void buttonMinus7_Click(object sender, EventArgs e)
        {
            int odejmowanie = Convert.ToInt32(textBoxQuantity7.Text);
            odejmowanie--;
            textBoxQuantity7.Text = odejmowanie.ToString();
            if (odejmowanie < 0)
            {
                textBoxQuantity7.Text = "0";
            }
            Counting();
        }

        private void Counting()
        {
            MenuSerwis menuSerwis = new MenuSerwis();
            List<MenuModel> menuModelList = menuSerwis.GetAll();
            var text1 = Convert.ToInt32(textBoxQuantity1.Text);
            var text2 = Convert.ToInt32(textBoxQuantity2.Text);
            var text3 = Convert.ToInt32(textBoxQuantity3.Text);
            var text4 = Convert.ToInt32(textBoxQuantity4.Text);
            var text5 = Convert.ToInt32(textBoxQuantity5.Text);
            var text6 = Convert.ToInt32(textBoxQuantity6.Text);
            var text7 = Convert.ToInt32(textBoxQuantity7.Text);
            int mMListCount = menuModelList.Count;
            for (int i = 0; i < menuModelList.Count; i++)
            {
                var a = Convert.ToInt32(menuModelList[0].price) * text1;
                var b = Convert.ToInt32(menuModelList[1].price) * text2;
                var c = Convert.ToInt32(menuModelList[2].price) * text3;
                var d = Convert.ToInt32(menuModelList[3].price) * text4;
                var e = Convert.ToInt32(menuModelList[4].price) * text5;
                var f = Convert.ToInt32(menuModelList[5].price) * text6;
                var g = Convert.ToInt32(menuModelList[6].price) * text7;

                textBoxTotalPrice.Text = (a + b + c + d + e + f + g).ToString();
            }


        }

        private void textBoxQuantity1_Click(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity2_Click(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity3_Click(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity4_Click(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity5_Click(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity6_Click(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity7_Click(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxQuantity3.Text) == 3)
            {
                this.textBoxTotalPrice.TextChanged -= new System.EventHandler(this.textBoxTotalPrice_TextChanged);
                textBoxTotalPrice.Text = (Convert.ToDouble(textBoxTotalPrice.Text) * (0.8)).ToString();
                this.textBoxTotalPrice.TextChanged += new System.EventHandler(this.textBoxTotalPrice_TextChanged);
            }
        }
    }
}
