using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string[] split = txtTexto.Text.Split(' ');
            string[] split2 = txtTexto.Text.Split(' ');
            List<string> list = new List<string>();
            for (int i = 0; i < split.Length; i++)
            {
                list.Add(split[i]);
                list.Add(split2[i]);
            }
            string join;
            join = String.Join(",", list);
            lbResult.Text = join.Replace("," , " ");
        }
    }
}
