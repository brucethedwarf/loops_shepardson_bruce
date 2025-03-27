namespace loops_shepardson_bruce
{
    internal class Program
    {
        // Declare a variable to store a character (though it's not used in the code)
        private static char digit;

        // Declare a variable for a second response, which is not used correctly in the code
        private static object reponse2;

        // Main entry point for the program
        static void Main(string[] args)
        {
            // Ask the user why they want to make games
            Console.WriteLine("why do you want to make games?");

            // Read the user's response from the console
            string response = Console.ReadLine();

            // Output the number of spaces in the user's response
            Console.WriteLine($"the sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            // Ask the user to enter a whole number
            Console.WriteLine("please enter a whole number");

            // Read the number from the user input
            string response2 = Console.ReadLine();

            // Output the sum of the individual digits of the number entered by the user
            Console.WriteLine($"the sum of the individual digits of {response2} is {SumOfDigits(response2)}!");
        }

        // Function to count the number of spaces in a sentence
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;  // Initialize the counter for spaces

            // Loop through each character in the sentence
            foreach (char charater in sentence)
            {
                // If the character is a space, increment the space counter
                if (charater == ' ')
                {
                    numberOfSpaces++;
                }
            }

            // Return the total number of spaces found
            return numberOfSpaces;
        }

        // Function to calculate the sum of digits in a number (as a string)
        static int SumOfDigits(string number)
        {
            int sum = 0;  // Initialize the sum to 0

            // Loop through each character in the string number
            foreach (char charater in number)
            {
                // Add the numeric value of each character to the sum
                sum += (int)Char.GetNumericValue(charater);
            }

            // Return the sum of the digits
            return sum;
        }
    }
}
