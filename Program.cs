namespace ConsoleAppEfDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var connectingString = "Server=RYZ7ELPC\\SQLEXPRESS;Database=EfDemo; Trusted_Connection=True";
            using (var context = new EfDemoDbContext(connectingString))
            {
                var androidCollection = context.Products.Where(p => p.Name.StartsWith("Android"));
                foreach (var product in androidCollection)
                {
                    Console.WriteLine($"#{product.Id}:{product.Name}");
                }
            }
        }
    }
}
