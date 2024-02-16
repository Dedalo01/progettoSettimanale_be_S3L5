using System;
using System.Collections.Generic;

namespace progettoSettimanaleS3L5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Item> listaProdotti = GaeShopData.ProductList;

            string innerRow = "";
            foreach (Item item in listaProdotti)
            {
                innerRow += $@"<div class=""col col-md-3 col-sm-6 col-12 mb-4"">
                    <div class=""card h-100"">
                        <img class=""card-img-top"" src=""{item.ImageUrl}"" alt=""{item.Name}"">
                            <div class=""card-body d-flex flex-column justify-content-end"">
                                <h5 class=""card-title"">{item.Name}</h5>
                                    <p class=""card-text"">{item.Price}€</p>
                                    <a href=""DetailPage.aspx?id={item.ProductId}"" class=""btn btn-success"">Guarda Dettagli</a>
                            </div>
                    </div>
                </div>";
            }

            CardContainer.InnerHtml = innerRow;
        }
    }
}