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
                var categories = new List<GenreModel>();

                var genres = BooksStoreBusinessObject.GetGenres();

                foreach (var genre in genres)
                {
                    CheckBox selectedGenreCheckbox = (CheckBox)divGenresContainer.FindControl($"Genre{genre.Id}");
                    if (selectedGenreCheckbox.Checked) {

                        var SelectedGenreId = genre.Id;
                    }
                        
                }
            }
            catch (Exception ex)
            {
                var script = $"alert(Error: {ex.Message.Replace("'", "")})";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Error", script, true);
            }
        }
    }
}