using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExamen2daP
{
    public partial class Form1 : Form
    {
        //
        private long esPrimo(int n)
        {
            int num = 0, cont=0;
            for(int a=2;a<=n;a++)
            {
                bool primo = true;
                int b = 2;
                    while(primo==true && b<=(a/2))
                {
                    if(a%b==0)
                    {
                        primo = false;
                    }
                    b++;
                }
                if (primo == true)
                {
                    cont = 1 + cont;
                    num = num + a;
                }
            }
            return num;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(this.txtIngreso.Text);
            long primo = esPrimo(n);
            this.txtSuma.Text = primo.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
