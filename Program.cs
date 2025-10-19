using CSandboxSkills.PrimitiveLoops;
using CSandboxSkills.FunctionsMethods;
using CSandboxSkills.PrimitiveSintaxExample;
using CSandboxSkills.OOPSintax;
class Program
{

    static void Main(string[] args)
    {
        
        
        //PrimitiveLoops sandbox = new PrimitiveLoops();
        
        //FunctionsMethods sandbox = new FunctionsMethods();
        
        //PrimitiveSintaxExample sandbox = new PrimitiveSintaxExample();
        //sandbox.ConsoleStarter();

        Animal animalSoundOOP = new Animal();
        animalSoundOOP.WoofOrMeow();
        
        Dog dogSoundOOP = new Dog();
        dogSoundOOP.Woof();
        
        Cat catSoundOOP = new Cat();
        catSoundOOP.WoofOrMeow();
        catSoundOOP.Say();
        
        User user = new User();
        user.Info.Name =  "John";
        user.Info.Surname = "Doe";
        Console.WriteLine(user.Info.Name + " "  + user.Info.Surname);

        Usernames user02 = new Usernames();
        user02.Name = "Doe";
        user02.Surname = "John";
        
        Console.WriteLine(user02.Name + " " + user02.Surname);

    }    
    
}
