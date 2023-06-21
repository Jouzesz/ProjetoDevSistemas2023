namespace PizzariaDoZe
{
    partial class PaginaClientes
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
            panel1 = new Panel();
            dataGridViewClientes = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            label17 = new Label();
            ButtonSalvarBD = new Button();
            label16 = new Label();
            maskedTextBoxCep = new MaskedTextBox();
            maskedTextBoxEmail = new MaskedTextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            textBoxIdId = new TextBox();
            textBoxComplemento = new TextBox();
            label12 = new Label();
            textBoxPais = new TextBox();
            label11 = new Label();
            comboBoxUF = new ComboBox();
            label10 = new Label();
            textBoxCidade = new TextBox();
            label9 = new Label();
            textBoxSeloko = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dataGridViewDados = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enderecoBindingSource = new BindingSource(components);
            textBoxLogradouro = new TextBox();
            label6 = new Label();
            textBoxNumero = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBoxBairro = new TextBox();
            label3 = new Label();
            textBoxNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ingredienteBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enderecoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 32, 40);
            panel1.Controls.Add(dataGridViewClientes);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(ButtonSalvarBD);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(maskedTextBoxCep);
            panel1.Controls.Add(maskedTextBoxEmail);
            panel1.Controls.Add(maskedTextBoxCpf);
            panel1.Controls.Add(maskedTextBoxTelefone);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(textBoxIdId);
            panel1.Controls.Add(textBoxComplemento);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBoxPais);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(comboBoxUF);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBoxCidade);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBoxSeloko);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridViewDados);
            panel1.Controls.Add(textBoxLogradouro);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxNumero);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxBairro);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 607);
            panel1.TabIndex = 0;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nomeDataGridViewTextBoxColumn });
            dataGridViewClientes.DataSource = clienteBindingSource;
            dataGridViewClientes.Location = new Point(921, 309);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowTemplate.Height = 25;
            dataGridViewClientes.Size = new Size(344, 206);
            dataGridViewClientes.TabIndex = 36;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(DAO.Cliente);
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(212, 36, 51);
            label17.Location = new Point(1018, 261);
            label17.Name = "label17";
            label17.Size = new Size(133, 45);
            label17.TabIndex = 35;
            label17.Text = "Clientes";
            // 
            // ButtonSalvarBD
            // 
            ButtonSalvarBD.BackColor = Color.FromArgb(212, 36, 51);
            ButtonSalvarBD.BackgroundImageLayout = ImageLayout.None;
            ButtonSalvarBD.FlatStyle = FlatStyle.Flat;
            ButtonSalvarBD.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSalvarBD.ForeColor = Color.FromArgb(23, 32, 40);
            ButtonSalvarBD.Location = new Point(1054, 539);
            ButtonSalvarBD.Name = "ButtonSalvarBD";
            ButtonSalvarBD.Size = new Size(211, 56);
            ButtonSalvarBD.TabIndex = 34;
            ButtonSalvarBD.Text = "Salvar";
            ButtonSalvarBD.UseVisualStyleBackColor = false;
            ButtonSalvarBD.Click += ButtonSalvarBD_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(212, 36, 51);
            label16.Location = new Point(587, 456);
            label16.Name = "label16";
            label16.Size = new Size(76, 45);
            label16.TabIndex = 33;
            label16.Text = "Cep";
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(587, 504);
            maskedTextBoxCep.Mask = "00.000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(100, 23);
            maskedTextBoxCep.TabIndex = 32;
            // 
            // maskedTextBoxEmail
            // 
            maskedTextBoxEmail.Location = new Point(463, 146);
            maskedTextBoxEmail.Mask = "pizzariadoze@servidordoze.com.br";
            maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            maskedTextBoxEmail.Size = new Size(217, 23);
            maskedTextBoxEmail.TabIndex = 31;
            maskedTextBoxEmail.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(699, 145);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(194, 23);
            maskedTextBoxCpf.TabIndex = 30;
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(259, 145);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(198, 23);
            maskedTextBoxTelefone.TabIndex = 29;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(212, 36, 51);
            label15.Location = new Point(721, 97);
            label15.Name = "label15";
            label15.Size = new Size(74, 45);
            label15.TabIndex = 27;
            label15.Text = "CPF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(212, 36, 51);
            label14.Location = new Point(463, 97);
            label14.Name = "label14";
            label14.Size = new Size(109, 45);
            label14.TabIndex = 25;
            label14.Text = "E-mail";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(212, 36, 51);
            label13.Location = new Point(357, 456);
            label13.Name = "label13";
            label13.Size = new Size(224, 45);
            label13.TabIndex = 24;
            label13.Text = "Complemento";
            // 
            // textBoxIdId
            // 
            textBoxIdId.Location = new Point(3, 145);
            textBoxIdId.Name = "textBoxIdId";
            textBoxIdId.Size = new Size(51, 23);
            textBoxIdId.TabIndex = 23;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(357, 504);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(224, 23);
            textBoxComplemento.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(212, 36, 51);
            label12.Location = new Point(214, 456);
            label12.Name = "label12";
            label12.Size = new Size(137, 45);
            label12.TabIndex = 21;
            label12.Text = "Número";
            // 
            // textBoxPais
            // 
            textBoxPais.Location = new Point(12, 504);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(196, 23);
            textBoxPais.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(212, 36, 51);
            label11.Location = new Point(0, 456);
            label11.Name = "label11";
            label11.Size = new Size(75, 45);
            label11.TabIndex = 19;
            label11.Text = "País";
            // 
            // comboBoxUF
            // 
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Location = new Point(675, 430);
            comboBoxUF.Name = "comboBoxUF";
            comboBoxUF.Size = new Size(120, 23);
            comboBoxUF.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(212, 36, 51);
            label10.Location = new Point(675, 382);
            label10.Name = "label10";
            label10.Size = new Size(58, 45);
            label10.TabIndex = 17;
            label10.Text = "UF";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(473, 430);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(196, 23);
            textBoxCidade.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(212, 36, 51);
            label9.Location = new Point(484, 382);
            label9.Name = "label9";
            label9.Size = new Size(119, 45);
            label9.TabIndex = 15;
            label9.Text = "Cidade";
            // 
            // textBoxSeloko
            // 
            textBoxSeloko.Location = new Point(12, 361);
            textBoxSeloko.Name = "textBoxSeloko";
            textBoxSeloko.Size = new Size(51, 23);
            textBoxSeloko.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(212, 36, 51);
            label8.Location = new Point(3, 313);
            label8.Name = "label8";
            label8.Size = new Size(213, 45);
            label8.TabIndex = 13;
            label8.Text = "ID (endereço)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(212, 36, 51);
            label7.Location = new Point(1018, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 45);
            label7.TabIndex = 12;
            label7.Text = "Endereços";
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AutoGenerateColumns = false;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn });
            dataGridViewDados.DataSource = enderecoBindingSource;
            dataGridViewDados.Location = new Point(921, 48);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(344, 210);
            dataGridViewDados.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // enderecoBindingSource
            // 
            enderecoBindingSource.DataSource = typeof(DAO.Endereco);
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(69, 430);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(196, 23);
            textBoxLogradouro.TabIndex = 10;
            textBoxLogradouro.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(212, 36, 51);
            label6.Location = new Point(69, 382);
            label6.Name = "label6";
            label6.Size = new Size(186, 45);
            label6.TabIndex = 9;
            label6.Text = "Logradouro";
            label6.Click += label6_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(214, 504);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(137, 23);
            textBoxNumero.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(212, 36, 51);
            label5.Location = new Point(3, 97);
            label5.Name = "label5";
            label5.Size = new Size(51, 45);
            label5.TabIndex = 7;
            label5.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(212, 36, 51);
            label4.Location = new Point(259, 97);
            label4.Name = "label4";
            label4.Size = new Size(140, 45);
            label4.TabIndex = 5;
            label4.Text = "Telefone";
            label4.Click += label4_Click;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(271, 430);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(196, 23);
            textBoxBairro.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(212, 36, 51);
            label3.Location = new Point(271, 382);
            label3.Name = "label3";
            label3.Size = new Size(103, 45);
            label3.TabIndex = 3;
            label3.Text = "Bairro";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(57, 145);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(196, 23);
            textBoxNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(212, 36, 51);
            label2.Location = new Point(57, 97);
            label2.Name = "label2";
            label2.Size = new Size(108, 45);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(212, 36, 51);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(359, 51);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de clientes";
            label1.Click += label1_Click;
            // 
            // ingredienteBindingSource
            // 
            ingredienteBindingSource.DataSource = typeof(DAO.Ingrediente);
            // 
            // PaginaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 607);
            Controls.Add(panel1);
            Name = "PaginaClientes";
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)enderecoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredienteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox textBoxBairro;
        private Label label3;
        private TextBox textBoxNome;
        private Label label2;
        private Label label1;
        private TextBox textBoxLogradouro;
        private Label label6;
        private TextBox textBoxNumero;
        private Label label5;
        private Label label7;
        private DataGridView dataGridViewDados;
        private BindingSource ingredienteBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource enderecoBindingSource;
        private TextBox textBoxSeloko;
        private Label label8;
        private Label label10;
        private TextBox textBoxCidade;
        private Label label9;
        private TextBox textBoxIdId;
        private TextBox textBoxComplemento;
        private Label label12;
        private TextBox textBoxPais;
        private Label label11;
        private ComboBox comboBoxUF;
        private TextBox textBox11;
        private Label label14;
        private Label label13;
        private Label label15;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxEmail;
        private Label label16;
        private MaskedTextBox maskedTextBoxCep;
        private Button ButtonSalvarBD;
        private DataGridView dataGridViewClientes;
        private Label label17;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
    }
}