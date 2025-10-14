namespace CSandboxSkills.Sandbox01;

public class Sandbox01
{
    public void IfElseMethod()
    {

        bool isResident = false;
        var tax_rate = 0.00;
        
        Console.WriteLine("How much u earn?");
        double income = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("R u resident??(y/n)");
        var resident = Console.ReadLine();
        
        isResident = resident == "y";
        
        if (income < 50000)
        {
            if (isResident)
            {
                tax_rate = 0.10;
            }
            else
            {
                tax_rate = 0.15;
            }
        }
        else if (income >= 50000 || income <= 99999)
        {
            if (isResident)
            {
                tax_rate = 0.20;
            }
            else
            {
                tax_rate = 0.25;
            }
        }
        else
        {
            if (isResident)
            {
                tax_rate = 0.30;
            }
            else
            {
                tax_rate = 0.35;
            }
        }
        
        Console.WriteLine($"The tax rate is {tax_rate}");
    
    }
}