using System;

namespace Struct
{

    struct Game
    {
        // cant have default constructors and don't support inheritance
        // properties can't be called if null
        // not a pointer type like classes

        public string name;
        public string developer;
        public double rating;
        public string releaseDate;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game;
            game.name = "Teste1";
            game.developer = "Brunodev09";
            game.rating = 5.0;
            game.releaseDate = "18/11/2019";


        }
    }
}
