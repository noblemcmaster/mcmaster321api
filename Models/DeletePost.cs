using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;
using api.Models.Interfaces;

namespace api.Models
{
    public class DeletePost : IDeletePost
    {
        public void DeletePosts(int id)
        {
            ConnectionString myCon = new ConnectionString();
            string cs = myCon.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            string stm = "DELETE FROM posts WHERE id = @id";
            using var cmd = new MySqlCommand(stm, con);

            cmd.CommandText = "DELETE FROM posts WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}