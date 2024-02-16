using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace progettoSettimanaleS3L5
{
    public partial class ShoppingCartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (GaeShopData.ShoppingCart.Count == 0)
            {
                isEmpty.Visible = true;

            }
            else if (!IsPostBack)
            {
                isEmpty.Visible = false;
                BindCartRepeater();
            }
        }

        protected void RemoveItemBtn_Click(int index)
        {
            GaeShopData.ShoppingCart.RemoveAt(index);

        }

        private void BindCartRepeater()
        {
            // Assegna la lista come origine dati per il Repeater
            CartRepeater.DataSource = GaeShopData.ShoppingCart;
            CartRepeater.DataBind();
        }

        protected void CartRepeaterCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "RemoveFromCart")
            {
                // Esempio di come gestire la rimozione di un articolo dal carrello
                int productId = Convert.ToInt32(e.CommandArgument);

                // Rimuovi l'articolo dal carrello
                RemoveItemFromCart(productId);

                // Aggiorna il Repeater dopo la rimozione
                BindCartRepeater();
            }
        }

        private void RemoveItemFromCart(int productId)
        {
            Item itemToRemove = GaeShopData.ShoppingCart.FirstOrDefault(item => item.ProductId == productId);
            if (itemToRemove != null)
            {
                GaeShopData.ShoppingCart.Remove(itemToRemove);
            }
        }
    }
}