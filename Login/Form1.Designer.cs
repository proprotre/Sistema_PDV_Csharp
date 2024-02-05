namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            lbSenha = new Label();
            txtUsuario = new TextBox();
            lbUsuario = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(lbSenha);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(lbUsuario);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Faça Login";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.ForeColor = SystemColors.Window;
            panel2.Location = new Point(6, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 5);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.ForeColor = SystemColors.Window;
            panel1.Location = new Point(6, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 5);
            panel1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(104, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "&cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Green;
            btnEntrar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.Location = new Point(225, 266);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(94, 34);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "&entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.MenuHighlight;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = SystemColors.Window;
            txtSenha.Location = new Point(18, 171);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Digite sua senha...";
            txtSenha.Size = new Size(301, 24);
            txtSenha.TabIndex = 1;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbSenha.Location = new Point(6, 137);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(83, 27);
            lbSenha.TabIndex = 2;
            lbSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.MenuHighlight;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.Window;
            txtUsuario.Location = new Point(18, 84);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite seu usuario...";
            txtUsuario.Size = new Size(301, 24);
            txtUsuario.TabIndex = 0;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsuario.Location = new Point(6, 50);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(99, 27);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(359, 343);
            ControlBox = false;
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtUsuario;
        private Label lbUsuario;
        private TextBox txtSenha;
        private Label lbSenha;
        private Button btnCancelar;
        private Button btnEntrar;
        private Panel panel1;
        private Panel panel2;
    }
}