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
    public partial class formListaProduto : Form
    {
        public formListaProduto()
        {
            InitializeComponent();
        }

        private void formListaProduto_Load(object sender, EventArgs e)
        {
            dgvListaProdutos.DataSource = Produto.ListaProdutos;
        }
    }
}
