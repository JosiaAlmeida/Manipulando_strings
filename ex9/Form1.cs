using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string[] split = txtNome.Text.Split(' ');
            int total = split.Length;
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            for (int i = 0; i < split.Length-1; i++)
            {
                if (i == 0 || i== split.Length-1)
                {
                    lbResult.Text = split[i];
                }
                else
                {
                    lbResult.Text = txtNome.Text
                        .Replace(split[i-1], split[i-1].Substring(0,1) + ".")
                        .Replace(split[i], split[i].Substring(0,1)+".");
                }
            }
            /*if(total == 3)
            {
                var inicioPalavra = txtNome.Text.IndexOf(' ');
                var palavra = txtNome.Text.Substring(inicioPalavra + 1, txtNome.Text.IndexOf(' ', inicioPalavra + 1) - inicioPalavra - 1);
                if (txtNome.Text.Contains(palavra))
                {
                    lbResult.Text = txtNome.Text.Replace(palavra, palavra.Substring(0, 1));
                }
            }
            if (total == 4)
            {
                var inicioPalavra = txtNome.Text.IndexOf(' ');
                var palavra = txtNome.Text.Substring(inicioPalavra + (total/2), txtNome.Text.IndexOf(' ', inicioPalavra + (total / 2)) - inicioPalavra - (total / 2));
                if (txtNome.Text.Contains(palavra))
                {
                    lbResult.Text = txtNome.Text.Replace(palavra, palavra.Substring(0, 1));
                }
            }*/
        }
    }
}
