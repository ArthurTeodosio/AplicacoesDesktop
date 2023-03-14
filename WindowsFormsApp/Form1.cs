using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ValorIR_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalarioLiquido_Click(object sender, EventArgs e)
        {

        }

        private void ValorIR_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();

            func.CPF = CPF.Text;
            func.Nome = Nome.Text;
            func.DiasTrabalhados = int.Parse(txtDias.Text);
            func.ValorDiaria = double.Parse(txtDiaria.Text);

            func.CalcularSalarioBase();
            func.CalcularIR();
            func.CalcularSalarioLiquido();

            txtSalBase.Text = func.SalarioBase.ToString();
            txtValorIR.Text = func.ValorIR.ToString();
            txtSalLiquido.Text = func.SalarioLiquido.ToString();
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SalarioLiquido_Click_1(object sender, EventArgs e)
        {

        }
    }
}
