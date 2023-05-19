namespace LiarsDiceGame.Interfaces
{
    public interface IPlayer
    {
        bool MyTurn(int turn);
        public void Roll();
        public bool IsComputer();
    }
}