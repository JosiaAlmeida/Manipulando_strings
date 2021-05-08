using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTexto.TextChanged+=TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextChanged(object sender, EventArgs e)
        {
            int vog = 0;
            int consoante = 0;
            string v = txtTexto.Text.Trim();
            for(int i=0; i < v.Length; i++)
            {
                if(v[i]=='a'||v[i]=='e' || v[i] == 'i'
                    || v[i] == 'o' || v[i] == 'u')
                {
                    vog++;
                }
                else
                {
                   consoante++;
                    lbCont.Text = consoante.ToString();
                }
            }
        }
    }
}
