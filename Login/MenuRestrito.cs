using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Login
{
    public partial class MenuRestrito : Form
    {
        decimal valorTotalVenda = 0;
        private void GerarCodigoVenda()
        {
            using var db = new SistemaPdv();

            // Obter o último ID da tabela Vendas
            var ultimoId = db.Vendas.OrderByDescending(v => v.VendaId).FirstOrDefault()?.VendaId ?? 0;

            // Incrementar o último ID em 1 para obter o próximo ID disponível
            var novoId = ultimoId + 1;

            lbCodVenda.Text = novoId.ToString();
        }
        private void ConsultarProduto()
        {
            try
            {
                using var db = new SistemaPdv();
                var produto = db.Produtos.FirstOrDefault(u => u.ProdutoId == Convert.ToInt32(txtCodigo.Text));
                if (produto != null)
                {
                    lbNome.Text = produto.Nome;
                    lbValorUnitario.Text = Convert.ToString(produto.ValorVenda);
                    txtQuantidade.Focus();
                }
                else
                {
                    lbNome.Text = "Produto não encontrado!";
                    txtCodigo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void LimparCampos()
        {
            lbNome.Text = "";
            txtCodigo.Text = "";
            txtQuantidade.Text = "";
            lbValorUnitario.Text = "00,00";
            lbValorTotalProduto.Text = "00,00";
            txtCodigo.Focus();
        }
        private void NomearDgv()
        {
            // Configuração do DataGridView
            dgvListaProdutos.AllowUserToAddRows = false; // Não permitir que o usuário adicione novas linhas
            dgvListaProdutos.AllowUserToDeleteRows = false; // Não permitir que o usuário exclua linhas
            dgvListaProdutos.ReadOnly = true; // Tornar o DataGridView somente leitura
            dgvListaProdutos.EditMode = DataGridViewEditMode.EditProgrammatically; // Não permitir edição ao clicar na célula

            dgvListaProdutos.ColumnCount = 5;
            dgvListaProdutos.Columns[0].Name = "Código";
            dgvListaProdutos.Columns[1].Name = "Descrição";
            dgvListaProdutos.Columns[1].Width = 267;
            dgvListaProdutos.Columns[2].Name = "Valor unitário";
            dgvListaProdutos.Columns[3].Name = "Quantidade";
            dgvListaProdutos.Columns[4].Name = "Total";

            // Desabilitar a ordenação automática das colunas
            foreach (DataGridViewColumn column in dgvListaProdutos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Desabilitar a reordenação de colunas e o redimensionamento
            dgvListaProdutos.AllowUserToOrderColumns = false;
            dgvListaProdutos.AllowUserToResizeColumns = false;

            // Seleção de linhas inteiras
            dgvListaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaProdutos.MultiSelect = false;
        }

        private void GravarVenda()
        {
            Inserir();
            using var db = new SistemaPdv();
            db.Add(new Venda { VendaId = Convert.ToInt32(lbCodVenda.Text), ValorTotal = valorTotalVenda });
            db.SaveChanges();
        }
        private void Inserir()
        {
            try
            {
                using var db = new SistemaPdv();
                for (int i = 0; i < dgvListaProdutos.Rows.Count; i++)
                {
                    db.Add(new ItemVenda { VendaId = Convert.ToInt32(lbCodVenda.Text), ProdutoId = Convert.ToInt32(dgvListaProdutos.Rows[i].Cells[0].Value), Quantidade = Convert.ToInt32(dgvListaProdutos.Rows[i].Cells[3].Value), ValorTotal = Convert.ToDecimal(dgvListaProdutos.Rows[i].Cells[4].Value) });
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public MenuRestrito()
        {
            InitializeComponent();
            GerarCodigoVenda();
            NomearDgv();
            txtCodigo.Focus();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromptToExit();

        }

        private void MenuRestrito_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                PromptToExit();
                e.Cancel = true;
            }
        }
        private void PromptToExit()
        {
            DialogResult dialogo = MessageBox.Show("Quer mesmo sair?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var cadastrarProduto = new CadastrarProduto();
            cadastrarProduto.ShowDialog();
        }
        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                ConsultarProduto();
            }
            else
            {
                txtCodigo.Focus();
            }
        }

        private void txtQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantidade.Text != string.Empty)
            {
                lbValorTotalProduto.Text = (Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(lbValorUnitario.Text)).ToString();
                btnAdicionarProduto.Focus();
            }
            else
            {
                MessageBox.Show("Preencha o campo quantidade!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty && txtQuantidade.Text != string.Empty)
            {
                dgvListaProdutos.Rows.Add(txtCodigo.Text, lbNome.Text, lbValorUnitario.Text, txtQuantidade.Text, lbValorTotalProduto.Text);
                valorTotalVenda += Convert.ToDecimal(lbValorTotalProduto.Text);
                lbSubtotal.Text = valorTotalVenda.ToString();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            if(valorTotalVenda != 0)
            {
                GravarVenda();
                dgvListaProdutos.Rows.Clear();
                valorTotalVenda = 0;
                lbSubtotal.Text = "00,00";
                lbTroco.Text = "00,00";
                lbTotalRecebido.Text = "00,00";
                LimparCampos();
                GerarCodigoVenda();
                MessageBox.Show("Vamos iniciar uma nova venda!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
        }

        private void MenuRestrito_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }
    }
}
