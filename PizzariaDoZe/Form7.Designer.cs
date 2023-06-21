namespace PizzariaDoZe
{
    partial class PaginaValores
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
            dataGridViewDados = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tamanhoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorPizzaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorBordaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorBindingSource = new BindingSource(components);
            maskedTextValor = new MaskedTextBox();
            textBoxValorBorda = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            ButtonSalvarBD = new Button();
            listBoxTamanho = new ListBox();
            listBoxCategoria = new ListBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 32, 40);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dataGridViewDados);
            panel1.Controls.Add(maskedTextValor);
            panel1.Controls.Add(textBoxValorBorda);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(ButtonSalvarBD);
            panel1.Controls.Add(listBoxTamanho);
            panel1.Controls.Add(listBoxCategoria);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(212, 36, 51);
            label6.Location = new Point(577, 105);
            label6.Name = "label6";
            label6.Size = new Size(123, 45);
            label6.TabIndex = 46;
            label6.Text = "Valores";
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AutoGenerateColumns = false;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tamanhoDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, valorPizzaDataGridViewTextBoxColumn, valorBordaDataGridViewTextBoxColumn });
            dataGridViewDados.DataSource = valorBindingSource;
            dataGridViewDados.Location = new Point(548, 152);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(240, 154);
            dataGridViewDados.TabIndex = 45;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            tamanhoDataGridViewTextBoxColumn.DataPropertyName = "Tamanho";
            tamanhoDataGridViewTextBoxColumn.HeaderText = "Tamanho";
            tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // valorPizzaDataGridViewTextBoxColumn
            // 
            valorPizzaDataGridViewTextBoxColumn.DataPropertyName = "ValorPizza";
            valorPizzaDataGridViewTextBoxColumn.HeaderText = "ValorPizza";
            valorPizzaDataGridViewTextBoxColumn.Name = "valorPizzaDataGridViewTextBoxColumn";
            // 
            // valorBordaDataGridViewTextBoxColumn
            // 
            valorBordaDataGridViewTextBoxColumn.DataPropertyName = "ValorBorda";
            valorBordaDataGridViewTextBoxColumn.HeaderText = "ValorBorda";
            valorBordaDataGridViewTextBoxColumn.Name = "valorBordaDataGridViewTextBoxColumn";
            // 
            // valorBindingSource
            // 
            valorBindingSource.DataSource = typeof(DAO.Valor);
            // 
            // maskedTextValor
            // 
            maskedTextValor.Location = new Point(12, 200);
            maskedTextValor.Name = "maskedTextValor";
            maskedTextValor.Size = new Size(100, 23);
            maskedTextValor.TabIndex = 44;
            // 
            // textBoxValorBorda
            // 
            textBoxValorBorda.Location = new Point(12, 274);
            textBoxValorBorda.Name = "textBoxValorBorda";
            textBoxValorBorda.Size = new Size(100, 23);
            textBoxValorBorda.TabIndex = 43;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(212, 36, 51);
            label5.Location = new Point(12, 226);
            label5.Name = "label5";
            label5.Size = new Size(185, 45);
            label5.TabIndex = 40;
            label5.Text = "Valor borda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(212, 36, 51);
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(92, 45);
            label4.TabIndex = 39;
            label4.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(212, 36, 51);
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(51, 45);
            label3.TabIndex = 38;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(212, 36, 51);
            label2.Location = new Point(209, 104);
            label2.Name = "label2";
            label2.Size = new Size(148, 45);
            label2.TabIndex = 37;
            label2.Text = "Tamanho";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(212, 36, 51);
            label7.Location = new Point(352, 104);
            label7.Name = "label7";
            label7.Size = new Size(157, 45);
            label7.TabIndex = 36;
            label7.Text = "Categoria";
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
            ButtonSalvarBD.TabIndex = 35;
            ButtonSalvarBD.Text = "Salvar";
            ButtonSalvarBD.UseVisualStyleBackColor = false;
            ButtonSalvarBD.Click += ButtonSalvarBD_Click;
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.ItemHeight = 15;
            listBoxTamanho.Location = new Point(209, 152);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(147, 154);
            listBoxTamanho.TabIndex = 3;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(362, 152);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(147, 154);
            listBoxCategoria.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(212, 36, 51);
            label1.Location = new Point(209, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 51);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Valores";
            label1.Click += label1_Click;
            // 
            // PaginaValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "PaginaValores";
            Text = "Form7";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)valorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox listBoxTamanho;
        private ListBox listBoxCategoria;
        private Button ButtonSalvarBD;
        private TextBox textBoxValorBorda;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private MaskedTextBox maskedTextValor;
        private Label label6;
        private DataGridView dataGridViewDados;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorPizzaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorBordaDataGridViewTextBoxColumn;
        private BindingSource valorBindingSource;
    }
}