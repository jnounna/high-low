using System;
using System.Collections.Generic;


namespace HighLow
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        
        bool isPlaying = true;
        int score = 300;
        Card turn = new Card();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoOutputs();
            }
        }

       
        public void GetInputs()
        {
         turn.DrawTwo();
         turn.HighLow();  


           
        }

    

        
        public void DoOutputs()
        {

            if (score <= 0)
            {
                isPlaying = false;
                Console.WriteLine("You lost LOSER!!!");
            }
            else
            {
            score += turn.ComputeScore();
            Console.WriteLine($"{score}");
            Console.Write("Play again? [y/n] ");
            string again = Console.ReadLine();
            isPlaying = (again == "y");
            }
           
        }
    }
}