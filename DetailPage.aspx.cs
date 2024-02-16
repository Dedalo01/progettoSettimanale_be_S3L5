using System;

namespace progettoSettimanaleS3L5
{
    public partial class DetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int productId = int.Parse(Request.QueryString["id"]);

            TitleProduct.InnerText = GaeShopData.ProductList[productId].Name;
            ImageProduct.Src = GaeShopData.ProductList[productId].ImageUrl;
            DescriptionProduct.InnerText = GaeShopData.ProductList[productId].Description;
            PriceProduct.InnerText = GaeShopData.ProductList[productId].Price.ToString() + "€";

        }

        protected void AddToCartBtn_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(Request.QueryString["id"]);
            GaeShopData.ShoppingCart.Add(GaeShopData.ProductList[productId]);
        }
    }
}