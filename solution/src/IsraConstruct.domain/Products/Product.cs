namespace IsraConstruct.domain.Products
{

    public class Product
    {
        public Product()
        {
        }

        public Product(int id, string name, decimal price, int stockQuantity)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.StockQuantity = stockQuantity;

        }
    
        public int Id { get; private set; }

        public string Name { get; private set; }
        public Category Category { get; private set; }

        public decimal Price { get; private set; }

        public int StockQuantity { get; private set; }

        public Product(string name, Category category, decimal price, int stockQuantity)
        {
            Validate(name, category, price, stockQuantity);
            SetProperties(name, category, price, stockQuantity);
        }

        public void Update(string name, Category category, decimal price, int stockQuantity){
            Validate(name, category, price, stockQuantity);
            SetProperties(name, category, price, stockQuantity);
        }

        private void SetProperties(string name, Category category, decimal price, int stockQuantity)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQuantity;
        }

        private static void Validate(string name, Category category, decimal price, int stockQuantity)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            DomainException.When(category == null, "Category is required");
            DomainException.When(price < 0, "Price must be greater than 0");
            DomainException.When(stockQuantity < 0, "Stock must be greater 0");
        }
    }
}