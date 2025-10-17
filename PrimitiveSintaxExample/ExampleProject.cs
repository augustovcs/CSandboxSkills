namespace CSandboxSkills.PrimitiveSintaxExample;

/*
    Inventory management system

    To complete this challenge, you will need to create a console application
    where users can manage product stock.

    Users should be able to add new products, update stock, and remove products.
    Some key features include:

    Add new products with name, price, and stock quantity.
    Update stock when products are sold or restocked.
    View all products and their stock levels.
    Remove products from inventory.

    */



public class PrimitiveSintaxExample
{

    public string prod_name;
    public string prod_price;
    public string prod_stock;
    public string full_inputProduct;
    public string update_input;


    public List<List<string>> inputProducts = new List<List<string>>();
    
    public void ConsoleStarter()
    {

        while(true)
        {
            Console.Clear();
            Console.WriteLine(" Choose a option:  ");
            Console.WriteLine("1. Add products");
            Console.WriteLine("2. Remove products");
            Console.WriteLine("3. Update products");
            Console.WriteLine("4. List all products");
            Console.WriteLine("5. Exit");

            var first_input = Console.ReadLine();

            
            switch (first_input)
            {
                case "1":
                    Console.WriteLine("Enter product name: ");
                    prod_name = Console.ReadLine();

                    Console.WriteLine("Enter price: ");
                    prod_price = Console.ReadLine();

                    Console.WriteLine("Enter quantity: ");
                    prod_stock = Console.ReadLine();

                    inputProducts.Add(new List<string>() { prod_name, prod_price, prod_stock });
                    break;

                case "2":
                    Console.WriteLine("Removing products... ");
                    inputProducts.RemoveAll(x => x.Contains(prod_name));
                    break;

                case "3":
                    Console.WriteLine("what product you want update the stock? ");
                    update_input = Console.ReadLine();

                    var found_product = inputProducts.FirstOrDefault(x => x.Contains(update_input));
                    if (found_product != null)
                    {
                        Console.WriteLine("How much u wanna increase the stock? ");
                        prod_stock = Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("That product is already this stock level! .");
                    }

                    break;

                case "4":
                    Console.WriteLine("Listing all products...");
                    foreach (var prod in inputProducts)
                    {
                        foreach (var item in prod)
                        {
                            Console.WriteLine(item);
                        }
                    }

                    break;

            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
        

        
    }

    
    
}