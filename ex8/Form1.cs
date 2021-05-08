using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTexto.TextChanged += TextChanged;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = txtTexto.Text
                .Replace("Teclado", "Teclado ou mouse")
                .Replace("teclado", "teclado ou mouse")
                .Replace("TECLADO", "TECLADO OU MOUSE");
        }
    }
}
