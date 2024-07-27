using BooksStore.Data;
using System;
using System.Collections.Generic;
using BooksStore.Business.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BooksStore.Business
{
    public class BooksStoreBusiness
    {
        public List<GenreModel> GetGenres()
        {
            try
            {
                var booksStoreDataObject = new BooksStoreData();
                var GenresDataTable = booksStoreDataObject.GetGenres();

                var categories = new List<GenreModel>();

                foreach (DataRow item in GenresDataTable.Rows)
                {
                    var category = new GenreModel()
                    {
                        Id = Convert.ToInt32(item["cat_genres_id"]),
                        Name = item["cat_genre_name"].ToString(),
                    };
                        
                    categories.Add(category);
                }

                return categories;
            }
            catch (ApplicationException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error to add dish: {ex.Message}");
            }
        }
    }
}
