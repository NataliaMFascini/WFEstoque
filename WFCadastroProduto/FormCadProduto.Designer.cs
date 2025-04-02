namespace WFCadastroProduto
{
    partial class FormCadProduto
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
            lblCodigo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            gpbStatus = new GroupBox();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblPreco = new Label();
            nudPreco = new NumericUpDown();
            nudQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            btnCadastrar = new Button();
            mskCodigo = new MaskedTextBox();
            gpbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 12);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 79);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 97);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(246, 23);
            txtNome.TabIndex = 2;
            // 
            // gpbStatus
            // 
            gpbStatus.Controls.Add(rdbInativo);
            gpbStatus.Controls.Add(rdbAtivo);
            gpbStatus.Location = new Point(178, 12);
            gpbStatus.Name = "gpbStatus";
            gpbStatus.Size = new Size(80, 79);
            gpbStatus.TabIndex = 4;
            gpbStatus.TabStop = false;
            gpbStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(6, 47);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(6, 22);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(12, 123);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(81, 15);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço unitário";
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Location = new Point(12, 141);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(120, 23);
            nudPreco.TabIndex = 6;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(138, 141);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 23);
            nudQuantidade.TabIndex = 8;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(138, 123);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(183, 170);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // mskCodigo
            // 
            mskCodigo.Enabled = false;
            mskCodigo.Location = new Point(12, 30);
            mskCodigo.Mask = "0000";
            mskCodigo.Name = "mskCodigo";
            mskCodigo.Size = new Size(49, 23);
            mskCodigo.TabIndex = 10;
            mskCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // FormCadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 204);
            Controls.Add(mskCodigo);
            Controls.Add(btnCadastrar);
            Controls.Add(nudQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(nudPreco);
            Controls.Add(lblPreco);
            Controls.Add(gpbStatus);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de produto";
            Load += FormCadProduto_Load;
            gpbStatus.ResumeLayout(false);
            gpbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private GroupBox gpbStatus;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblPreco;
        private NumericUpDown nudPreco;
        private NumericUpDown nudQuantidade;
        private Label lblQuantidade;
        private Button btnCadastrar;
        private MaskedTextBox mskCodigo;
    }
}