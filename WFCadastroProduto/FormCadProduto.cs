using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormCadProduto : Form
    {
        public FormCadProduto()
        {
            InitializeComponent();
        }
        private void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool NaoPreenchido()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                return true;
            }
            if (rdbAtivo.Checked == false && rdbInativo.Checked == false)
            {
                return true;
            }
            if (nudPreco.Value <= 0)
            {
                return true;
            }
            if (nudQuantidade.Value <= 0)
            {
                return true;
            }

            return false;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (NaoPreenchido() == true)
            {
                Erro("Campos obrigatórios não preenchidos corretamente.");
                return;
            }

            //começo a cadastrar o produto
            Produto prod = new Produto();
            prod.Id = long.Parse(mskCodigo.Text);
            prod.Nome = txtNome.Text;
            prod.Preco = nudPreco.Value;
            prod.Quantidade = (int)nudQuantidade.Value;
            prod.Status = rdbAtivo.Checked ? EStatus.Ativo : EStatus.Inativo;//se estiver ativo? deixa ativo, se não inativo (ternario)

            Produto.ListaProdutos.Add(prod);

            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();

            formListaProduto form = new formListaProduto();
            form.ShowDialog();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            nudPreco.Value = 0;
            nudQuantidade.Value = 0;
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;

            int totalLista = Produto.ListaProdutos.Count;
            int novoCodigo = totalLista + 1;

            mskCodigo.Text = novoCodigo.ToString("D4"); // D4 = 4 dígitos
        }

        private void FormCadProduto_Load(object sender, EventArgs e)
        {
            int totalLista = Produto.ListaProdutos.Count;
            int novoCodigo = totalLista + 1;

            mskCodigo.Text = novoCodigo.ToString("D4"); // D4 = 4 dígitos
        }

    }
}
