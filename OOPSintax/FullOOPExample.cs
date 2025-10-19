namespace CSandboxSkills.OOPSintax;

public interface NeedToSay
{
    public void Say();
}


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

public class Cat : Animal,  NeedToSay
{

    public override void WoofOrMeow()
    {
        Console.WriteLine("Meoow - I'm a cat");
    }

    public void Say()
    {
        Console.WriteLine("Now, i'm saying this shitttt wtf cats cant say ");
        
    }
    
} 

// Props and objects

public class Usernames
{
    public string Name { get; set; }
    public string Surname { get; set; }
    
}

public class User
{
    public void User01()
    {
        Usernames user01 = new Usernames();
        user01.Name = "John";
        user01.Surname = "Doe";
        
        Console.WriteLine(user01.Name + " " + user01.Surname);
    }
    
}