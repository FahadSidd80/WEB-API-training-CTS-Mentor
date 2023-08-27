namespace di_cors_api_demo.Models
{
    public class ProductList
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }


        static List<ProductList> pList = new List<ProductList>()
        {
            new ProductList(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductList(){ pId=102, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductList(){ pId=103, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductList(){ pId=104, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductList(){ pId=105, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductList(){ pId=106, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductList(){ pId=107, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductList(){ pId=108, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductList(){ pId=109, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductList(){ pId=110, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductList(){ pId=111, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
        };



        public List<ProductList> GetProducts()
        {
            return pList;
        }
        
    }
}
