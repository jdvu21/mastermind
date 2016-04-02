/* 
   This is a C# program that can be compiled using:
   csc (windows, c sharp compiler)
   msc (OSX, mono compiler)
*/


using System;

class Mastermind
{
    static void Main (string[] args)
    {
    	int chances;
    	int len = 4;
        string masterCode = "";

    	if (args.Length == 0) 
    	{
    		Console.WriteLine("You did not declare number of guesses. Please do so now:");
    		chances = Convert.ToInt16(Console.ReadLine());
    	}
    	else
    		chances = Convert.ToInt16(args[0]);

    	Random roll = new Random();
    	for (int i = 0; masterCode.Length < len; ++i)
    	{
            string t = Convert.ToString(roll.Next(1,7));
            if (!masterCode.Contains(t))
                masterCode += t;
    	}

        // Console.WriteLine("{0}", masterCode);

    while (chances != 0) {
        Console.WriteLine("You have {0} guesses remaining.", chances);
        Console.WriteLine("Please enter your guess:");
        string currentGuess = Convert.ToString(Console.ReadLine());

        int temp;
        while(!Int32.TryParse(currentGuess, out temp) || currentGuess.Length != len) {
            Console.WriteLine("Input rejected. Please enter {0} integers.", len);
            currentGuess = Console.ReadLine();
        }

        if (masterCode[0] == currentGuess[0] &&
            masterCode[1] == currentGuess[1] &&
            masterCode[2] == currentGuess[2] &&
            masterCode[3] == currentGuess[3]) {
            Console.WriteLine("You solved it!");
            System.Environment.Exit(1); 
        }

        else {
            int correctGuess = 0;
            int almostRight = 0;

            for (int i = 0; i < masterCode.Length; ++i) {
                if (masterCode[i] == currentGuess[i]) {
                    ++correctGuess;
                }
                else {
                    string s = Convert.ToString(masterCode[i]);
                    if (currentGuess.Contains(s)) {
                        ++almostRight;
                    }
                }
            }

            for (int i = 0; i < correctGuess; ++i) {
                Console.Write("+");
            }
            for (int i = 0; i < almostRight; ++i) {
                Console.Write("-");
            }
            Console.WriteLine();
            
            chances--;
            }
        }
        Console.WriteLine("You lose :(");
        Console.WriteLine("The mastercode was: {0}", masterCode);
    }    
}