using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCalculoDesconto : Form
    {
        public frmCalculoDesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Transformando o preço do produto e o desconto em dicimal.
            decimal precoOriginal = Convert.ToDecimal(txtPrecoProduto.Text);
            decimal porcentagemDesconto = Convert.ToDecimal(txtDesconto.Text);

            // Calculando o desconto.
            decimal valorDesconto = (porcentagemDesconto / 100) * precoOriginal;

            // Calculando o preço final do produto com desconto.
            decimal precoComDesconto = precoOriginal - valorDesconto;

            // Transformando o preço final em string e mostrando no label.
            lblPrecoFinal.Text = "R$ " + precoComDesconto.ToString("F2");
        }
    }
}
