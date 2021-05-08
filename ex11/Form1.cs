using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            List<string> text = new List<string>();
            string[] split = txtEntrada.Text.Split(' ');
            string[] split2 = txtEntrada2.Text.Split(' ');

            if (split.Length > split2.Length)
            {
                for (int i = 0; i < split.Length; i++)
                {
                    text.Add(split[i]);
                    if (i < split2.Length)
                    {
                        text.Add(split2[i]);
                    }
                }
            }
            else if(split.Length == split2.Length)
            {
                for (int i = 0; i < split.Length; i++)
                {
                    text.Add(split[i]);
                    text.Add(split2[i]);
                }
            }
            else
            {
                for (int i = 0; i < split2.Length; i++)
                {
                    if (i < split.Length)
                    {
                        text.Add(split[i]);
                    }
                    text.Add(split2[i]);
                }
            }
            string join = String.Join(",", text);
            txtSaida.Text = join.Replace(","," ");
        }
    }
}
