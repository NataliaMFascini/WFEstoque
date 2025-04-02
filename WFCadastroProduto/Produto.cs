using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    public enum EStatus
    {
        Ativo = 1,
        Inativo = 0
    }

    public class Produto
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public EStatus Status { get; set; }

        public static List<Produto> ListaProdutos = new List<Produto>();

        public bool Cadastrar()
        {
            int afetados = 0;
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=bdProduto;Uid=root;Pwd="))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO Produto (Id, Nome, Quantidade, Preco, Status) ");
                sql.Append("VALUES (@Id, @Nome, @Quantidade, @Preco, @Status);");

                MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@Preco", Preco);
                cmd.Parameters.AddWithValue("@Status", Status.ToString());

                conn.Open();
                afetados = cmd.ExecuteNonQuery();
            }

            return (afetados > 0);
        }
    }
}
