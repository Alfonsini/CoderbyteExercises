namespace Power_Of_Two;
public class Solution
{

    
    // 1 2 4 8 16

    public static bool PowersofTwo(int num)
    {
        int power_number = 1;

        while (power_number < num)
        {
            power_number *= 2;
        }

        // code goes here  
        return power_number == num;

    }
}
