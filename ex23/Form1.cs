using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtEntrada.TextChanged += TextChanged;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            txtRestul.Text = txtEntrada.Text.Replace(" ", "");
        }
    }
}
