﻿namespace WFCadastroProduto
{
    partial class formListaProduto
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
            dgvListaProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaProdutos
            // 
            dgvListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProdutos.Dock = DockStyle.Fill;
            dgvListaProdutos.Location = new Point(0, 0);
            dgvListaProdutos.Name = "dgvListaProdutos";
            dgvListaProdutos.Size = new Size(566, 252);
            dgvListaProdutos.TabIndex = 0;
            // 
            // formListaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 252);
            Controls.Add(dgvListaProdutos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formListaProduto";
            Text = "Lista de Produto";
            Load += formListaProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaProdutos;
    }
}