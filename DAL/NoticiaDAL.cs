using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class NoticiaDAL
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDSistemaWebAula3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public void InserirNoticia(Noticia noticia)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Noticias VALUES (@titulo, @data, @texto)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@titulo", noticia.Titulo);
            cmd.Parameters.AddWithValue("@data", noticia.DataPublicacao);
            cmd.Parameters.AddWithValue("@texto", noticia.Texto);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void ExcluirNoticia(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            //Para fazer um delete no BD
            string sql = "DELETE FROM Noticias WHERE Codigo = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();


        }
        public void AtualizarNoticia(Noticia noticia)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Noticias SET Titulo = @titulo, DataPublicacao = @data, Texto = @texto WHERE Codigo = @cod";
            //string sql = "UPDATE Produtoss SET Descricao = @desc, ValorUnitario = @unit, PesoKG = @peso WHERE Codigo = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", noticia.Codigo);
            cmd.Parameters.AddWithValue("@titulo", noticia.Titulo);
            cmd.Parameters.AddWithValue("@data", noticia.DataPublicacao);
            cmd.Parameters.AddWithValue("@texto", noticia.Texto);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
