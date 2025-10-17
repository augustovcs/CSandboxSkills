namespace CSandboxSkills.FunctionsMethods;

//This would be the learning way to functions or methods in c#

public class FunctionsMethods
{
    public int MultipliesTwoNumbers(int x, int y)
    {
        return x * y;
    }

    public decimal DiscountTwoNumbers(int x, int y)
    {
        decimal converting = y / 100m;
        var discount_num = x * converting;
        
        return discount_num;
        
    }
    
    
}