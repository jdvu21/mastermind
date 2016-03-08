using System;

class Mastermind
{
    static void Main (string[] args)
    {
    	int chances = 0;

    	if (args[0] == null) 
    	{
    		Console.WriteLine("You did not declare number of trys. Please do so now:");
    		Console.ReadLine();
    	}
    	else
    		chances = Convert.ToInt32(args[0]);
    		
    	Console.WriteLine("You have {0} attempts", chances);
    }
}