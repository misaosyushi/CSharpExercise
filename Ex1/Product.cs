namespace Ex1
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(int code, string name, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        public int GetTax()
        {
            return (int) (Price * 0.08);
        }

        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }
}