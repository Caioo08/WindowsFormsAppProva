using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp231098231024
{
    public partial class Form1 : Form
    {
        double total;
        int cont = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(txtQtd.Text);
            double valor = int.Parse(txtVl.Text);
            dgvProdutos.Rows.Add(txtProduto.Text, txtQtd.Text, txtVl.Text);
            txtProduto.Text = "";
            txtQtd.Text = "";
            txtVl.Text = "";
            txtProduto.Focus();
            MessageBox.Show("Produto incluído", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            total += quant * valor;
            lblTotal.Text = total.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
                
                MessageBox.Show("Produto excluído", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                txtAlterar.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dgvProdutos.SelectedCells[0].Value = txtAlterar.Text;
            MessageBox.Show("Aluno alterado", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                dgvProdutos.Rows.Clear();
                lblTotal.Text = "";
                cont++;
                lblVenda.Text = cont.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                dgvProdutos.Rows.Clear();
                lblTotal.Text = "";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
