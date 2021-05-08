using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            List<string> listAlf = new List<string>();
            char alf = 'A';
            listAlf.Add(alf.ToString());
            for (int i = 0; i < 25; i++)
            {
                alf++;
                listAlf.Add(alf.ToString());
            }
            lbAlfa.Text = String.Join(",", listAlf).Replace(",", " ");
        }
    }
}
