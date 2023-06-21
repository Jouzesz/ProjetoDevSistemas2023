namespace PizzariaDoZe
{
    partial class Principal
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
            panel1 = new Panel();
            panel2 = new Panel();
            buttonSobreNos = new Button();
            buttonConfig = new Button();
            buttonLogin = new Button();
            buttonValores = new Button();
            buttonProdutos = new Button();
            Sabores = new Button();
            Ingredientes = new Button();
            Clientes = new Button();
            Funcionarios = new Button();
            pictureBox1 = new PictureBox();
            buttonPedidos = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 32, 40);
            panel1.Controls.Add(buttonPedidos);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonValores);
            panel1.Controls.Add(buttonProdutos);
            panel1.Controls.Add(Sabores);
            panel1.Controls.Add(Ingredientes);
            panel1.Controls.Add(Clientes);
            panel1.Controls.Add(Funcionarios);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 588);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 36, 51);
            panel2.Controls.Add(buttonSobreNos);
            panel2.Controls.Add(buttonConfig);
            panel2.Controls.Add(buttonLogin);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(646, 31);
            panel2.TabIndex = 7;
            // 
            // buttonSobreNos
            // 
            buttonSobreNos.BackColor = Color.FromArgb(212, 36, 51);
            buttonSobreNos.BackgroundImageLayout = ImageLayout.None;
            buttonSobreNos.FlatAppearance.BorderSize = 0;
            buttonSobreNos.FlatStyle = FlatStyle.Flat;
            buttonSobreNos.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSobreNos.ForeColor = Color.White;
            buttonSobreNos.Location = new Point(12, 3);
            buttonSobreNos.Name = "buttonSobreNos";
            buttonSobreNos.Size = new Size(133, 28);
            buttonSobreNos.TabIndex = 10;
            buttonSobreNos.Text = "Sobre nós";
            buttonSobreNos.UseVisualStyleBackColor = false;
            // 
            // buttonConfig
            // 
            buttonConfig.BackColor = Color.FromArgb(212, 36, 51);
            buttonConfig.BackgroundImageLayout = ImageLayout.None;
            buttonConfig.FlatAppearance.BorderSize = 0;
            buttonConfig.FlatStyle = FlatStyle.Flat;
            buttonConfig.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonConfig.ForeColor = Color.White;
            buttonConfig.Location = new Point(510, 0);
            buttonConfig.Name = "buttonConfig";
            buttonConfig.Size = new Size(133, 28);
            buttonConfig.TabIndex = 9;
            buttonConfig.Text = "Configurações";
            buttonConfig.UseVisualStyleBackColor = false;
            buttonConfig.Click += buttonConfig_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(212, 36, 51);
            buttonLogin.BackgroundImageLayout = ImageLayout.None;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(261, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(133, 28);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonValores
            // 
            buttonValores.BackColor = Color.FromArgb(212, 36, 51);
            buttonValores.BackgroundImageLayout = ImageLayout.None;
            buttonValores.FlatStyle = FlatStyle.Flat;
            buttonValores.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            buttonValores.ForeColor = Color.FromArgb(23, 32, 40);
            buttonValores.Location = new Point(328, 383);
            buttonValores.Name = "buttonValores";
            buttonValores.Size = new Size(310, 86);
            buttonValores.TabIndex = 6;
            buttonValores.Text = "Valores";
            buttonValores.UseVisualStyleBackColor = false;
            buttonValores.Click += buttonValores_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.BackColor = Color.FromArgb(212, 36, 51);
            buttonProdutos.BackgroundImageLayout = ImageLayout.None;
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProdutos.ForeColor = Color.FromArgb(23, 32, 40);
            buttonProdutos.Location = new Point(12, 383);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(310, 86);
            buttonProdutos.TabIndex = 5;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = false;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // Sabores
            // 
            Sabores.BackColor = Color.FromArgb(212, 36, 51);
            Sabores.BackgroundImageLayout = ImageLayout.None;
            Sabores.FlatStyle = FlatStyle.Flat;
            Sabores.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            Sabores.ForeColor = Color.FromArgb(23, 32, 40);
            Sabores.Location = new Point(328, 291);
            Sabores.Name = "Sabores";
            Sabores.Size = new Size(310, 86);
            Sabores.TabIndex = 4;
            Sabores.Text = "Sabores";
            Sabores.UseVisualStyleBackColor = false;
            Sabores.Click += Sabores_Click;
            // 
            // Ingredientes
            // 
            Ingredientes.BackColor = Color.FromArgb(212, 36, 51);
            Ingredientes.BackgroundImageLayout = ImageLayout.None;
            Ingredientes.FlatStyle = FlatStyle.Flat;
            Ingredientes.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            Ingredientes.ForeColor = Color.FromArgb(23, 32, 40);
            Ingredientes.Location = new Point(12, 291);
            Ingredientes.Name = "Ingredientes";
            Ingredientes.Size = new Size(310, 86);
            Ingredientes.TabIndex = 3;
            Ingredientes.Text = "Ingredientes";
            Ingredientes.UseVisualStyleBackColor = false;
            Ingredientes.Click += Ingredientes_Click;
            // 
            // Clientes
            // 
            Clientes.BackColor = Color.FromArgb(212, 36, 51);
            Clientes.BackgroundImageLayout = ImageLayout.None;
            Clientes.FlatStyle = FlatStyle.Flat;
            Clientes.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            Clientes.ForeColor = Color.FromArgb(23, 32, 40);
            Clientes.Location = new Point(328, 199);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(310, 86);
            Clientes.TabIndex = 2;
            Clientes.Text = "Clientes";
            Clientes.UseVisualStyleBackColor = false;
            Clientes.Click += Clientes_Click;
            // 
            // Funcionarios
            // 
            Funcionarios.BackColor = Color.FromArgb(212, 36, 51);
            Funcionarios.BackgroundImageLayout = ImageLayout.None;
            Funcionarios.FlatStyle = FlatStyle.Flat;
            Funcionarios.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            Funcionarios.ForeColor = Color.FromArgb(23, 32, 40);
            Funcionarios.Location = new Point(12, 199);
            Funcionarios.Name = "Funcionarios";
            Funcionarios.Size = new Size(310, 86);
            Funcionarios.TabIndex = 1;
            Funcionarios.Text = "Funcionários";
            Funcionarios.UseVisualStyleBackColor = false;
            Funcionarios.Click += Funcionarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_20_removebg_preview;
            pictureBox1.Location = new Point(164, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonPedidos
            // 
            buttonPedidos.BackColor = Color.FromArgb(212, 36, 51);
            buttonPedidos.BackgroundImageLayout = ImageLayout.None;
            buttonPedidos.FlatStyle = FlatStyle.Flat;
            buttonPedidos.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPedidos.ForeColor = Color.FromArgb(23, 32, 40);
            buttonPedidos.Location = new Point(164, 475);
            buttonPedidos.Name = "buttonPedidos";
            buttonPedidos.Size = new Size(310, 86);
            buttonPedidos.TabIndex = 8;
            buttonPedidos.Text = "Pedidos";
            buttonPedidos.UseVisualStyleBackColor = false;
            buttonPedidos.Click += buttonPedidos_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 588);
            Controls.Add(panel1);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button Funcionarios;
        private Button Sabores;
        private Button Ingredientes;
        private Button Clientes;
        private Button buttonProdutos;
        private Button buttonValores;
        private Panel panel2;
        private Button buttonSobreNos;
        private Button buttonConfig;
        private Button buttonLogin;
        private Button buttonPedidos;
    }
}