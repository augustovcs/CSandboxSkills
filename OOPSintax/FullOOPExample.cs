namespace CSandboxSkills.OOPSintax;

public class Animal
{

    public virtual void WoofOrMeow()
    {
        Console.WriteLine("Woof or Meow??");
    }
    
}

public class Dog : Animal
{

    public void Woof()
    {
        Console.WriteLine("Woof! - I'm a dog");
    }
    

}

public class Cat : Animal
{

    public override void WoofOrMeow()
    {
        Console.WriteLine("Meoow - I'm a cat");
    }
    
} 