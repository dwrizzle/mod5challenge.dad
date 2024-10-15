using System;

class Program
{
    static void Main()
    {
        //Declare array with 12 elements
        string[] jokes = new string[12];

        //Initialize the array with the dad jokes
        jokes[0] =  "Look at that cemetery! People are just dying to get in there. ";
        jokes[1] = "You guys want to hear a joke about pizza? Nevermind, it's too cheesy. ";
        jokes[2] = "I love telling dad jokes. They always make him laugh.";
        jokes[3] = "How did the hacker escape the FBI? He ransomeware. ";
        jokes[4] = "I'm not one to brag about finances. But my bank calls me every day to tell me my balance is outstanding! ";
        jokes[5] = "Argentina is surprisingly cold. In fact, it's bordering on Chile. ";
        jokes[6] = "As soon as space travel is possible, I'm moving from the Milky Way to the Soy Way. I'm galactose intolerant. ";
        jokes[7] = "Two incomes are better than one. So make sure your partner has two jobs. ";
        jokes[8] = "Where do bad rainbows go? Prism. It's a light sentence. Gives them time to reflect. ";
        jokes[9] = "I have a condition where I can't stop telling airplane jokes. My doctor says it's terminal. ";
        jokes[10] = "The CEO of Pepsi was fired this morning. He tested positive for Coke. ";
        jokes[11] = "I once yelled into a colander. I strained my voice. ";

        Console.WriteLine("Welcome to the Dad Joke generator! ");
        Random random = new Random();
        string wantMore;

        do
        {
            //Choosing the two random numbers
            int firstChoice = random.Next(1, 13);
            int secondChoice = random.Next(1, 13);

            //Make sure you're not choosing same number
            do
            {
                secondChoice = random.Next(1, 13);
            }
            while (secondChoice == firstChoice);

            string firstJoke = jokes[firstChoice];
            string secondJoke = jokes[secondChoice];

            //Display the jokes
            Console.WriteLine("Here are your randomly selected jokes: ");
            Console.WriteLine("Joke Number One: " + firstJoke);
            Console.WriteLine("Joke Numer Two: " + secondJoke);
            Console.Write("Would you like to see more jokes? (Y/N): ");
            wantMore = Console.ReadLine().ToLower();
        }
        while (wantMore != "n");

        //Say toodaloo!
        Console.WriteLine("Thanks for stopping by. Time for me to make like a bad check and bounce! ");

    }
}