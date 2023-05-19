namespace LiarsDiceGame
{
    public class Round
    {
        public Player playerOnTurn;
        public List<Claim> claims = new List<Claim>();
        public List<Player> players = new List<Player>();
        public bool isSpecial;

        public Round(List<Player> _players, Player _playerOnturn, bool _isSpecial = false)
        {
            players = _players;
            isSpecial = _isSpecial;

            playerOnTurn = _playerOnturn;

            foreach (var player in players)
            {
                player.Roll();
            }
        }
    }
}
