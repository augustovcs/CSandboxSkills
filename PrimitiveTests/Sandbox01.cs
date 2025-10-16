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
    
    public void SwitchAdvancedMethod()
    {
        var interest_rate = 0.00;
        var monthlyFee = 0.00;
        
        Console.WriteLine("What account u wanna open? \n (saving/checking/business/free) ");
        var account = Console.ReadLine();

        var income = 0.00;
        
        if (account == "business")
        {
            Console.WriteLine("How much u earn?");
            income = Convert.ToDouble(Console.ReadLine());
        }
        
        switch (account)
        {
            case "saving":
                interest_rate = 0.00;
                monthlyFee = 0.00;
                Console.WriteLine($"IR: {interest_rate} and MF: {monthlyFee}");
                break;
            case "checking":
                interest_rate = 0.45;
                monthlyFee = 0.15;
                Console.WriteLine($"IR: {interest_rate} and MF: {monthlyFee}");
                break;
            case "business":
                if (income > 50000)
                {
                    interest_rate = 0.15;
                    monthlyFee = 0.80;
                    Console.WriteLine($"IR: {interest_rate} and MF: {monthlyFee}");

                }
                else
                {
                    interest_rate = 0.20;
                    monthlyFee = 1.00;
                    Console.WriteLine($"IR: {interest_rate} and MF: {monthlyFee}");
                }
                break;
            case "free":
                interest_rate = 1.25;
                monthlyFee = 0.00;
                Console.WriteLine($"IR: {interest_rate} and MF: {monthlyFee}");
                break;
            default:
                Console.WriteLine("Invalid type! choose correctly please??");
                break;
        }
    }

    public void ControlStructuresLoops()
    {
        do
        {
            Console.WriteLine("Write a number between 0 and 10");
            var input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case < 5:
                    Console.WriteLine("less than 5");
                    break;
                case > 5:
                    Console.WriteLine("more than 5");
                    break;
            }
        } while (true);

    }

    public void ForControlStructure()
    {
        var number = 0;
        for (int i = 0; i < 10; i++)
        { 
            number += 1;
            Console.WriteLine(number);
            switch (number)
            {
                case 1:
                    Console.WriteLine("zero - starting");
                    break;
                case 5:
                    Console.WriteLine("middle of the loop");
                    break;
                case 10:
                    Console.WriteLine("the end!!");
                    break;
            }
            
        }
            
    }
}