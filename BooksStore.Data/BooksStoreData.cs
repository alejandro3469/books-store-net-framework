using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStore.Data
{
    public class BooksStoreData
    {
        private readonly string ConnectionString;
        public BooksStoreData()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
        public DataTable GetGenres()
        {
            try
            {
                var connection = new SqlConnection(ConnectionString);
                var command = new SqlCommand("spGetGenres", connection);
                command.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(command);
                var ds = new DataSet();
                da.Fill(ds);

                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error to get genres: {ex.Message}");
            }
        }
        public void CreateBook(string bookName, string bookSynopsis, string bookImage)
        {
            try
            {
                var connection = new SqlConnection(ConnectionString);
                var command = new SqlCommand("spCreateBook", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter() { ParameterName = "book_name", DbType = DbType.String, Value = bookName });
                command.Parameters.Add(new SqlParameter() { ParameterName = "book_synopsis", DbType = DbType.String, Value = bookSynopsis });
                command.Parameters.Add(new SqlParameter() { ParameterName = "book_image", DbType = DbType.String, Value = bookImage });

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                var script = $"alert('The book {bookName} was added successfully')";
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error to add book, id: : {ex.Message}");
            }
        }
    }
}