using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIspis.Text = CmbIzbor.SelectedItem.ToString();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();
            CmbIzbor.SelectedIndex = 0;
        }

        private void btnPoruka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poruka", "Naslov");
        }
    }
}
