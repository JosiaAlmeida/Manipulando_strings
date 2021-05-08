using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5
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
            string vogais = txtTexto.Text;
            lbresult.Text = vogais.Replace("a", "#")
                .Replace("e", "#").Replace("o", "#")
                .Replace("i", "#").Replace("u", "#")
                .Replace("A", "#").Replace("O", "#")
                .Replace("E", "#").Replace("U", "#")
                .Replace("I", "#");
        }
    }
}
