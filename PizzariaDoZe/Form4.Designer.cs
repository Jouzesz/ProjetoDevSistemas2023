namespace PizzariaDoZe
{
    partial class PaginaIngredientes
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
            dataGridViewDados = new DataGridView();
            buttonCadastro = new Button();
            textboxNome = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ingredienteBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 32, 40);
            panel1.Controls.Add(dataGridViewDados);
            panel1.Controls.Add(buttonCadastro);
            panel1.Controls.Add(textboxNome);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AutoGenerateColumns = false;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn });
            dataGridViewDados.DataSource = ingredienteBindingSource;
            dataGridViewDados.Location = new Point(545, 90);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(240, 150);
            dataGridViewDados.TabIndex = 7;
            dataGridViewDados.CellContentClick += dataGridViewDados_CellContentClick;
            // 
            // buttonCadastro
            // 
            buttonCadastro.BackColor = Color.FromArgb(212, 36, 51);
            buttonCadastro.BackgroundImageLayout = ImageLayout.None;
            buttonCadastro.FlatStyle = FlatStyle.Flat;
            buttonCadastro.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastro.ForeColor = Color.FromArgb(23, 32, 40);
            buttonCadastro.Location = new Point(545, 385);
            buttonCadastro.Name = "buttonCadastro";
            buttonCadastro.Size = new Size(243, 53);
            buttonCadastro.TabIndex = 6;
            buttonCadastro.Text = "Cadastrar";
            buttonCadastro.UseVisualStyleBackColor = false;
            buttonCadastro.Click += buttonCadastro_Click;
            // 
            // textboxNome
            // 
            textboxNome.Location = new Point(179, 138);
            textboxNome.Name = "textboxNome";
            textboxNome.Size = new Size(124, 23);
            textboxNome.TabIndex = 4;
            textboxNome.TextChanged += textboxNome_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(212, 36, 51);
            label3.Location = new Point(169, 90);
            label3.Name = "label3";
            label3.Size = new Size(108, 45);
            label3.TabIndex = 3;
            label3.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(212, 36, 51);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(124, 45);
            label2.TabIndex = 1;
            label2.Text = "Código";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(212, 36, 51);
            label1.Location = new Point(192, 9);
            label1.Name = "label1";
            label1.Size = new Size(440, 51);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de ingredientes";
            // 
            // ingredienteBindingSource
            // 
            ingredienteBindingSource.DataSource = typeof(DAO.Ingrediente);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // PaginaIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "PaginaIngredientes";
            Text = "Ingredientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredienteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textboxNome;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button buttonCadastro;
        private DataGridView dataGridViewDados;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private BindingSource ingredienteBindingSource;
    }
}