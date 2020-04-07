using System;
using System.Windows.Forms;
using GumWars.Core;
using GumWars.Core.Enums;

namespace GumWars
{
    public partial class LoanSharkForm : Form
    {
        Player _player;
        Game _game;

        public LoanSharkForm(Game game, Player player)
        {
            _player = player;
            _game = game;
            InitializeComponent();
        }

        private void LoanSharkForm_Load(object sender, EventArgs e)
        {
            assembleMessage();
            if (_game.DaysLeft == 0)
                this.Close();
        }

        private void assembleMessage()
        {
            if(_player.Loan == 0)
            {
                double rate = Settings.DEFAULT_LOAN_INTEREST_RATE * 100;
                int maxAmount = _player.Money * Settings.MAX_LOAN_MULTIPLIER;
                _lblWelcomeMessage.Text = "Greetings friend.  I'm willing to loan you $" + maxAmount + " at " + rate  + "% daily.";
                _lblWarning.Text = "But a warning: if you don't pay back, you'll be in a world of pain.";
                _txtAmount.Text = maxAmount.ToString();
                _btnAction.Text = "Borrow!";
            }
            else
            {
                _lblWelcomeMessage.Text = "You owe me money, friend.  I want my $" + _player.Loan + " now!";
                _lblWarning.Text = "You do not want me as your enemy!";
                _txtAmount.Text = _player.Loan.ToString();
                _btnAction.Text = "Payback!";
            }
        }

        private void _btnAction_Click(object sender, EventArgs e)
        {
            int amount = 0;
            int.TryParse(_txtAmount.Text, out amount);

            if(amount <= 0)
            {
                MessageBox.Show("That's not a valid amount");
                return;
            }

            GameResult result = GameResult.Success;

            if(_player.Loan == 0)
            {
                result = _player.Borrow(amount, _game);
            }
            else
            {
                result = _player.Payback(amount);
            }

            if (result == GameResult.Success)
            {                
                this.Close();
            }

        }
    }
}
