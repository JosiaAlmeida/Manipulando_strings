using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int Count=0;
            foreach (var item in caracter)
            {
                if(texto.Where(x=> x.Equals(item)).Count() > 1)
                {
                    listChar.Add(item.ToString());
                }
                Count = texto.Where(x => x.Equals(item)).Count();
                listRepit.Add(Count.ToString());
            }
            var union = listChar.Union(listChar);
            ltbResult.DataSource ="O "+union.ToList()+"Repetiu :" + listRepit;
            cbResult.DataSource = union.ToList();
        }
    }
}
