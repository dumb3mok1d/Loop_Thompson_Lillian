using System;

namespace Loop_Thompson_Lillian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpace(response)} space in it");

            Console.WriteLine("Please enter a whole Number");
            string response2 = Console.ReadLine();
            Console.WriteLine($"The sum of the the individual digits of {response2} is {SumOfDigits(response2)}!");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of space in </param>
        /// <returns>Number of spaces in the sentence</returns>

        static int CountNumberOfSpace(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
         
            }
            return numberOfSpaces;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }
    }    
}
