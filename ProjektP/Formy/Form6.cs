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
    public partial class Form6 : Form
    {
        AccSerwis accSerwis = new AccSerwis();

        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void zamowienieJedzeniaMapBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            accModelBindingSource.DataSource = accSerwis.GetAll();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
            accModelBindingSource.DataSource = accSerwis.GetAll();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var usun = accModelBindingSource.Current as AccModel;
            accSerwis.UsunPracownika(usun);
            accModelBindingSource.RemoveCurrent();
        }

      
    }
}
