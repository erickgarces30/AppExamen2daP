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
    public partial class frmSerieFactorial : Form
    {
        public frmSerieFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int limite = 0;
            double suma=0;
            limite = int.Parse(this.txtLimite.Text);
            suma = Clases.Examen.sumaFactorial(limite);
            this.txtSuma.Text = suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
