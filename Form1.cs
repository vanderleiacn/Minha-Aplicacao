using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int tipoProd = 0;

            Calculo c = new Calculo(); //chama nesse bloco e tem acesso ao metodo é la q ta feito o calculo

            int precoInicio = Convert.ToInt32(txtPreco.Text);
                       
            if (rdSuco.Checked)
                tipoProd = 1;
            else if (rdTv.Checked)
                tipoProd = 2;
            else if (rdBatom.Checked)
                tipoProd = 3;

            MessageBox.Show("O preço final é: " + c.MostrarPreco(precoInicio, tipoProd));// metodo sendo chamado e passando parametro
        }
    }
}
