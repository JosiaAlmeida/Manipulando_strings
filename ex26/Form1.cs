using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> ListNameSimplifc = new List<string>();
            string[] text = txtNome.Text.Split(' ');
            foreach (var item in text)
            {
                ListNameSimplifc.Add(item.Substring(0, 1));
            }
            string join = String.Join(",", ListNameSimplifc)
                .Replace(",", " ");
            txtSaida.Text = join;
        }
    }
}
