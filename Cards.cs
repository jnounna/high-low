using System;


namespace HighLow
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.
    public class Card
    {

        public int _currentCard = 0;
        public int _nextCard = 0;
        public int _points = 0;
        public string _result;
        public string _guess;
    
        


        public Card()
        {
        }


        public void DrawTwo()
        {
            Random random = new Random();

            _currentCard = random.Next(1,14);
            _nextCard = random.Next(1,14);

            

            while ( _currentCard == _nextCard )
            {
                _nextCard = random.Next(1,14);
                break;
            }

            Console.WriteLine($"The first card is {_currentCard}");
            Console.Write("Higer or lower [h/l]");
            _guess = Console.ReadLine();
            _guess = _guess.ToUpper();

        }
        public void HighLow()
        {
            if (_currentCard > _nextCard)
            {
                _result = "L";
            }

            else if (_currentCard < _nextCard)
            {
                _result = "H";
            }
        }
        public int ComputeScore()
        {
            Console.WriteLine($"The second card was {_nextCard}");

            if (_guess == _result)
            {
                _points = 100;
            }

            else
            {
                _points = -75;
            }
            return _points;
        }



    }       
}