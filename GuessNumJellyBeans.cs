using System;
/*GuessNumJellyBeans takes an array of ints representing guesses at the number of jelly beans contained in a jar, then based solely on the list
 * of guesses the function returns its best guess as to the number of jelly beans contained in the jar. If there are 2 or more guesses then the function
 * should return the average of all the guesses, rounded. If there is only one guess the function should randomly guess either one higher or one lower than
 * the guess. GuessArray has a minimum of one member and can contain infinitely many guesses. 
 */
class Program
{
    static void Main(string[] args)
    {
        int[] test0 = new int[] {15}; //should return 14 or 16, can be run multiple times to show variation
        Console.WriteLine(GuessNumJellyBeans(test0));

        int[] test1 = new int[] {100, 500}; //should return 300
        Console.WriteLine(GuessNumJellyBeans(test1));

        int[] test2 = new int[] { 100, 500, 900 }; //should return 500
        Console.WriteLine(GuessNumJellyBeans(test2));

        Console.WriteLine("Tests Finished. Press any key to exit.");
        Console.ReadKey();
    }


    static int GuessNumJellyBeans(int[] guessArray)
    {   //case: guessArray contains only one memeber
        if (guessArray.Length == 1)
        {
           //Random01 helper function returns either 0 or 1
                if (Random01() == 0)
                {
                    return guessArray[0] + 1;
                }
                else return guessArray[0] - 1;
        }else //case: number of guesses>1
        {     //average all guesses
            return AverageArray(guessArray);
        }
    }


    static int Random01() //returns either a 0 or 1
    {
        Random rnd = new Random();
        int i = rnd.Next(2);
        return i;
    }

    static int AverageArray(int[] intArray) //averages all members of an array and rounds the result to nearest int
    {
        int sum = 0;
        for (int i = 0; i < intArray.Length; i++)
        {
            sum += intArray[i];
        }
        float avg = sum / intArray.Length;
        int rounded = (int)Math.Round(avg, 0);
        return rounded;
    }
}
