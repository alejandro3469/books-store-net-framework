using BooksStore.Business;
using BooksStore.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BooksStore
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetCategories();
            SendData();
        }

        public void GetCategories()
        {
            try
            {
                var genres = new BooksStoreBusiness().GetGenres();
                foreach (var genre in genres)
                {
                    CheckBox NewGenreCheckBox = new CheckBox
                    {
                        ID = $"Genre{genre.Id}",
                        Text = $"{genre.Name}"
                    };
                    divGenresContainer.Controls.Add(NewGenreCheckBox);
                }
            }
            catch (Exception ex)
            { 
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", string.Format("Error" + ex.Message, true));
            }
        }
        public void SendData()
        {
            try
            {
                var BooksStoreBusinessObject = new BooksStoreBusiness();
                var SelectedGenresList = new List<GenreModel>();

               
                var bookTitle = txtBookTitle.Text.ToString();
                var bookSynopsis = txtBookSynopsis.Text.ToString();
                var bookImage = txtBookImage.Text.ToString();

                BooksStoreBusinessObject.CreateBook(bookTitle, bookSynopsis, bookImage);

                var genresFullList = BooksStoreBusinessObject.GetGenres();

                foreach (var genre in genresFullList)
                {
                    CheckBox selectedGenreCheckbox = (CheckBox)divGenresContainer.FindControl($"Genre{genre.Id}");
                    if (selectedGenreCheckbox.Checked) {
                        SelectedGenresList.Add(genre);
                    }
                        
                }
            }
            catch (Exception ex)
            {
                var script = $"alert(Error: {ex.Message.Replace("'", "")})";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Error", script, true);
            }
        }

        protected void SendBookData_Click(object sender, EventArgs e)
        {
            SendData();
        }
    }
}