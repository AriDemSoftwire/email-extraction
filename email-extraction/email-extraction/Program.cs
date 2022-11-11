using BotInterface.Bot;
using BotInterface.Game;

namespace ExampleBot
{
    public class ExampleBot : IBot
    {
        public Move MakeMove(Gamestate gamestate)
        {
            return Move.P;
        }
    }
}
