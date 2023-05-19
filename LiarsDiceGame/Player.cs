using LiarsDiceGame.Interfaces;

namespace LiarsDiceGame
{
    public class Player : IPlayer
    {
        public Player(int initialDiceCount, int _tablePosition, string _name)
        {
            diceCount = initialDiceCount;
            tablePosition = _tablePosition;
            name = _name;
        }
        public Player(int initialDiceCount, int _tablePosition) : this(initialDiceCount, _tablePosition, $"Player {_tablePosition}") { }

        public string name;
        public int diceCount;
        public int tablePosition;
        public List<Dice> myDice = new List<Dice>();

        public virtual bool IsComputer() => false;

        public bool MyTurn(int turn)
        {
            return turn == tablePosition;
        }

        public virtual void Roll() { }
    }
}