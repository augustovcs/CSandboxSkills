namespace CSandboxSkills.LibraryManagement;

public class MainLibrary
{
    private List<string> books = new List<string>
        { "Vampires", "Midnight", "Rocinha", "Twilight", "Cidade de Deus", "Tropa de Elite" };

    private List<string> reserved_books = new List<string>();

    public void ConsoleRun()
    {
        Console.WriteLine("LIBRAY MANAGEMENT:");

        while (true)
        {
            Console.WriteLine("Text a book you want to find: ");
            var inputBook = Console.ReadLine();
            if (!books.Contains(inputBook))
            {
                Console.Clear();
                Console.WriteLine("Book not found");
            }
            else
            {
                Console.WriteLine($"{inputBook} was found here! do you wanna borrow? y/n ");
                var optionChoice = Console.ReadLine();
                if (optionChoice == "y")
                {
                    
                    if (books.Contains(inputBook))
                    {
                        books.Remove(inputBook);
                        if (!BorrowLimit(reserved_books))
                        {
                            break;
                        }
                        reserved_books.Add(inputBook);

                        Console.WriteLine("\n📚 Books available:");
                        foreach (var item in books)
                            Console.WriteLine($"- {item}");

                        Console.WriteLine("\n📕 Reserved books:");
                        foreach (var item in reserved_books)
                            Console.WriteLine($"- {item}");
                    }
            
                }
                else
                {
                    break;
                }
            }
            
        }
    }

    public bool BorrowLimit(List<string> books)
    {
        if (books.Count >= 3)
        {
            Console.WriteLine("You reached the limit of 3 books!");
            return false;
        }

        return true;

    }
    
    
}