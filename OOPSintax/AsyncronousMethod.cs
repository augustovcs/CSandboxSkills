namespace CSandboxSkills.AsyncronousMethod;

public class AsyncronousMethod
{

    public async Task Run()
    {
        Console.WriteLine("Starting...");
        
        var awaiter = Task.Delay(5000);
        awaiter.Wait();
        
        Console.WriteLine("Done");
        
    }
    
    
}