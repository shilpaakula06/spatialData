// See https://aka.ms/new-console-template for more information
using System.Data.Entity;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World!");

        using (var context = new SpatialData.EfDbContext())
        {
            var Item = new SpatialData.Item()
            {
                Name = "Ron Palido",
                Description = "Drink",
                Expiration = DateTime.Now.AddYears(1)

            };
            Console.WriteLine($"Item NOT saved -> Id {Item.id} {Item.Name} {Item.Expiration}");

            //context.Add(Item);
            context.SaveChanges();

            Console.WriteLine($"Item saved -> Id {Item.id} {Item.Name} {Item.Expiration}");
            Console.ReadKey();
        }
    }
}