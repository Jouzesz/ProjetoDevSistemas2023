namespace PizzariaDoZe
{
    partial class PaginaPedidos
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
            checkedListBoxProduto = new CheckedListBox();
            label5 = new Label();
            checkedListBoxSabores = new CheckedListBox();
            comboBoxTamanhoPizza = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            saborBindingSource = new BindingSource(components);
            ingredienteBindingSource = new BindingSource(components);
            checkedListBox1 = new CheckedListBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saborBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 32, 40);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(checkedListBoxProduto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(checkedListBoxSabores);
            panel1.Controls.Add(comboBoxTamanhoPizza);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1272, 625);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // checkedListBoxProduto
            // 
            checkedListBoxProduto.FormattingEnabled = true;
            checkedListBoxProduto.Location = new Point(330, 116);
            checkedListBoxProduto.Name = "checkedListBoxProduto";
            checkedListBoxProduto.Size = new Size(249, 130);
            checkedListBoxProduto.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(212, 36, 51);
            label5.Location = new Point(317, 68);
            label5.Name = "label5";
            label5.Size = new Size(282, 45);
            label5.TabIndex = 11;
            label5.Text = "Bebidas (opcional)";
            // 
            // checkedListBoxSabores
            // 
            checkedListBoxSabores.FormattingEnabled = true;
            checkedListBoxSabores.Location = new Point(13, 273);
            checkedListBoxSabores.Name = "checkedListBoxSabores";
            checkedListBoxSabores.Size = new Size(120, 94);
            checkedListBoxSabores.TabIndex = 10;
            checkedListBoxSabores.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // comboBoxTamanhoPizza
            // 
            comboBoxTamanhoPizza.FormattingEnabled = true;
            comboBoxTamanhoPizza.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxTamanhoPizza.Location = new Point(12, 199);
            comboBoxTamanhoPizza.Name = "comboBoxTamanhoPizza";
            comboBoxTamanhoPizza.Size = new Size(121, 23);
            comboBoxTamanhoPizza.TabIndex = 8;
            comboBoxTamanhoPizza.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(212, 36, 51);
            label4.Location = new Point(0, 225);
            label4.Name = "label4";
            label4.Size = new Size(133, 45);
            label4.TabIndex = 7;
            label4.Text = "Sabores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(212, 36, 51);
            label3.Location = new Point(0, 151);
            label3.Name = "label3";
            label3.Size = new Size(272, 45);
            label3.TabIndex = 5;
            label3.Text = "Tamanho da pizza";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(212, 36, 51);
            label1.Location = new Point(0, 68);
            label1.Name = "label1";
            label1.Size = new Size(254, 45);
            label1.TabIndex = 3;
            label1.Text = "ID pedido (auto)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(212, 36, 51);
            label2.Location = new Point(596, 9);
            label2.Name = "label2";
            label2.Size = new Size(133, 45);
            label2.TabIndex = 2;
            label2.Text = "Pedidos";
            // 
            // saborBindingSource
            // 
            saborBindingSource.DataSource = typeof(DAO.Sabor);
            // 
            // ingredienteBindingSource
            // 
            ingredienteBindingSource.DataSource = typeof(DAO.Ingrediente);
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(152, 273);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(212, 36, 51);
            label6.Location = new Point(570, 290);
            label6.Name = "label6";
            label6.Size = new Size(133, 45);
            label6.TabIndex = 14;
            label6.Text = "Sabores";
            // 
            // PaginaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 625);
            Controls.Add(panel1);
            Name = "PaginaPedidos";
            Text = "Form9";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)saborBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredienteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private BindingSource saborBindingSource;
        private BindingSource ingredienteBindingSource;
        private ComboBox comboBoxTamanhoPizza;
        private CheckedListBox checkedListBoxSabores;
        private Label label5;
        private CheckedListBox checkedListBoxProduto;
        private Label label6;
        private CheckedListBox checkedListBox1;
    }
}