using System;
using System.Windows.Forms;
using GumWars.Core;
using GumWars.Core.Enums;

namespace GumWars
{
    public partial class Form1 : Form
    {
        Game _game;

        int _lastDayAttemptedToBuyCapacity = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialize();
            _grdMarket.CellDoubleClick += _grdMarket_CellDoubleClick;
            _grdInventory.CellDoubleClick += _grdInventory_CellDoubleClick;
            this.KeyDown += Form1_KeyDown;
            alertStatus("Press [Space Bar] to change city.  Buy low, sell high, leverage");
        }

        DateTime _lastSpacePressed = DateTime.Now.AddHours(-1);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                TimeSpan timeSincePressed = DateTime.Now - _lastSpacePressed;

                if (timeSincePressed.TotalSeconds < 0.4)
                    return;
                if (_cmbSelectedCity.SelectedIndex == _cmbSelectedCity.Items.Count - 1)
                    _cmbSelectedCity.SelectedIndex = 0;
                else
                    _cmbSelectedCity.SelectedIndex++;

                _lastSpacePressed = DateTime.Now;
            }
            if (e.KeyCode == Keys.C)
                promptAddCapacity();           
            if(e.KeyCode == Keys.Enter)
            {
                if(_txtDepositAmount.Focused)
                {
                    doDeposit();
                }
                else if(_txtWithdrawAmount.Focused)
                {
                    doWithdrawal();
                }
            }
            if (e.KeyCode == Keys.D)
                doDeposit();
            if (e.KeyCode == Keys.W)
                doWithdrawal();
            if(e.KeyCode == Keys.S && _game.Player.OwnedGums.Count > 0)
            {
                showSellForm(_game.Player.OwnedGums[0]);
            }
        }



        private void _grdInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in _grdInventory.Rows)
            {
                if (row.Index != e.RowIndex)
                    continue;
                OwnedGum gum = row.DataBoundItem as OwnedGum;
                showSellForm(gum);
            }
        }

        private void showSellForm(OwnedGum gum)
        {
            MarketGum marketGum = _game.CurrentCity.FindGum(gum);

            if (marketGum == null)
                return;

            if (gum != null)
            {
                BuySellForm buySellForm = new BuySellForm(marketGum, _game.Player, Actions.Sell);
                buySellForm.ShowDialog(this);
                outputGameState();
            }
        }

        private void _grdMarket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_game.DaysLeft == 0)
            {
                MessageBox.Show("You cannot buy when there are 0 days left");
                return;
            }

            foreach (DataGridViewRow row in _grdMarket.Rows)
            {
                if (row.Index != e.RowIndex)
                    continue;
                MarketGum gum = row.DataBoundItem as MarketGum;
                if (gum != null)
                {
                    BuySellForm buySellForm = new BuySellForm(gum, _game.Player, Actions.Buy);
                    buySellForm.ShowDialog(this);
                    outputGameState();
                }
            }
        }

        private void alertStatus(string status)
        {
            _lblStatus.Text = status;
            _lblGameStatus.Text = status;
        }

        private void initialize()
        {
            _alreadySaidGameOver = false;
            alertStatus(String.Empty);
            _cmbSelectedCity.Enabled = true;
            _grdMarket.Enabled = true;
            _game = new Game();
            _grpYou.Enabled = true;
            outputGameState();
        }

        private void outputGameState()
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = _game.Player.OwnedGums;
            _grdInventory.DataSource = bs;

            _lblMoney.Text = "$" + _game.Player.Money.ToString("N0");
            _lblDaysLeft.Text = _game.DaysLeft.ToString();
            _lblRemainingCapacity.Text = _game.Player.RemainingCapacity.ToString("N0") + " / " + _game.Player.CarryingCapacity.ToString("N0");

            if (_cmbSelectedCity.Items.Count == 0)
            {
                _cmbSelectedCity.DataSource = _game.Cities;
                _cmbSelectedCity.ValueMember = "Name";
            }
            _cmbSelectedCity.Text = _game.CurrentCity.Name;

            _grdMarket.CancelEdit();
            _grdMarket.DataSource = null;

            BindingSource bs2 = new BindingSource();
            bs2.DataSource = _game.CurrentCity.Gums;
            _grdMarket.DataSource = bs2;

            _llAddCapacity.Enabled = !(_lastDayAttemptedToBuyCapacity == _game.DaysLeft);
            _lblBank.Text = "$" + _game.Player.Bank.ToString("N0");
            _lblLoan.Text = "$" + _game.Player.Loan.ToString("N0");

            int depositDisplay = (int)( _game.Player.Money / 4.0);
            int withdrawDisplay = (int)(_game.Player.Bank / 2.0);

            _txtDepositAmount.Text = depositDisplay.ToString();
            _txtWithdrawAmount.Text = withdrawDisplay.ToString();
        }

        bool _alreadySaidGameOver = false;

        private void _cmbSelectedCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_alreadySaidGameOver)
                return;

            if (_cmbSelectedCity.Text == _game.CurrentCity.Name || _cmbSelectedCity.Text == String.Empty)
                return;
            if (_game.DaysLeft <= 0)
            {
                /*
                if (_game.Player.OwnedGums.Count > 0)
                {
                    for (int i = _game.Player.OwnedGums.Count - 1; i >= 0; i--)
                    {
                        OwnedGum g = _game.Player.OwnedGums[i];
                        MarketGum mGum = _game.CurrentCity.FindGum(g);

                        if (mGum == null)
                            mGum = _game.CurrentCity.Gums[0];
                        
                        if (mGum != null)
                            _game.Player.SellGum(mGum, g.Quantity);

                    }
                }
                */

                MessageBox.Show("Game over.");
                alertStatus("Game over.");
                _alreadySaidGameOver = true;
                _grpYou.Enabled = false;
                if (HighScore.IsTopTen(_game.Player.TotalWealth))
                {
                    AddHighScoreForm addScore = new AddHighScoreForm(_game.Player.TotalWealth);
                    addScore.ShowDialog(this);
                }

                _cmbSelectedCity.Enabled = false;
                _grdMarket.Enabled = false;

                return;
            }
            _game.Move(_cmbSelectedCity.Text);
            outputGameState();

            alertStatus(String.Empty);
            alertStatus(_game.CurrentMessage);
        }



        private void _llAddCapacity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            promptAddCapacity();
        }

        private void promptAddCapacity()
        {
            _llAddCapacity.Enabled = false;
            _lastDayAttemptedToBuyCapacity = _game.DaysLeft;
            BuySellForm buyCapacity = new BuySellForm(null, _game.Player, Actions.BuyCapacity);
            buyCapacity.ShowDialog(this);
            outputGameState();
        }

        private void _llHighScores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HighScores scoresForm = new HighScores();
            scoresForm.ShowDialog(this);
        }

        private void _llNewGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            initialize();
        }

        private void _llBank_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            doDeposit();            
        }

        private void doDeposit()
        {
            int amount = 0;
            int.TryParse(_txtDepositAmount.Text, out amount);

            if (amount < 0 || amount > _game.Player.Money)
                return;
            _game.Player.Deposit(amount);
            outputGameState();
        }

        private void _llBankWithdraw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            doWithdrawal();
        }

        private void doWithdrawal()
        {
            int amount = 0;
            int.TryParse(_txtWithdrawAmount.Text, out amount);

            if (amount < 0 || amount > _game.Player.Bank)
                return;
            _game.Player.Withdraw(amount);
            outputGameState();
        }


        private void _llLoanShark_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_game.Player.Loan > 0 && _game.Player.Money > _game.Player.Loan)
            {
                _game.Player.Payback(_game.Player.Loan);
            }
            else
            {
                LoanSharkForm loanShark = new LoanSharkForm(_game, _game.Player);
                loanShark.ShowDialog(this);
            }
            outputGameState();
        }
    }

    

    


    

     

}
