namespace ChrEx // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)

        {
            {   //introduction stuff
                Console.WriteLine("Hello... Who is there?\n");
                Console.Write("Please enter your name: ");
                string userName = Console.ReadLine();
                Console.Write("\n");

                //lonely stuff
                Console.WriteLine($"Good evening {userName}! I'm the Number Crumbler. May I ask you to put 10 numbers inside me? I'm hungry...\n");
                int userInputA = Convert.ToInt32(Console.ReadLine());
                int userInputB = Convert.ToInt32(Console.ReadLine());
                int userInputC = Convert.ToInt32(Console.ReadLine());
                int userInputD = Convert.ToInt32(Console.ReadLine());
                int userInputE = Convert.ToInt32(Console.ReadLine());
                int userInputF = Convert.ToInt32(Console.ReadLine());
                int userInputG = Convert.ToInt32(Console.ReadLine());
                int userInputH = Convert.ToInt32(Console.ReadLine());
                int userInputI = Convert.ToInt32(Console.ReadLine());
                int userInputJ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThank you very much!\n");
                Console.WriteLine($"You fed me the following numbers:\n\n{userInputA.ToString("N0")}\n\n{userInputB.ToString("N0")}\n\n{userInputC.ToString("N0")}\n\n{userInputD.ToString("N0")}\n\n{userInputE.ToString("N0")}\n\n{userInputF.ToString("N0")}\n\n{userInputG.ToString("N0")}\n\n{userInputH.ToString("N0")}\n\n{userInputI.ToString("N0")}\n\n{userInputJ.ToString("N0")}\n");

                //for stuff
                Console.WriteLine($"Feed me more master {userName}!\n");
                int[] userNumbers = new int[10];
                for (int counter = 0; counter <= userNumbers.Length - 1; counter++)
                {
                    userNumbers[counter] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine("\nYour second 10 snacks are:\n");
                foreach (int number in userNumbers)
                {
                    Console.WriteLine($"{number.ToString("N0")}\n");
                }
                Console.WriteLine("\nThanks for those delicious inputs!");

                //while this stuff
                Console.WriteLine($"\nDear {userName} one last time. They are too delicious.... pls...\n");
                int whileCounter = 0;
                { }
                while (whileCounter <= userNumbers.Length - 1)
                {
                    userNumbers[whileCounter] = Convert.ToInt32(Console.ReadLine());
                    whileCounter++;
                }
                foreach (int number in userNumbers)
                {
                    Console.WriteLine($"{number.ToString("N0")}\n");
                }
                Console.WriteLine($"Thanks again! See you next time {userName}. Now I'll have to go to bed and enjoy my food coma.");
            }






        }
    }
}