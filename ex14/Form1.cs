using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtEntrada.TextChanged += TextChanged;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int space = 0;
            int deleteSpace = 0;
            for (int i = 0; i < txtEntrada.Text.Length; i++)
            {
                if (txtEntrada.Text.Contains(i.ToString()))
                {

                }
                else
                {
                    cont++;
                    deleteSpace = cont - space;
                    lbCont.Text = deleteSpace.ToString();
                }
            }
        }

        private void TextChanged(object sender, EventArgs e)
        {
        }
    }
}
