namespace BuilderPattern.Product
{
    public class Order
    {
        public List<string> Products { get; set; } = new List<string>();
        public List<int> Quantities { get; set; } = new List<int> { 0 };
        public string DeliveryAddress { get; set; }
        public bool IsPaid { get; set; }



        public void Display()
        {
            Console.WriteLine("Order Details:");

            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"Product: {Products[i]}, Quantity: {Quantities[i]}");
            }

            Console.WriteLine("Delivery Address: " + DeliveryAddress);
            Console.WriteLine("Payment Status: " + (IsPaid ? "Paid" : "Not Paid"));
        }

    }
}
