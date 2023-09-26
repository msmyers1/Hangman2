namespace Hangman
{
    internal class Program
    {
        #region Underscores
        static void Underscores(string lettersGuessed, string wordToGuess, int wordLength,
            int numberOfCorrectGuesses, int livesLeft, string lettersIncorrect, char guess)
        {
            for (int i = 0; i < wordLength; i++)
            {
                if (lettersGuessed.Contains(wordToGuess[i]) == true)
                {
                    
                    Console.Write($" {wordToGuess[i]} ");

                }
                else
                {
                    Console.Write(" _ ");
                }
            }

        }
        #endregion
        #region Guess
        static void Guess(string lettersGuessed, string wordToGuess, int wordLength, 
            int numberOfCorrectGuesses, int livesLeft, string lettersIncorrect)
        {
            if (lettersGuessed.Length < wordToGuess.Length)
            {
                Console.Write("\n\nGuess a letter: ");
                char guess = char.Parse(Console.ReadLine().ToUpper().Trim());

                Console.Clear();

                if (wordToGuess.IndexOf(guess) != -1)
                {
                    numberOfCorrectGuesses++;
                    lettersGuessed += guess;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your guess was correct!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    livesLeft--;
                    lettersIncorrect += guess;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your guess was wrong.");
                    Console.ForegroundColor= ConsoleColor.White;
                }

                Setup(lettersGuessed, wordToGuess, wordLength, numberOfCorrectGuesses, livesLeft, lettersIncorrect, guess);

                int index1;
                /*
                int index2 = -1;
                int index3 = -1;
                int index4 = -1;
                int index5 = -1;
                int index6 = -1;
                int index7 = -1;
                int index8 = -1;
                int index9 = -1;
                int index10 = -1;
                */

            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Green;               
                Console.WriteLine("\nYOU WON!");
                Console.ForegroundColor= ConsoleColor.White;
            }
        }
        #endregion
        #region Setup
        static void Setup(string lettersGuessed, string wordToGuess, int wordLength,
            int numberOfCorrectGuesses, int livesLeft, string lettersIncorrect, char guess)
        {
            

            if (livesLeft > 0)
            {
                Console.WriteLine($"\nThe word is {wordLength} letters long.\n");
                
                

                    Console.WriteLine($"These letters are not in the word: {lettersIncorrect}\n");
                    
                

                
                
                    Underscores( lettersGuessed,  wordToGuess,  wordLength,
             numberOfCorrectGuesses,  livesLeft,  lettersIncorrect, guess);
                    
                

                Console.WriteLine($"\n\nYou have {livesLeft} lives left");

                Guess(lettersGuessed, wordToGuess, wordLength, numberOfCorrectGuesses, livesLeft, lettersIncorrect);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GAME OVER");
            }
            #endregion
        }
        static void Main(string[] args)
        {
            //Variable block
            string lettersGuessed = "";
            string lettersIncorrect = "";
            string wordToGuess;
            int wordLength;
            int numberOfCorrectGuesses = 0;
            int livesLeft = 5;
            
            //Initial word input
            Console.Write("Welcome to Hangman!\nPlayer 1, please enter a word 10 or less letters long: ");
            wordToGuess = Console.ReadLine().ToUpper().Trim();
            wordLength = wordToGuess.Length;

                    
            Console.Clear();
            char guess = ' ';
            
            Setup(lettersGuessed, wordToGuess, wordLength, numberOfCorrectGuesses, livesLeft, lettersIncorrect,guess);
            

            
            
        }
    }
}