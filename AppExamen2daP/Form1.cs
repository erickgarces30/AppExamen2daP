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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int limite = 0;
            limite = int.Parse(this.txtIngreso.Text);
            int suma = Clases.Examen.sumatoria(limite);
            this.txtSuma.Text = suma.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
