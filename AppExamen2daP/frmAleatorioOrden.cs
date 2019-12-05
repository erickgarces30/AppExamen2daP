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
    public partial class frmAleatorioOrden : Form
    {
        public frmAleatorioOrden()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(this.txtTamanio.Text);
            int[] vector = Clases.Vector.generar(tamanio);

            lstLista.Items.Clear();
            for (int i = 0; i < tamanio; i++)
            {
                lstLista.Items.Add(vector[i].ToString());
            }
            Clases.Vector.ordenar(vector, tamanio);
            lstOrden.Items.Clear();
            for (int i = 0; i < tamanio; i++)
            {
                lstOrden.Items.Add(vector[i].ToString());
            }

        }
    }
}
