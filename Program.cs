


namespace HighLow
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to High Low game.");
            Director play = new Director();
            play.StartGame();
        }
    }
}
