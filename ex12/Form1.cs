using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] split = txtFrase.Text.Split(' ');
            Array.Sort(split);
            string join = String.Join(" ", split);
            txtResult.Multiline = true;
            txtResult.Text = join;
        }
    }
}
