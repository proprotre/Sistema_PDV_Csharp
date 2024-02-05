using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }
        private void limparCampos()
        {

            txtNome.Text = "";
            txtValorVenda.Text = "";
            txtQuantidade.Text = "";
            lbSelecionado.Text = "";
        }
        private bool verificarCampos()
        {

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtValorVenda.Text, out decimal valorVenda) || valorVenda < 0)
            {
                MessageBox.Show("Por favor, insira um valor de venda válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade < 0)
            {
                MessageBox.Show("Por favor, insira uma quantidade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                using var db = new SistemaPdv();
                db.Add(new Produto { Nome = txtNome.Text, ValorVenda = Convert.ToDecimal(txtValorVenda.Text), Quantidade = Convert.ToInt32(txtQuantidade.Text) });
                db.SaveChanges();
                MessageBox.Show("Produto inserido com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                produtoBindingSource.DataSource = db.Produtos.ToList();
                limparCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                using (var db = new SistemaPdv())
                {
                    var produtoSelecionado = produtoBindingSource.Current as Produto;

                    if (produtoSelecionado != null)
                    {
                        produtoSelecionado.Nome = txtNome.Text;
                        produtoSelecionado.ValorVenda = Convert.ToDecimal(txtValorVenda.Text);
                        produtoSelecionado.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                        db.Entry(produtoSelecionado).State = EntityState.Modified;

                        db.SaveChanges();

                        MessageBox.Show($"Produto {produtoSelecionado.Nome} atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        produtoBindingSource.DataSource = db.Produtos.ToList();
                        limparCampos();
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                var produto = produtoBindingSource.Current as Produto;

                if (produto != null)
                {
                    using (var db = new SistemaPdv())
                    {
                        db.Entry(produto).State = EntityState.Deleted;
                        db.SaveChanges();

                        MessageBox.Show($"Produto {produto.Nome} excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        produtoBindingSource.DataSource = db.Produtos.ToList();
                        limparCampos();
                    }
                }
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limparCampos();
            MessageBox.Show($"Campos limpos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {
            using (var db = new SistemaPdv())
            {
                produtoBindingSource.DataSource = db.Produtos.ToList();
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new SistemaPdv())
            {
                var texto = produtoBindingSource.Current as Produto;
                lbSelecionado.Text = $"ID do produto selecionado: {texto.ProdutoId}";
                produtoBindingSource.DataSource = db.Produtos.ToList();
                txtNome.Text = texto.Nome;
                txtValorVenda.Text = texto.ValorVenda.ToString();
                txtQuantidade.Text = texto.Quantidade.ToString();
                produtoBindingSource.DataSource = db.Produtos.ToList();
            }
        }
    }
}
