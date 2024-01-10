

namespace CSharpDay2Assignment
{
    internal class Product
    {
        readonly int pcode;
        public string? pname;
        public int qty_in_stock;
        public double discount_allowed;
        static string brand;
        public double price;

        public Product()
        {
            Console.WriteLine("Enter Pcode");
            this.pcode = Convert.ToInt32(Console.ReadLine());
        }

        static Product() {
            brand = "Lewis";
        }

        public void Getdetails()
        {
            Console.WriteLine("Enter PName");
            this.pname = Console.ReadLine();
            Console.WriteLine("Enter Price");
            this.price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Qty in stocks");
            this.qty_in_stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Discount Allowed");
            this.discount_allowed = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Pcode is : {this.pcode}");
            Console.WriteLine($"PName is : {this.pname}");
            Console.WriteLine($"Brand is : {brand}");
            Console.WriteLine($"Price is : {this.price}");
            Console.WriteLine($"Qauntity in stock is : {this.qty_in_stock}");
            Console.WriteLine($"Discount Allowed is : {this.discount_allowed}" );
        }
    }
}
