using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ex13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            IList<string> listChar = new List<string>();
            List<string> listString = new List<string>();
            List<string> listRepit = new List<string>();
            List<int> Cont = new List<int>();
            string texto = txtEntrada.Text;
            char[] caracter = texto.ToArray();
            int Count=1;
            foreach (var item in caracter)
            {
                if(texto.Where(x=> x.Equals(item)).Count() > 1)
                {
                    string text = item + " Repetiu " + texto.Where(x => x.Equals(item)).Count();
                    listChar.Add(text);
                }
            }
            var union = listChar.Union(listChar);
            ltbResult.DataSource = union.ToList();
            ltbRepit.DataSource = listRepit;
        }
    }
}
