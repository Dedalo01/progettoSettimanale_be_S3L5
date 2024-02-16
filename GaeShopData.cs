using System.Collections.Generic;

namespace progettoSettimanaleS3L5
{
    public static class GaeShopData
    {

        private static int _autoIncrement = 0;
        public static List<Item> ProductList { get; set; } = new List<Item>() {
        new Item("Shampoo Garnier", "Questo Shampo ti lascerà senza capelli!", 7.5, "https://www.alpiflora.it/wp-content/uploads/2019/03/3-SHAMPOO-200-fiori.jpg"),
        new Item("Parmigiano Reggiano", "Assapora questo incredibile Formaggio di 24 mesi.", 57, "https://shop.parmigianoreggiano.com/media/catalog/product/cache/ee73613d33f90407739af1d12fcd6974/3/k/3kg_02_5.png"),
        new Item("SpiderMan Bagnoschiuma", "Ripulisciti da ogni impurità con questo fantastico bagnoschiuma targato Marvel!", 10.16, "https://profumino.net/image/cache/slike/79416-1xbr7VrjAa_owldfqFqmog-375x375.jpg"),
        new Item("Chitarra Classica", "Senti che sound!!!", 100.32, "https://static.strumenti.net/product/750/2017/12/12/89/chitarra-classicastudent-1.jpg"),


        };
        public static List<Item> ShoppingCart { get; set; } = new List<Item>();

        public static int IncrementProductId()
        {
            _autoIncrement++;
            return _autoIncrement - 1;
        }
    }

    public class Item
    {
        private int _productId;
        private string _name;
        private string _description;
        private double _price;
        private string _imageUrl;
        public static List<Item> _items;

        public int ProductId { get { return _productId; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public double Price { get { return _price; } }
        public string ImageUrl { get { return _imageUrl; } }
        public Item(string name, string description, double price, string imageUrl)
        {
            _productId = GaeShopData.IncrementProductId();
            _name = name;
            _description = description;
            _price = price;
            _imageUrl = imageUrl;
        }
    }
}