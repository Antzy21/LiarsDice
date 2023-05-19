namespace LiarsDiceGame
{
    public class Game
    {
        public List<Player> players = new List<Player>();
        public List<Round> rounds = new List<Round>();

        public Game(List<Player> _players, int dicePerPlayer, int myPosition)
        {
            players = _players;
        }

        public void submitClaim(Claim claim)
        {
            LatestRound().claims.Add(claim);
            nextTurn();
        }
        private void nextTurn()
        {
            LatestRound().playerOnTurn = NextPlayer();
        }

        public Claim LatestClaim()
        {
            return LatestRound().claims.Last();
        }

        public (Player, bool) ResolveRoundAndReturnNextPlayer(bool claimTrue)
        {
            Player looser;
            if (claimTrue)
            {
                looser = LatestRound().playerOnTurn;
            }
            else
            {
                looser = PreviousPlayer();
            }

            looser.diceCount -= 1;

            if (looser.diceCount == 0)
            {
                players.Remove(looser);
                return (NextPlayer(looser), false);
            }

            bool specialRound = looser.diceCount == 1;

            return (looser, specialRound);
        }

        public void NewRound(Player startingPlayer, bool specialRound = false)
        {
            rounds.Add(new Round(players, startingPlayer, specialRound));
        }

        public Player playerOnTurn
        {
            get
            {
                return LatestRound().playerOnTurn;
            }
        }

        private Round LatestRound()
        {
            return rounds.Last();
        }

        private Player NextPlayer()
        {
            int index = players.FindIndex(p => p == LatestRound().playerOnTurn);
            if (index + 1 < players.Count)
                return players[index + 1];
            return players.First();
        }

        private Player NextPlayer(Player player)
        {
            int index = players.FindIndex(p => p == player);
            if (index + 1 < players.Count)
                return players[index + 1];
            return players.First();
        }

        private Player PreviousPlayer()
        {
            int index = players.FindIndex(p => p == LatestRound().playerOnTurn);
            if (index - 1 >= 0)
                return players[index - 1];
            return players.Last();
        }

        public int DieCount()
        {
            int count = 0;
            foreach (var player in players)
            {
                count += player.diceCount;
            }
            return count;
        }

        public List<Claim> Claims()
        {
            return LatestRound().claims;
        }

        public bool IsSpecialRound()
        {
            return LatestRound().isSpecial;
        }

        public Player FirstPlayer
        {
            get
            {
                return players.First();
            }
        }
    }
}
