namespace PizzariaDoZe
{
    partial class PaginaProdutos
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
            label6 = new Label();
            label5 = new Label();
            listBoxTipo = new ListBox();
            listBoxML = new ListBox();
            label4 = new Label();
            textBoxValor = new TextBox();
            textBoxNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridViewDados = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mLDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoBindingSource = new BindingSource(components);
            ButtonSalvarBD = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 32, 40);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(listBoxTipo);
            panel1.Controls.Add(listBoxML);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxValor);
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridViewDados);
            panel1.Controls.Add(ButtonSalvarBD);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(212, 36, 51);
            label6.Location = new Point(138, 155);
            label6.Name = "label6";
            label6.Size = new Size(64, 45);
            label6.TabIndex = 47;
            label6.Text = "ML";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(212, 36, 51);
            label5.Location = new Point(12, 155);
            label5.Name = "label5";
            label5.Size = new Size(83, 45);
            label5.TabIndex = 46;
            label5.Text = "Tipo";
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Items.AddRange(new object[] { "Água", "Cerveja", "Refrigerante", "Suco" });
            listBoxTipo.Location = new Point(12, 203);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(120, 94);
            listBoxTipo.TabIndex = 45;
            // 
            // listBoxML
            // 
            listBoxML.FormattingEnabled = true;
            listBoxML.ItemHeight = 15;
            listBoxML.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            listBoxML.Location = new Point(138, 203);
            listBoxML.Name = "listBoxML";
            listBoxML.Size = new Size(120, 94);
            listBoxML.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(212, 36, 51);
            label4.Location = new Point(118, 74);
            label4.Name = "label4";
            label4.Size = new Size(92, 45);
            label4.TabIndex = 43;
            label4.Text = "Valor";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(118, 122);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(100, 23);
            textBoxValor.TabIndex = 42;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 122);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(212, 36, 51);
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(108, 45);
            label3.TabIndex = 40;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(212, 36, 51);
            label2.Location = new Point(560, 74);
            label2.Name = "label2";
            label2.Size = new Size(149, 45);
            label2.TabIndex = 39;
            label2.Text = "Produtos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(212, 36, 51);
            label1.Location = new Point(211, 9);
            label1.Name = "label1";
            label1.Size = new Size(383, 51);
            label1.TabIndex = 38;
            label1.Text = "Cadastro de Produtos";
            label1.Click += label1_Click;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AutoGenerateColumns = false;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, valorDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, mLDataGridViewTextBoxColumn });
            dataGridViewDados.DataSource = produtoBindingSource;
            dataGridViewDados.Location = new Point(485, 122);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(303, 150);
            dataGridViewDados.TabIndex = 37;
            dataGridViewDados.CellContentClick += dataGridViewDados_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // mLDataGridViewTextBoxColumn
            // 
            mLDataGridViewTextBoxColumn.DataPropertyName = "ML";
            mLDataGridViewTextBoxColumn.HeaderText = "ML";
            mLDataGridViewTextBoxColumn.Name = "mLDataGridViewTextBoxColumn";
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(DAO.Produto);
            // 
            // ButtonSalvarBD
            // 
            ButtonSalvarBD.BackColor = Color.FromArgb(212, 36, 51);
            ButtonSalvarBD.BackgroundImageLayout = ImageLayout.None;
            ButtonSalvarBD.FlatStyle = FlatStyle.Flat;
            ButtonSalvarBD.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSalvarBD.ForeColor = Color.FromArgb(23, 32, 40);
            ButtonSalvarBD.Location = new Point(577, 382);
            ButtonSalvarBD.Name = "ButtonSalvarBD";
            ButtonSalvarBD.Size = new Size(211, 56);
            ButtonSalvarBD.TabIndex = 36;
            ButtonSalvarBD.Text = "Salvar";
            ButtonSalvarBD.UseVisualStyleBackColor = false;
            ButtonSalvarBD.Click += ButtonSalvarBD_Click;
            // 
            // PaginaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "PaginaProdutos";
            Text = "Form8";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ButtonSalvarBD;
        private DataGridView dataGridViewDados;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mLDataGridViewTextBoxColumn;
        private BindingSource produtoBindingSource;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private ListBox listBoxTipo;
        private ListBox listBoxML;
        private Label label4;
        private TextBox textBoxValor;
        private TextBox textBoxNome;
    }
}