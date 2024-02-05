namespace Login
{
    partial class MenuRestrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRestrito));
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarProdutosToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            lbNome = new Label();
            panel7 = new Panel();
            label2 = new Label();
            panel8 = new Panel();
            panel23 = new Panel();
            txtCodigo = new TextBox();
            panel9 = new Panel();
            panel24 = new Panel();
            txtQuantidade = new TextBox();
            panel10 = new Panel();
            label3 = new Label();
            panel11 = new Panel();
            label12 = new Label();
            lbValorUnitario = new Label();
            panel12 = new Panel();
            label4 = new Label();
            panel13 = new Panel();
            label13 = new Label();
            panel14 = new Panel();
            label5 = new Label();
            lbValorTotalProduto = new Label();
            panel2 = new Panel();
            dgvListaProdutos = new DataGridView();
            panel15 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            label15 = new Label();
            panel5 = new Panel();
            labelsubtotal = new Label();
            lbSubtotal = new Label();
            panel16 = new Panel();
            label19 = new Label();
            panel17 = new Panel();
            label8 = new Label();
            lbTotalRecebido = new Label();
            panel18 = new Panel();
            label17 = new Label();
            panel19 = new Panel();
            label9 = new Label();
            lbTroco = new Label();
            panel20 = new Panel();
            panel21 = new Panel();
            label10 = new Label();
            panel22 = new Panel();
            label11 = new Label();
            panel25 = new Panel();
            lbCodVenda = new Label();
            panel27 = new Panel();
            label14 = new Label();
            label7 = new Label();
            btnReceber = new Button();
            btnAdicionarProduto = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).BeginInit();
            panel15.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel25.SuspendLayout();
            panel27.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, configuraçõesToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1582, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarProdutosToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(75, 24);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            cadastrarProdutosToolStripMenuItem.Size = new Size(218, 26);
            cadastrarProdutosToolStripMenuItem.Text = "Cadastrar Produtos";
            cadastrarProdutosToolStripMenuItem.Click += cadastrarProdutosToolStripMenuItem_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(118, 24);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 344);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.caixa;
            pictureBox1.Location = new Point(46, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 308);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.RoyalBlue;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1181, 30);
            panel4.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(223, 23);
            label1.TabIndex = 0;
            label1.Text = "Descrição do produto";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.Gainsboro;
            panel6.Controls.Add(lbNome);
            panel6.Controls.Add(panel4);
            panel6.Location = new Point(383, 40);
            panel6.Name = "panel6";
            panel6.Size = new Size(1181, 82);
            panel6.TabIndex = 6;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbNome.ForeColor = SystemColors.ControlText;
            lbNome.Location = new Point(12, 38);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(0, 34);
            lbNome.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Right;
            panel7.BackColor = Color.RoyalBlue;
            panel7.Controls.Add(label2);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(330, 30);
            panel7.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(3, 1);
            label2.Name = "label2";
            label2.Size = new Size(163, 23);
            label2.TabIndex = 0;
            label2.Text = "Código produto";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Right;
            panel8.BackColor = Color.Gainsboro;
            panel8.Controls.Add(panel23);
            panel8.Controls.Add(txtCodigo);
            panel8.Controls.Add(panel7);
            panel8.Location = new Point(382, 215);
            panel8.Name = "panel8";
            panel8.Size = new Size(329, 82);
            panel8.TabIndex = 7;
            // 
            // panel23
            // 
            panel23.BackColor = Color.Black;
            panel23.Location = new Point(14, 66);
            panel23.Name = "panel23";
            panel23.Size = new Size(180, 3);
            panel23.TabIndex = 8;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.Gainsboro;
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(14, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 35);
            txtCodigo.TabIndex = 0;
            txtCodigo.Validating += txtCodigo_Validating;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Right;
            panel9.BackColor = Color.Gainsboro;
            panel9.Controls.Add(panel24);
            panel9.Controls.Add(txtQuantidade);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(383, 303);
            panel9.Name = "panel9";
            panel9.Size = new Size(329, 82);
            panel9.TabIndex = 8;
            // 
            // panel24
            // 
            panel24.BackColor = Color.Black;
            panel24.Location = new Point(13, 65);
            panel24.Name = "panel24";
            panel24.Size = new Size(150, 3);
            panel24.TabIndex = 9;
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.Gainsboro;
            txtQuantidade.BorderStyle = BorderStyle.None;
            txtQuantidade.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.Location = new Point(12, 32);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 35);
            txtQuantidade.TabIndex = 1;
            txtQuantidade.Validating += txtQuantidade_Validating;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Right;
            panel10.BackColor = Color.RoyalBlue;
            panel10.Controls.Add(label3);
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(329, 30);
            panel10.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(3, 1);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 0;
            label3.Text = "Quantidade";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Right;
            panel11.BackColor = Color.Gainsboro;
            panel11.Controls.Add(label12);
            panel11.Controls.Add(lbValorUnitario);
            panel11.Controls.Add(panel12);
            panel11.Location = new Point(383, 391);
            panel11.Name = "panel11";
            panel11.Size = new Size(329, 82);
            panel11.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(3, 37);
            label12.Name = "label12";
            label12.Size = new Size(55, 34);
            label12.TabIndex = 9;
            label12.Text = "R$";
            // 
            // lbValorUnitario
            // 
            lbValorUnitario.AutoSize = true;
            lbValorUnitario.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbValorUnitario.ForeColor = SystemColors.ControlText;
            lbValorUnitario.Location = new Point(64, 37);
            lbValorUnitario.Name = "lbValorUnitario";
            lbValorUnitario.Size = new Size(96, 34);
            lbValorUnitario.TabIndex = 8;
            lbValorUnitario.Text = "00,00";
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Right;
            panel12.BackColor = Color.RoyalBlue;
            panel12.Controls.Add(label4);
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(329, 30);
            panel12.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(3, 1);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 0;
            label4.Text = "Valor unitário";
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Right;
            panel13.BackColor = Color.Gainsboro;
            panel13.Controls.Add(label13);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(lbValorTotalProduto);
            panel13.Location = new Point(383, 479);
            panel13.Name = "panel13";
            panel13.Size = new Size(329, 82);
            panel13.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(3, 38);
            label13.Name = "label13";
            label13.Size = new Size(55, 34);
            label13.TabIndex = 11;
            label13.Text = "R$";
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Right;
            panel14.BackColor = Color.RoyalBlue;
            panel14.Controls.Add(label5);
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(329, 30);
            panel14.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(3, 1);
            label5.Name = "label5";
            label5.Size = new Size(193, 23);
            label5.TabIndex = 0;
            label5.Text = "Valor total produto";
            // 
            // lbValorTotalProduto
            // 
            lbValorTotalProduto.AutoSize = true;
            lbValorTotalProduto.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbValorTotalProduto.ForeColor = SystemColors.ControlText;
            lbValorTotalProduto.Location = new Point(64, 38);
            lbValorTotalProduto.Name = "lbValorTotalProduto";
            lbValorTotalProduto.Size = new Size(96, 34);
            lbValorTotalProduto.TabIndex = 10;
            lbValorTotalProduto.Text = "00,00";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(dgvListaProdutos);
            panel2.Location = new Point(717, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 521);
            panel2.TabIndex = 11;
            // 
            // dgvListaProdutos
            // 
            dgvListaProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvListaProdutos.BackgroundColor = Color.Gainsboro;
            dgvListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProdutos.Location = new Point(1, 27);
            dgvListaProdutos.Name = "dgvListaProdutos";
            dgvListaProdutos.RowHeadersWidth = 51;
            dgvListaProdutos.RowTemplate.Height = 29;
            dgvListaProdutos.Size = new Size(846, 494);
            dgvListaProdutos.TabIndex = 0;
            // 
            // panel15
            // 
            panel15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel15.BackColor = Color.RoyalBlue;
            panel15.Controls.Add(label6);
            panel15.Location = new Point(717, 128);
            panel15.Name = "panel15";
            panel15.Size = new Size(847, 30);
            panel15.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(2, 3);
            label6.Name = "label6";
            label6.Size = new Size(181, 23);
            label6.TabIndex = 0;
            label6.Text = "Lista de produtos";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(label15);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lbSubtotal);
            panel3.Location = new Point(383, 655);
            panel3.Name = "panel3";
            panel3.Size = new Size(864, 82);
            panel3.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(702, 40);
            label15.Name = "label15";
            label15.Size = new Size(55, 34);
            label15.TabIndex = 13;
            label15.Text = "R$";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = Color.RoyalBlue;
            panel5.Controls.Add(labelsubtotal);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(864, 30);
            panel5.TabIndex = 6;
            // 
            // labelsubtotal
            // 
            labelsubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelsubtotal.AutoSize = true;
            labelsubtotal.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelsubtotal.ForeColor = SystemColors.Window;
            labelsubtotal.Location = new Point(753, 3);
            labelsubtotal.Name = "labelsubtotal";
            labelsubtotal.Size = new Size(105, 27);
            labelsubtotal.TabIndex = 0;
            labelsubtotal.Text = "Subtotal";
            // 
            // lbSubtotal
            // 
            lbSubtotal.AutoSize = true;
            lbSubtotal.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbSubtotal.ForeColor = SystemColors.ControlText;
            lbSubtotal.Location = new Point(749, 40);
            lbSubtotal.Name = "lbSubtotal";
            lbSubtotal.Size = new Size(96, 34);
            lbSubtotal.TabIndex = 12;
            lbSubtotal.Text = "00,00";
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel16.BackColor = Color.Gainsboro;
            panel16.Controls.Add(label19);
            panel16.Controls.Add(panel17);
            panel16.Controls.Add(lbTotalRecebido);
            panel16.Location = new Point(382, 743);
            panel16.Name = "panel16";
            panel16.Size = new Size(484, 82);
            panel16.TabIndex = 8;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlText;
            label19.Location = new Point(302, 38);
            label19.Name = "label19";
            label19.Size = new Size(55, 34);
            label19.TabIndex = 17;
            label19.Text = "R$";
            // 
            // panel17
            // 
            panel17.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel17.BackColor = Color.RoyalBlue;
            panel17.Controls.Add(label8);
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(484, 30);
            panel17.TabIndex = 6;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(297, 3);
            label8.Name = "label8";
            label8.Size = new Size(174, 27);
            label8.TabIndex = 0;
            label8.Text = "Total recebido";
            // 
            // lbTotalRecebido
            // 
            lbTotalRecebido.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbTotalRecebido.AutoSize = true;
            lbTotalRecebido.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotalRecebido.ForeColor = SystemColors.ControlText;
            lbTotalRecebido.Location = new Point(351, 38);
            lbTotalRecebido.Name = "lbTotalRecebido";
            lbTotalRecebido.Size = new Size(96, 34);
            lbTotalRecebido.TabIndex = 16;
            lbTotalRecebido.Text = "00,00";
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel18.BackColor = Color.Gainsboro;
            panel18.Controls.Add(label17);
            panel18.Controls.Add(panel19);
            panel18.Controls.Add(lbTroco);
            panel18.Location = new Point(872, 743);
            panel18.Name = "panel18";
            panel18.Size = new Size(375, 82);
            panel18.TabIndex = 9;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlText;
            label17.Location = new Point(215, 38);
            label17.Name = "label17";
            label17.Size = new Size(55, 34);
            label17.TabIndex = 15;
            label17.Text = "R$";
            // 
            // panel19
            // 
            panel19.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel19.BackColor = Color.RoyalBlue;
            panel19.Controls.Add(label9);
            panel19.Location = new Point(-55, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(430, 30);
            panel19.TabIndex = 6;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(343, 3);
            label9.Name = "label9";
            label9.Size = new Size(78, 27);
            label9.TabIndex = 0;
            label9.Text = "Troco";
            // 
            // lbTroco
            // 
            lbTroco.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbTroco.AutoSize = true;
            lbTroco.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbTroco.ForeColor = SystemColors.ControlText;
            lbTroco.Location = new Point(262, 38);
            lbTroco.Name = "lbTroco";
            lbTroco.Size = new Size(96, 34);
            lbTroco.TabIndex = 14;
            lbTroco.Text = "00,00";
            // 
            // panel20
            // 
            panel20.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel20.BackColor = Color.Gainsboro;
            panel20.Controls.Add(panel21);
            panel20.Location = new Point(12, 391);
            panel20.Name = "panel20";
            panel20.Size = new Size(364, 434);
            panel20.TabIndex = 9;
            // 
            // panel21
            // 
            panel21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel21.BackColor = Color.RoyalBlue;
            panel21.Controls.Add(label10);
            panel21.Location = new Point(0, 0);
            panel21.Name = "panel21";
            panel21.Size = new Size(365, 30);
            panel21.TabIndex = 6;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(3, 7);
            label10.Name = "label10";
            label10.Size = new Size(83, 23);
            label10.TabIndex = 0;
            label10.Text = "Atalhos";
            // 
            // panel22
            // 
            panel22.BackColor = Color.RoyalBlue;
            panel22.Controls.Add(label11);
            panel22.Location = new Point(12, 40);
            panel22.Name = "panel22";
            panel22.Size = new Size(365, 30);
            panel22.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(3, 7);
            label11.Name = "label11";
            label11.Size = new Size(135, 23);
            label11.TabIndex = 0;
            label11.Text = "Sistema PDV";
            // 
            // panel25
            // 
            panel25.Anchor = AnchorStyles.Right;
            panel25.BackColor = Color.Gainsboro;
            panel25.Controls.Add(lbCodVenda);
            panel25.Controls.Add(panel27);
            panel25.Location = new Point(382, 127);
            panel25.Name = "panel25";
            panel25.Size = new Size(329, 82);
            panel25.TabIndex = 9;
            // 
            // lbCodVenda
            // 
            lbCodVenda.Anchor = AnchorStyles.Right;
            lbCodVenda.AutoSize = true;
            lbCodVenda.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbCodVenda.ForeColor = SystemColors.ControlText;
            lbCodVenda.Location = new Point(4, 33);
            lbCodVenda.Name = "lbCodVenda";
            lbCodVenda.Size = new Size(44, 46);
            lbCodVenda.TabIndex = 10;
            lbCodVenda.Text = "0";
            // 
            // panel27
            // 
            panel27.Anchor = AnchorStyles.Right;
            panel27.BackColor = Color.RoyalBlue;
            panel27.Controls.Add(label14);
            panel27.Controls.Add(label7);
            panel27.Location = new Point(0, 0);
            panel27.Name = "panel27";
            panel27.Size = new Size(329, 30);
            panel27.TabIndex = 6;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Window;
            label14.Location = new Point(3, 3);
            label14.Name = "label14";
            label14.Size = new Size(178, 23);
            label14.TabIndex = 1;
            label14.Text = "Código da Venda";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(3, -34);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 0;
            label7.Text = "Código";
            // 
            // btnReceber
            // 
            btnReceber.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReceber.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnReceber.ForeColor = SystemColors.Desktop;
            btnReceber.Image = (Image)resources.GetObject("btnReceber.Image");
            btnReceber.Location = new Point(1256, 655);
            btnReceber.Name = "btnReceber";
            btnReceber.Size = new Size(308, 170);
            btnReceber.TabIndex = 3;
            btnReceber.Text = "receber";
            btnReceber.TextAlign = ContentAlignment.BottomCenter;
            btnReceber.UseVisualStyleBackColor = true;
            btnReceber.Click += btnReceber_Click;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Anchor = AnchorStyles.Right;
            btnAdicionarProduto.BackColor = Color.Green;
            btnAdicionarProduto.Font = new Font("Arial Rounded MT Bold", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionarProduto.ForeColor = SystemColors.Window;
            btnAdicionarProduto.Location = new Point(382, 579);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(329, 60);
            btnAdicionarProduto.TabIndex = 2;
            btnAdicionarProduto.Text = "Adicionar produto";
            btnAdicionarProduto.UseVisualStyleBackColor = false;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // MenuRestrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1582, 837);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(btnReceber);
            Controls.Add(panel25);
            Controls.Add(panel22);
            Controls.Add(panel20);
            Controls.Add(panel18);
            Controls.Add(panel16);
            Controls.Add(panel3);
            Controls.Add(panel15);
            Controls.Add(panel2);
            Controls.Add(panel13);
            Controls.Add(panel11);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MenuRestrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema PDV";
            FormClosing += MenuRestrito_FormClosing;
            Load += MenuRestrito_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private Panel panel1;
        private Panel panel4;
        private Panel panel6;
        private Label label1;
        private Panel panel7;
        private Label label2;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Label label3;
        private Panel panel11;
        private Panel panel12;
        private Label label4;
        private Panel panel13;
        private Panel panel14;
        private Label label5;
        private Panel panel2;
        private Panel panel15;
        private Label label6;
        private Panel panel3;
        private Panel panel5;
        private Label labelsubtotal;
        private Panel panel16;
        private Panel panel17;
        private Label label8;
        private Panel panel18;
        private Panel panel19;
        private Label label9;
        private Panel panel20;
        private Panel panel21;
        private Label label10;
        private Panel panel22;
        private Label label11;
        private PictureBox pictureBox1;
        private Label lbNome;
        private TextBox txtCodigo;
        private Panel panel23;
        private Panel panel24;
        private TextBox txtQuantidade;
        private Label label12;
        private Label lbValorUnitario;
        private Label label13;
        private Label lbValorTotalProduto;
        private Label label15;
        private Label lbSubtotal;
        private Label label19;
        private Label lbTotalRecebido;
        private Label label17;
        private Label lbTroco;
        private Label label14;
        private Panel panel25;
        private Panel panel27;
        private Label label7;
        private Label lbCodVenda;
        private DataGridView dgvListaProdutos;
        private Button btnReceber;
        private Button btnAdicionarProduto;
    }
}