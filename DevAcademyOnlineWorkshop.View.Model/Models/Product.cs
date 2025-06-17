namespace DevAcademyOnlineShop.View.Model.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public double ProductPrice { get; set; }
        public int StockQuantity { get; set; }
        public string ProductCategory { get; set; } = string.Empty;


    }
}
