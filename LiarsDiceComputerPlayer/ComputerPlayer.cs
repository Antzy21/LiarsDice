using LiarsDiceGame;

namespace LiarsDiceComputerPlayer
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(int initialDiceCount, int _tablePosition) : base(initialDiceCount, _tablePosition) { }

        public override bool IsComputer() => true;

        private List<(Dice,int)> MyDieAnalysed
        {
            get
            {
                return AnalyseDice(myDice);
            }
        }

        private List<Dice> AssumedDice = new();

        public override void Roll()
        {
            myDice = new List<Dice>();

            var rnd = new Random();

            for (int i = 0; i < diceCount; i++)
            {
                Dice die = (Dice)rnd.Next(1, 6);
                myDice.Add(die);
            }

            myDice = myDice.OrderByDescending(die => (int)die).ToList();
        }

        public Claim CalculateTurn(List<Claim> claims, int diceCount, bool specialRound)
        {
            if (claims.Count == 0)
            {
                return GenerateFirstClaim(diceCount);
            }
            Claim latestClaim = claims.Last();

            AssumedDice = GetAssumedDice(claims);

            if (PreviousClaimConfirmedByMyDice(latestClaim)) { return GenerateClaim(specialRound, latestClaim); }

            if (!ClaimValid(latestClaim, diceCount)) {
                return null;
            }
            else
            {
                return DoubleCheckClaim(diceCount, GenerateClaim(specialRound, latestClaim));
            }
        }

        private static List<Dice> GetAssumedDice(List<Claim> claims)
        {
            return claims.Select(c => c.dice).ToList();
        }

        private bool PreviousClaimConfirmedByMyDice(Claim latestClaim)
        {
            int myMatchingDice = MatchingDieCount(myDice, latestClaim.dice, includeOnes: true);

            return myMatchingDice >= latestClaim.quantity;
        }

        private Claim GenerateClaim(bool specialRound, Claim latestClaim)
        {
            return specialRound ? GenerateClaimFromDie(latestClaim, latestClaim.dice) : GenerateClaimFromMostCommonDie(latestClaim);
        }

        private Claim DoubleCheckClaim(int diceCount, Claim newClaim)
        {
            if (ClaimValid(newClaim, diceCount))
            {
                return newClaim;
            }
            else
            {
                return null;
            }
        }

        private Claim GenerateClaimFromMostCommonDie(Claim latestClaim)
        {
            var mostCommonNoneOneDie = MostCommonNoneOneDie();
            return GenerateClaimFromDie(latestClaim, mostCommonNoneOneDie);
        }

        private Claim GenerateClaimFromDie(Claim latestClaim, Dice die)
        {
            int quantity;
            if (latestClaim.dice == Dice.One)
            {
                quantity = latestClaim.quantity * 2 + 1;
            }
            else
            {
                quantity = die > latestClaim.dice ? latestClaim.quantity : latestClaim.quantity + 1;
            }
            return new Claim(quantity, die, name);
        }

        private Claim GenerateFirstClaim(int diceCount)
        {
            var mostCommonNoneOneDie = MostCommonNoneOneDie();
            int externalDiceCount = diceCount - myDice.Count;

            var rnd = new Random();
            var maxQuantity = myDice.Count + externalDiceCount / 6;
            var quantity = rnd.Next(1, maxQuantity);
            return new Claim(quantity, mostCommonNoneOneDie, name);
        }

        private bool ClaimValid(Claim claim, int diceCount)
        {
            int claimedQuantity = claim.quantity;
            Dice claimedDie = claim.dice;

            int unsureDiceCount = diceCount - (myDice.Count + AssumedDice.Count); 
            int myMatchingDice = MatchingDieCount(myDice, claimedDie);
            int assumedMatchingDice = MatchingDieCount(AssumedDice, claimedDie);

            var unsureProbableMatchingDice = BasicProbabilityOf(claimedDie) * unsureDiceCount;

            var totalProbableMatchingDice = unsureProbableMatchingDice + myMatchingDice + assumedMatchingDice;

            return totalProbableMatchingDice >= claimedQuantity;
        }

        private static decimal BasicProbabilityOf(Dice claimedDie)
        {
            if (claimedDie == Dice.One)
            {
                return (decimal)1 / 6;
            }
            else
            {
                return (decimal)2 / 6;
            }
        }

        public List<string> DisplayDice()
        {
            List<string> list = new();
            foreach (Dice die in Enum.GetValues(typeof(Dice)))
            {
                list.Add($"{MatchingDieCount(myDice, die)} {die}s ({MatchingDieCount(myDice, die, includeOnes: true)})");
            }
            return list;
        }

        private static int MatchingDieCount(List<Dice> diceSet, Dice die, bool includeOnes = false)
        {
            if (includeOnes) {
                return diceSet.Where(d => d == die || d == Dice.One).Count();
            }
            else
            {
                return diceSet.Where(d => d == die).Count();
            }
        }
        private Dice MostCommonNoneOneDie()
        {
            var assumedAndOwned = AnalyseDice(AssumedDice);
            assumedAndOwned.AddRange(MyDieAnalysed);

            foreach (var set in assumedAndOwned)
            {
                if (set.Item1 != Dice.One)
                {
                    return set.Item1;
                }
            }
            return Dice.One;
        }
        private static List<(Dice, int)> AnalyseDice(List<Dice> diceSet)
        {
            List<(Dice, int)> list = new();
            foreach (Dice die in Enum.GetValues(typeof(Dice)))
            {
                list.Add((die, diceSet.Where(d => d == die).Count()));
            }
            return list.OrderByDescending(set => set.Item2).ToList();
        }
    }
}
