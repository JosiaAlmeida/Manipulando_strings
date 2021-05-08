using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNumber.TextChanged += TextChanged;
            
        }

        private void TextChanged(object sender, EventArgs e)
        {
            string numero = txtNumber.Text;
            if(numero.Length>11)
            {
                MessageBox.Show("Numero Invalido");
            }
            else
            {
                if (numero.StartsWith("92") && txtNumber.Text.Length > 2)
                {
                    txtOperadora.Text = "Unitel";
                }
                else if (numero.StartsWith("91") && txtNumber.Text.Length > 2)
                {
                    txtOperadora.Text = "Movicel";
                }
                else if (numero.StartsWith("22") && txtNumber.Text.Length > 2)
                {
                    txtOperadora.Text = "Rede Fixa";
                }
                else txtOperadora.Text = " ";
            }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
