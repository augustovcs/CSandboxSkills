namespace CSandboxSkills.AsyncronousMethod;

public class AsyncronousMethod
{

    public async Task MethodRun()
    {
        Console.WriteLine("Starting...");
        await Task.Delay(5000);
        Console.WriteLine("Done");
        
    }


    public async Task Running()
    {
        Console.WriteLine("Starting the Running method...");
        
        //Lambda func to execute -> block threads and risk of deadlocks
        Task.Run(async () => await MethodRun()).Wait();
        
        //Another option -> respect async, most common use
        await MethodRun();
        
        Console.WriteLine("Done");



    }
    
    
}