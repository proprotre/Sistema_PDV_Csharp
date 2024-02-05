namespace Login
{
    partial class CadastrarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProduto));
            produtoBindingSource = new BindingSource(components);
            dgvProdutos = new DataGridView();
            txtValorVenda = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            panel3 = new Panel();
            txtQuantidade = new TextBox();
            lbQuantidade = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            lbSelecionado = new Label();
            btnLimparCampos = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnCadastrar = new Button();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            ProdutoId = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorVendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Produto);
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.BackgroundColor = SystemColors.Window;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { ProdutoId, nomeDataGridViewTextBoxColumn, valorVendaDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn });
            dgvProdutos.DataSource = produtoBindingSource;
            dgvProdutos.Location = new Point(86, 245);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.RowTemplate.Height = 29;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(802, 366);
            dgvProdutos.TabIndex = 0;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // txtValorVenda
            // 
            txtValorVenda.BackColor = SystemColors.MenuHighlight;
            txtValorVenda.BorderStyle = BorderStyle.None;
            txtValorVenda.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorVenda.ForeColor = SystemColors.Window;
            txtValorVenda.Location = new Point(479, 102);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.PlaceholderText = "Digite o valor...";
            txtValorVenda.Size = new Size(182, 20);
            txtValorVenda.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(39, 70);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(474, 70);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 7;
            label3.Text = "Valor unitário";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.MenuHighlight;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.Window;
            txtNome.Location = new Point(43, 102);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite o nome do produto...";
            txtNome.Size = new Size(394, 20);
            txtNome.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.ForeColor = SystemColors.Window;
            panel3.Location = new Point(479, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(182, 5);
            panel3.TabIndex = 11;
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = SystemColors.MenuHighlight;
            txtQuantidade.BorderStyle = BorderStyle.None;
            txtQuantidade.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.ForeColor = SystemColors.Window;
            txtQuantidade.Location = new Point(714, 102);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = "Digite a quantidade...";
            txtQuantidade.Size = new Size(202, 20);
            txtQuantidade.TabIndex = 3;
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.BackColor = Color.Transparent;
            lbQuantidade.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuantidade.ForeColor = SystemColors.Window;
            lbQuantidade.Location = new Point(708, 70);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(124, 23);
            lbQuantidade.TabIndex = 8;
            lbQuantidade.Text = "Quantidade";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.ForeColor = SystemColors.Window;
            panel1.Location = new Point(43, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 5);
            panel1.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.ForeColor = SystemColors.Window;
            panel4.Location = new Point(714, 123);
            panel4.Name = "panel4";
            panel4.Size = new Size(202, 5);
            panel4.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lbSelecionado);
            groupBox1.Controls.Add(btnLimparCampos);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(lbQuantidade);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtValorVenda);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Window;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(945, 615);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Produtos";
            // 
            // lbSelecionado
            // 
            lbSelecionado.AutoSize = true;
            lbSelecionado.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSelecionado.Location = new Point(43, 140);
            lbSelecionado.Name = "lbSelecionado";
            lbSelecionado.Size = new Size(0, 23);
            lbSelecionado.TabIndex = 13;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.BackColor = Color.DarkSlateGray;
            btnLimparCampos.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimparCampos.Location = new Point(665, 171);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(185, 34);
            btnLimparCampos.TabIndex = 7;
            btnLimparCampos.Text = "&limpar campos";
            btnLimparCampos.UseVisualStyleBackColor = false;
            btnLimparCampos.Click += btnLimparCampos_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Location = new Point(474, 171);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(185, 34);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "&excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Blue;
            btnEditar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(284, 171);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(185, 34);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "&editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Green;
            btnCadastrar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.Window;
            btnCadastrar.Location = new Point(93, 171);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(185, 34);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "&cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.helpper;
            pictureBox1.Location = new Point(46, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Clique duas vezes sobre algum produto para selecionar");
            // 
            // ProdutoId
            // 
            ProdutoId.DataPropertyName = "ProdutoId";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "D3";
            ProdutoId.DefaultCellStyle = dataGridViewCellStyle1;
            ProdutoId.HeaderText = "ID Produto";
            ProdutoId.MinimumWidth = 6;
            ProdutoId.Name = "ProdutoId";
            ProdutoId.ReadOnly = true;
            ProdutoId.SortMode = DataGridViewColumnSortMode.NotSortable;
            ProdutoId.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            nomeDataGridViewTextBoxColumn.Width = 350;
            // 
            // valorVendaDataGridViewTextBoxColumn
            // 
            valorVendaDataGridViewTextBoxColumn.DataPropertyName = "ValorVenda";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            valorVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            valorVendaDataGridViewTextBoxColumn.HeaderText = "Valor unitário";
            valorVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorVendaDataGridViewTextBoxColumn.Name = "valorVendaDataGridViewTextBoxColumn";
            valorVendaDataGridViewTextBoxColumn.ReadOnly = true;
            valorVendaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            valorVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(969, 639);
            Controls.Add(dgvProdutos);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadastrarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Produtos";
            Load += CadastrarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource produtoBindingSource;
        private DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private DataGridView dgvProdutos;
        private TextBox txtValorVenda;
        private Label label1;
        private Label label3;
        private TextBox txtNome;
        private Panel panel3;
        private TextBox txtQuantidade;
        private Label lbQuantidade;
        private Panel panel1;
        private Panel panel4;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Button btnCadastrar;
        private Button btnLimparCampos;
        private Button btnExcluir;
        private Button btnEditar;
        private Label lbSelecionado;
        private DataGridViewTextBoxColumn ProdutoId;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
    }
}