using System;
using System.Windows.Forms;
using GumWars.Core;
using GumWars.Core.Enums;

namespace GumWars
{
    public partial class BuySellForm : Form
    {
        MarketGum _gum;
        Player _player;
        Actions _action;

        int _afford;

        int _generatedPrice = 0;

        public BuySellForm(MarketGum gum, Player player, Actions action)
        {
            _gum = gum;
            _player = player;

            if (action == Actions.Buy || action == Actions.Sell)
            {
                double affordAmount = player.Money / (double)gum.CurrentPrice;
                _afford = (int)Math.Floor(affordAmount);
            }

            _action = action;
            InitializeComponent();
        }




        private void BuySellForm_Load(object sender, EventArgs e)
        {
            
            if (_action == Actions.BuyCapacity)
            {
                int generatePrice = 0;
                int generateQuantity = MyRandom.Random(_player.CarryingCapacity * 2, _player.CarryingCapacity * 3);
                if (_player.Money <= 1000)
                {
                    generatePrice = 1000;
                }
                else if (_player.Money > 1000 && _player.Money < 5000)
                {
                    generatePrice = MyRandom.Random(800, 2500);
                }
                else if (_player.Money >= 5000 && _player.Money < 10000)
                {
                    generatePrice = MyRandom.Random(1500, 4000);
                }
                else if (_player.Money >= 10000 && _player.Money < 25000)
                {
                    generatePrice = MyRandom.Random(4000, 9000);
                }
                else
                {
                    generatePrice = MyRandom.Random(13000, 25000);
                }
                _generatedPrice = generatePrice;
                _cmbBuyOrSell.Text = "Buy";                
                _txtQuantity.Text = generateQuantity.ToString();
                _txtQuantity.Enabled = false;
                _lblStatus.Text = "Do you want to buy " + generateQuantity + " capacity for $" + _generatedPrice + "?";
                return;

            }


            int owned = _player.HowManyOwned(_gum);
            this.Text += " for Gum " + _gum.Name;

            if (owned > 0)
                _lblStatus.Text += ".  You already own " + owned;

            if (_action == Actions.Buy)
            {
                _cmbBuyOrSell.Text = "Buy";
                _txtQuantity.Text = _afford.ToString();

                if (_afford > _player.RemainingCapacity)
                    _txtQuantity.Text = _player.RemainingCapacity.ToString();

                _lblStatus.Text = "You can afford " + _afford + " of " + _gum.Name + " at $" + _gum.CurrentPrice;
            }
            else
            {
                _cmbBuyOrSell.Text = "Sell";
                _txtQuantity.Text = owned.ToString();
            }
            _cmbBuyOrSell.Enabled = false;
        }

        private void _btnCommit_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            int.TryParse(_txtQuantity.Text, out quantity);

            GameResult result = GameResult.NotEnoughCapacity;

            if (_action == Actions.BuyCapacity)
                result = _player.AddCapacity(quantity, _generatedPrice);
            else if(_action == Actions.Buy)
                result = _player.BuyGum(_gum, quantity);
            else if(_action == Actions.Sell)
                result = _player.SellGum(_gum, quantity);

            if (result == GameResult.Success)
            {
                this.Close();
                return;
            }
            MessageBox.Show(result.ToString());
        }
    }
}
