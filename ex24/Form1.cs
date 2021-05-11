using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string[] texto = txtEntrada.Text.Split(' ');
            Array.Reverse(texto);
            string join = String.Join(",", texto).Replace(",", " ");
            txtSaida.Text = join;
        }
    }
}
