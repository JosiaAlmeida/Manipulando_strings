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
            string[] split = txtNome.Text.Split(' ');
            string join;
            char containChar='a';
            List<string> listChar = new List<string>();
            List<string> listString = new List<string>();
            string[] split2 = new string[split.Length];
            string[] Arrayy = new string[25];
            for (int i = 0; i < split.Length; i++)
            {
                listChar.Add(split[i].Substring(i, i + 1));
            }
            RtbResult.Text = String.Join(",", listChar).Replace(",", " ");
        }
    }
}
