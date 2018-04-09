using System;
using DatosTelefono;
using System.Drawing;
using System.Windows.Forms;

namespace Telefonia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TelefonoDatos tec = new TelefonoDatos(txtbtel.Text, txtbLugar.Text);
                dgvTelefonia.Rows.Add(tec.telefono, tec.lugar);
            }
        }
    }
}
