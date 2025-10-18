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
        
    }    
    
}
