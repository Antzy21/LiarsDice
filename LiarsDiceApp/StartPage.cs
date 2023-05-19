using LiarsDiceComputerPlayer;
using LiarsDiceGame;

namespace LiarsDiceApp
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private Game? _game;

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            ToggleStartoptions(false);
            ToggleClaimRequestBox(true);

            var players = new List<Player>();
            for (int i = 0; i < (int)playerCount.Value; i ++)
            {
                if (i == myPosition.Value)
                {
                    players.Add(new ComputerPlayer((int)dicePerPlayer.Value, i));
                }
                else
                {
                    players.Add(new Player((int)dicePerPlayer.Value, i));
                }
            }

            _game = new Game(players, (int)dicePerPlayer.Value, (int)myPosition.Value);

            NewRound(_game.FirstPlayer);
        }

        private void NewRound(Player startingPlayer, bool specialRound = false)
        {
            _game.NewRound(startingPlayer, specialRound);

            UpdateRoundNumberLabel(_game.rounds.Count);
            UpdatePlayerTurnLabel();
            SubmitClaim.Enabled = true;
            quantity.Value = 1;

            visualiseDiceCount();
            updateComputerDiceDisplay();
            UnforceDie();

            if (_game.playerOnTurn.IsComputer()) { DoComputersTurn(); }
        }

        private void ToggleStartoptions(bool enabled)
        {
            playBtn.Enabled = enabled;
            dicePerPlayer.Enabled = enabled;
            playerCount.Enabled = enabled;
            myPosition.Enabled = enabled;
        }

        private void ToggleClaimRequestBox(bool visible)
        {
            groupBox_claimRequest.Visible = visible;
        }
        private void UpdateRoundNumberLabel(int number)
        {
            label_roundNumber.Text = $"Round {number}";
        }

        private void SubmitClaim_Click(object sender, EventArgs e)
        {
            Claim claim = new Claim(quantity.Value, SelectedDice(), "Not yet implimented");
            submitClaim(claim);
        }

        private void submitClaim(Claim claim)
        {
            // Visualise claim
            string plural = claim.quantity > 1 ? "s" : "";
            string str = $"{VisualisePlayerName(_game.playerOnTurn)} {_game.playerOnTurn.tablePosition} : {claim.quantity.ToString()} - {claim.dice.ToString()}{plural}";
            claimListView.Items.Add(str);

            _game.submitClaim(claim);
            callLiar.Enabled = true;
            UpdatePlayerTurnLabel();

            if (_game.IsSpecialRound()) ForceDie();
            else UnforceDie();

            quantity.Value = MinDiceQuantity();
            SubmitClaim.Enabled = ValidClaim();

            if (_game.playerOnTurn.IsComputer()) DoComputersTurn();
        }

        private void ForceDie()
        {
            DiceValue1.Enabled = DiceValue1.Checked;
            DiceValue2.Enabled = DiceValue2.Checked;
            DiceValue3.Enabled = DiceValue3.Checked;
            DiceValue4.Enabled = DiceValue4.Checked;
            DiceValue5.Enabled = DiceValue5.Checked;
            DiceValue6.Enabled = DiceValue6.Checked;
        }
        private void UnforceDie()
        {
            DiceValue1.Enabled = true;
            DiceValue2.Enabled = true;
            DiceValue3.Enabled = true;
            DiceValue4.Enabled = true;
            DiceValue5.Enabled = true;
            DiceValue6.Enabled = true;
        }

        private void DoComputersTurn()
        {
            ComputerPlayer player = (ComputerPlayer)_game.playerOnTurn;
            var computerClaim = player.CalculateTurn(_game.Claims(), _game.DieCount(), _game.IsSpecialRound());
            if (computerClaim == null)
            {
                CallLiar();
            }
            else
            {
                RadioButtonFromDie(computerClaim.dice).Checked = true;
                submitClaim(computerClaim);
            }
        }

        private RadioButton RadioButtonFromDie(Dice dice)
        {
            if (dice == Dice.One) { return DiceValue1; }
            if (dice == Dice.Two) { return DiceValue2; }
            if (dice == Dice.Three) { return DiceValue3; }
            if (dice == Dice.Four) { return DiceValue4; }
            if (dice == Dice.Five) { return DiceValue5; }
            if (dice == Dice.Six) { return DiceValue6; }
            else { throw new Exception(); }
        }

        private void UpdatePlayerTurnLabel()
        {
            label_playerTurn.Text = $"Player {_game.playerOnTurn.tablePosition}'s turn";
        }

        private string VisualisePlayerName(Player player)
        {
            return player is ComputerPlayer ? "Computer " : "Player       ";
        }
        private Dice SelectedDice()
        {
            if (DiceValue1.Checked == true) { return Dice.One; }
            else if (DiceValue2.Checked == true) { return Dice.Two; }
            else if (DiceValue3.Checked == true) { return Dice.Three; }
            else if (DiceValue4.Checked == true) { return Dice.Four; }
            else if (DiceValue5.Checked == true) { return Dice.Five; }
            else if (DiceValue6.Checked == true) { return Dice.Six; }
            else { throw new Exception(); }
        }
        private void PlayerCount_ValueChanged(object sender, EventArgs e)
        {
            myPosition.Maximum = playerCount.Value;
        }
        private void DiceValue_Click(object sender, EventArgs e)
        {
            quantity.Value = MinDiceQuantity();
            SubmitClaim.Enabled = ValidClaim();
        }

        private decimal MinDiceQuantity()
        {
            try
            {
                var latestClaim = _game.LatestClaim();
                if (latestClaim.dice == Dice.One)
                {
                    return DiceValue1.Checked ? latestClaim.quantity + 1 : latestClaim.quantity * 2 + 1;
                }
                else
                {
                    if (DiceValue1.Checked)
                    {
                        return Math.Round((decimal)latestClaim.quantity / 2, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        return SelectedDice() > latestClaim.dice ? latestClaim.quantity : latestClaim.quantity + 1;
                    }
                }
            }
            catch
            {
                return 1;
            }
        }

        private bool ValidClaim()
        {
            try
            {
                var player = _game.playerOnTurn;
                var claim = _game.LatestClaim();
                var newClaim = new Claim(quantity.Value, SelectedDice(), player.name);

                if (newClaim.dice == Dice.One)
                {
                    if (claim.dice == Dice.One)
                    {
                        return newClaim.quantity > claim.quantity;
                    }
                    else
                    {
                        return newClaim.quantity * 2 >= claim.quantity;
                    }
                }
                else
                {
                    if (claim.dice == Dice.One)
                    {
                        return (newClaim.quantity + 1) / 2 > claim.quantity;
                    }
                    else
                    {
                        if (newClaim.dice > claim.dice)
                        {
                            return newClaim.quantity >= claim.quantity;
                        }
                        return newClaim.quantity > claim.quantity;
                    }
                }
            } catch { return true; }
        }

        private void ValidateClaim(object sender, EventArgs e)
        {
            SubmitClaim.Enabled = ValidClaim();
        }

        private void CallLiar_Click(object sender, EventArgs e)
        {
            CallLiar();
        }

        private void CallLiar()
        {
            groupBox_resolution.Visible = true;

            // Visualise Call
            string str = $"{VisualisePlayerName(_game.playerOnTurn)} {_game.playerOnTurn.tablePosition} : Liar!";
            claimListView.Items.Add(str);

            callLiar.Enabled = false;
            SubmitClaim.Enabled = false;
        }

        private void falseClaim_Click(object sender, EventArgs e)
        {
            ResolveRound(claimTrue: false);
        }
        private void trueClaim_Click(object sender, EventArgs e)
        {
            ResolveRound(claimTrue: true);
        }

        private void ResolveRound(bool claimTrue)
        {
            groupBox_resolution.Visible = false;
            claimListView.Items.Clear();

            var (nextPlayer, specialround) = _game.ResolveRoundAndReturnNextPlayer(claimTrue);

            NewRound(nextPlayer, specialround);
        }

        private void updateComputerDiceDisplay()
        {
            computerDiceDisplay.Clear();
            foreach (var player in _game.players)
            {
                if (player is ComputerPlayer)
                {
                    ComputerPlayer p = (ComputerPlayer)player;
                    foreach (var item in p.DisplayDice())
                    {
                        computerDiceDisplay.Items.Add(item);
                    }
                }
            }
        }

        private void visualiseDiceCount()
        {
            resizeDiceDisplay();
            listView_playerDiceCount.Items.Clear();
            foreach (var player in _game.players)
            {
                listView_playerDiceCount.Items.Add($"{VisualisePlayerName(player)} {player.tablePosition}: {player.diceCount} dice");
            }
        }
        private void resizeDiceDisplay()
        {
            groupBox_diceDisplay.Size = new System.Drawing.Size(197, _game.players.Count * 25 + 40);
        }

    }
}
