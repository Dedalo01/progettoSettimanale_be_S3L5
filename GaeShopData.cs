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
        new Item("HANDICORN", "HAI MAI DESIDERATO CHE LA TUA MANO DIVENTASSE UN UNICORNO?? ORBENE DA ORA POTRAI VANTARTI ACQUISTANDO QUESTO ESCLUSIVO SET 'HANDICORN' CHE ASPETTI? NON FARE IL PAZZO E COMPRA ANCHE TU 'HANDICORN', UNISCITI ALLA MANDRIA!", 130, "https://i.ebayimg.com/images/g/MooAAOSweExjk1Xw/s-l1600.jpg"),
        new Item("Pesciabatte", "Ti sei sempre sentito un pesce fuor d'acqua? TORNA NEL TUO ELEMENTO NATURALE CON QUESTE IMPERDIBILI 'PESCIABATTE'!!!", 56.99, "https://media-assets.vanityfair.it/photos/61e564cd1e21bc3bd54b5487/master/w_1600%2Cc_limit/Schermata%25202022-01-17%2520alle%252013.44.37.png"),
        new Item("T-STAPPA-REX-TIGLIA", "I tuoi familiari e amici ti giudicano perchè apri le birre solo coi denti? ORA NON PIU'! Compra questo incredibile stappabottiglie e mostra a tutti chi è il re della giungla!", 25.01, "https://www.coolboxstore.com//media/catalog/product/a/p/apribottiglia_3.jpg"),
        new Item("Scarpe con Taccherelli©", "Vorresti indossare tacchi, ma dove abiti piove sempre nemmeno ti trovassi in una tempesta tropicale? ORA PUOI: Indossa anche tu le uniche Scarpe con Taccherelli© e vaga disinvolta per la città durante il diluvio universale!", 97.21, "https://newblogfr.s3.eu-west-1.amazonaws.com/blog/wp-content/uploads/2014/05/13180516/ombrellini_scarpe-2.jpg"),
        new Item("NoPhone Air", "Ciao! Sono Gianpierluigi Parsival, tutti mi dicevano che stavo troppo attaccato al cellulare, così ho inventato questo incredibile dispositivo sempre pronto all'uso! Non mi credi? Compralo anche tu e prova l'ebbrezza di un tenere in mano un cellulare leggerissimo. Ti invidieranno tutti!", 875.99, "https://www.dottorgadget.it/news/wp-content/uploads/2020/02/nophone-air.jpg"),
        new Item("NOTHING", "Lo so... hai una incredibile voglia di comprare cose... c'è solo un problemino: HAI GIA' TUTTO! E allora non preoccuparti perchè per persone proprio come te abbiamo qui in esclusiva il nuovo NOTHING: Compralo e vivi una nuova esperienza OGGI!", 2381.89, "https://hips.hearstapps.com/cit.h-cdn.co/assets/17/05/768x1022/niente-per-chi-ha-gia-tutto.jpg"),


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