namespace PizzariaDoZe
{
    partial class FormConfig
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
            comboBoxProvider = new ComboBox();
            label1 = new Label();
            textBoxStringDeConexao = new TextBox();
            ButtonSalvarBD = new Button();
            SuspendLayout();
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Items.AddRange(new object[] { "System.Data.SqlClient", "MySql.Data.MySqlClient" });
            comboBoxProvider.Location = new Point(295, 78);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(121, 23);
            comboBoxProvider.TabIndex = 0;
            comboBoxProvider.SelectedIndexChanged += comboBoxProvider_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 81);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "String de conexão";
            // 
            // textBoxStringDeConexao
            // 
            textBoxStringDeConexao.Location = new Point(295, 107);
            textBoxStringDeConexao.Name = "textBoxStringDeConexao";
            textBoxStringDeConexao.Size = new Size(100, 23);
            textBoxStringDeConexao.TabIndex = 2;
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
            ButtonSalvarBD.TabIndex = 7;
            ButtonSalvarBD.Text = "Salvar";
            ButtonSalvarBD.UseVisualStyleBackColor = false;
            ButtonSalvarBD.Click += ButtonSalvarBD_Click;
            // 
            // FormConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonSalvarBD);
            Controls.Add(textBoxStringDeConexao);
            Controls.Add(label1);
            Controls.Add(comboBoxProvider);
            Name = "FormConfig";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxProvider;
        private Label label1;
        private TextBox textBoxStringDeConexao;
        private Button ButtonSalvarBD;
    }
}