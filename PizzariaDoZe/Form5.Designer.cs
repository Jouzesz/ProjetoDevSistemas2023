namespace PizzariaDoZe
{
    partial class PaginaSabores
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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fotoDataGridViewImageColumn = new DataGridViewImageColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saborBindingSource = new BindingSource(components);
            buttonValores = new Button();
            pictureBoxImagem = new PictureBox();
            listBoxTipo = new ListBox();
            listBoxCategoria = new ListBox();
            checkedListBoxIngredientes = new CheckedListBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBoxNome = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            labelId = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saborBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 32, 40);
            panel1.Controls.Add(dataGridViewDados);
            panel1.Controls.Add(buttonValores);
            panel1.Controls.Add(pictureBoxImagem);
            panel1.Controls.Add(listBoxTipo);
            panel1.Controls.Add(listBoxCategoria);
            panel1.Controls.Add(checkedListBoxIngredientes);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 537);
            panel1.TabIndex = 0;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AutoGenerateColumns = false;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, fotoDataGridViewImageColumn, categoriaDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn });
            dataGridViewDados.DataSource = saborBindingSource;
            dataGridViewDados.Location = new Point(641, 114);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(417, 323);
            dataGridViewDados.TabIndex = 18;
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
            // fotoDataGridViewImageColumn
            // 
            fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            fotoDataGridViewImageColumn.HeaderText = "Foto";
            fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // saborBindingSource
            // 
            saborBindingSource.DataSource = typeof(DAO.Sabor);
            // 
            // buttonValores
            // 
            buttonValores.BackColor = Color.FromArgb(212, 36, 51);
            buttonValores.BackgroundImageLayout = ImageLayout.None;
            buttonValores.FlatStyle = FlatStyle.Flat;
            buttonValores.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonValores.ForeColor = Color.FromArgb(23, 32, 40);
            buttonValores.Location = new Point(888, 486);
            buttonValores.Name = "buttonValores";
            buttonValores.Size = new Size(170, 39);
            buttonValores.TabIndex = 17;
            buttonValores.Text = "Salvar";
            buttonValores.UseVisualStyleBackColor = false;
            buttonValores.Click += buttonValores_Click;
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.Image = Properties.Resources.pizza;
            pictureBoxImagem.Location = new Point(33, 304);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(206, 202);
            pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagem.TabIndex = 16;
            pictureBoxImagem.TabStop = false;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(353, 114);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(139, 139);
            listBoxTipo.TabIndex = 15;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(208, 114);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(139, 139);
            listBoxCategoria.TabIndex = 14;
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Location = new Point(278, 304);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(139, 202);
            checkedListBoxIngredientes.TabIndex = 13;
            checkedListBoxIngredientes.SelectedIndexChanged += checkedListBoxIngredientes_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(212, 36, 51);
            label7.Location = new Point(371, 67);
            label7.Name = "label7";
            label7.Size = new Size(83, 45);
            label7.TabIndex = 9;
            label7.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(212, 36, 51);
            label6.Location = new Point(208, 67);
            label6.Name = "label6";
            label6.Size = new Size(157, 45);
            label6.TabIndex = 8;
            label6.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(212, 36, 51);
            label5.Location = new Point(88, 256);
            label5.Name = "label5";
            label5.Size = new Size(85, 45);
            label5.TabIndex = 7;
            label5.Text = "Foto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(212, 36, 51);
            label4.Location = new Point(244, 256);
            label4.Name = "label4";
            label4.Size = new Size(198, 45);
            label4.TabIndex = 5;
            label4.Text = "Ingredientes";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(78, 115);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(124, 23);
            textBoxNome.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(212, 36, 51);
            label3.Location = new Point(78, 67);
            label3.Name = "label3";
            label3.Size = new Size(108, 45);
            label3.TabIndex = 3;
            label3.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 23);
            textBox1.TabIndex = 2;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = Color.FromArgb(212, 36, 51);
            labelId.Location = new Point(12, 67);
            labelId.Name = "labelId";
            labelId.Size = new Size(51, 45);
            labelId.TabIndex = 1;
            labelId.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(212, 36, 51);
            label1.Location = new Point(332, 0);
            label1.Name = "label1";
            label1.Size = new Size(364, 51);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Sabores";
            label1.Click += label1_Click;
            // 
            // PaginaSabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 537);
            Controls.Add(panel1);
            Name = "PaginaSabores";
            Text = "Sabores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)saborBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBoxNome;
        private Label label3;
        private TextBox textBox1;
        private Label labelId;
        private Label label1;
        private CheckedListBox checkedListBoxIngredientes;
        private ListBox listBoxTipo;
        private ListBox listBoxCategoria;
        private PictureBox pictureBoxImagem;
        private Button buttonValores;
        private DataGridView dataGridViewDados;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewImageColumn fotoDataGridViewImageColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private BindingSource saborBindingSource;
    }
}