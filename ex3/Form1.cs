using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
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
            lbResult.Text = txtTexto.Text.Replace("janeiro", "01")
                .Replace("fevereiro", "02").Replace("março", "03")
                .Replace("abril", "04").Replace("maio", "05")
                .Replace("junho", "06").Replace("julho", "07")
                .Replace("agosto", "08").Replace("setembro", "09")
                .Replace("outubro", "10").Replace("novembro", "12")
                .Replace("dezembro", "12").ToUpper();
        }
    }
}
