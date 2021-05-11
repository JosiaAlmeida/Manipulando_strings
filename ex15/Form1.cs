using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            txtSaida.Text = ToUpperCase(txtEntrada.Text);
        }
        private string ToUpperCase(string txt)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt.ToLower());
        }
    }
}
