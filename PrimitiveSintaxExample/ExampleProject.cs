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


    public Dictionary<string, List<string>> listing_prod = new Dictionary<string, List<string>>();
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

                    Console.WriteLine("Enter stock status: ");
                    prod_stock = Console.ReadLine();

                    listing_prod[prod_name] = new List<string> { prod_price, prod_stock };


                    break;

                case "2":
                    Console.WriteLine("Choose a product: ");
                    var input = Console.ReadLine();


                    foreach (var item in listing_prod.Keys)
                    {
                        if (input == item)
                        {
                            listing_prod[input].Clear();
                            Console.WriteLine($"Cleaning {input}");
                            break;
                        }
                    }
                     
                    
                    break;

                case "3":
                    Console.WriteLine("what product you want update the stock? ");
                    update_input = Console.ReadLine();

                    if (listing_prod.ContainsKey(update_input))
                    {
                        Console.WriteLine("Enter the new stock value: ");
                        var new_stock = Console.ReadLine();
                        
                        listing_prod[update_input] = new List<string> { prod_price, new_stock };
                        
                    }
                    
                    
              
                    
                    break;

                case "4":
                    Console.WriteLine("Listing all products...");
                    foreach (var prod in listing_prod)
                    {
                        var key = prod.Key;
                        var val = prod.Value;
                        
                        Console.WriteLine(key);

                        foreach (var v in val)
                        {
                            Console.WriteLine(v);
                        }
                        
                    }

                    break;

            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
        
    }
    
}