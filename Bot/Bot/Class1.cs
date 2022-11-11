using BotInterface.Bot;
using BotInterface.Game;

namespace Bot
{
    public class Bot : IBot
    {
        public Move MakeMove(Gamestate gamestate)
        {
            return Move.P;
        }
    }
}
