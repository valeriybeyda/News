using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using News.Entity;
using System.Data.OleDb;
namespace News.Repositories
{
    public class SqlNewsRepository : INewsRepository
    {
        public static List<NewsEntity> _sqlRepository = new List<NewsEntity>();
        private string _connectionString;
        private const string sqlSelect =
                             "SELECT [dbo].[tblMainNews].[Id], [dbo].[tblMainNews].[Title], [dbo].[tblMainNews].[Text]"
                           + "FROM [dbo].[tblMainNews]";

        //string connstring = "Data Source=localhost; Initial Catalog=dbNews; Persist Security Info=True;";

        public SqlNewsRepository(string _connectionString)
        {
            this._connectionString = _connectionString;
        }
            

        public List<NewsEntity> GetAll()
        {
            int counter = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlSelect, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                counter++;
                                NewsEntity ne = new NewsEntity((int)reader["Id"], (string)reader["Title"], (string)reader["Text"]);

                                _sqlRepository.Add(ne);
                            }
                        }
                    }
                }
                catch (SqlException se)
                {
                    NewsEntity ne = new NewsEntity(1, se.ToString(), "s");

                    _sqlRepository.Add(ne);
                }
            }
            return _sqlRepository;
        }
    }
}