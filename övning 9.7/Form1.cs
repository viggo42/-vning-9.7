using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            string tabell = "";
            int tabellvärde = int.Parse(tbxNivå.Text); 
            for (int i = 1; i <= tabellvärde; i++)
            {
                //den loopar tillden har gångat till 10
                int peng = 1;
                for (peng = 1; peng <= 10; peng++)    
                {
                    tabell += (i * peng) + "\t";
                }
                tabell += "\r\n";
            }
            tbxUtdata.AppendText(tabell);
        }

        private void tbxNivå_TextChanged(object sender, EventArgs e)
        {
            tbxUtdata.Text = string.Empty;
        }
    }
}