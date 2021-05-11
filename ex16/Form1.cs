using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<string> listChar = new List<string>();
            string text = txtNome.Text;
            char[] caracter = text.ToArray();
            int cont = caracter.Length;
            lvResult.MultiSelect = true;

            //lbResult.BeginUpdate();
           /* string join = String.Join(",", caracter);
            string joinCaracter = join.Replace(",", " ");
            lvResult.Items.Add(joinCaracter);*/
            for (int i = 0; i < cont; i++)
            {
                lvResult.Items.Add(caracter[i].ToString());
            }
        }
    }
}
