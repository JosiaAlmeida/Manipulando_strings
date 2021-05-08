using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextChanged(object sender, EventArgs e)
        {
        }

        private void btnOcorrencia_Click(object sender, EventArgs e)
        {

            string palavra = txtPalavra.Text.Trim();
            lbresult.Text = txtTexto.Text
                .IndexOf(palavra).ToString();
        }
    }
}
