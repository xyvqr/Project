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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AccSerwis accSerwis = new AccSerwis();
            AccModel accModel = new AccModel();
            accModel.accountLogin = textBoxLogin1.Text;
            accModel.accountPassword = TextBoxHaslo1.Text;
            accModel.firstName = TextBoxImie.Text;
            accModel.lastName = TextBoxNazwisko.Text;
            accSerwis.Add(accModel);
            this.Close();
           
            

        }

    }
}
