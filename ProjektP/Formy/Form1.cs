using ProjektP.Modele;
using ProjektP.Serwis;
using ProjektP.Mapy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektP;
using ProjektP.Formy;

namespace ProjektP.Serwis
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = @"Server = DESKTOP-QCKQLBB\SQLEXPRESS;Database = dobra_bula; User Id = Michal; Password = 1234";
        private AccSerwis globalAccSerwis = new AccSerwis();
        private AccModel userLogged = null;


        public Form1()
        {
            InitializeComponent();
            NHSerwis.Init(connectionString);
        }

     

        //private void buttonZaloguj_Click(object sender, EventArgs e)
        //{
        //    var login = textBoxLogin.Text.ToString();
        //    var pass = textBoxHaslo.Text.ToString();
        //    userLogged = globalAccSerwis.GetLogin(login, pass);

        //    if (userLogged == null)
        //    {
        //        MessageBox.Show("Podano złe wartości do logowania!\r\nSpróbuj ponownie!");
        //        ClearBadPassword();
        //    }

        //    if (userLogged != null)
        //    {
        //        MessageBox.Show("Zalogowano pomyślnie!");
        //        Form2 form2 = new Form2(userLogged);
        //        form2.ShowDialog();
        //        ClearTextBoxes();

        //    }

        //    textBoxLogin.Text = "login";
        //    textBoxHaslo.Text = "hasło";
           
        //}

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHaslo_TextChanged(object sender, EventArgs e)
        {

        }
        private void textPassEnter(object sender, EventArgs e)
        {
            if (textBoxHaslo.Text.Equals("hasło"))
            {
                textBoxHaslo.Text = "";
            }
        }
        private void textPassLeave(object sender, EventArgs e)
        {
            if (textBoxHaslo.Text.Equals(""))
            {
                textBoxHaslo.Text = "hasło";
            }
        }

        void ClearBadPassword()
        {
            if (textBoxHaslo != null)
            {
                string empty = string.Empty;
                textBoxHaslo.Text = empty;
                textBoxLogin.Text = empty;
            }
        }
        void ClearTextBoxes()
        {
            if (textBoxLogin != null && textBoxHaslo != null)
            {
                string empty2 = string.Empty;
                textBoxLogin.Text = empty2;
                textBoxHaslo.Text = empty2;
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonZaloguj.PerformClick();
            }
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonZaloguj.PerformClick();
            }
        }

        private void buttonZaloguj_Click_1(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text.ToString();
            var pass = textBoxHaslo.Text.ToString();
            userLogged = globalAccSerwis.GetLogin(login, pass);

            if (userLogged == null)
            {
                MessageBox.Show("Podano złe wartości do logowania!\r\nSpróbuj ponownie!");
                ClearBadPassword();
            }

            if (userLogged != null && userLogged.admin == false)
            {
                MessageBox.Show("Zalogowano pomyślnie!");
                Form2 form2 = new Form2();
                form2.ShowDialog();
                ClearTextBoxes();

            }
            else if(userLogged!=null && userLogged.admin == true )
            {
                MessageBox.Show("Zalogowano pomyślnie!");
                Form6 form6 = new Form6();
                form6.ShowDialog();
                ClearTextBoxes();
            }

            textBoxLogin.Text = "login";
            textBoxHaslo.Text = "hasło";

        }

       
    }
    }


