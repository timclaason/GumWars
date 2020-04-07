using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GumWars
{
    public partial class AddHighScoreForm : Form
    {
        int _score;
        public AddHighScoreForm(int score)
        {
            _score = score;
            InitializeComponent();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            HighScore.AddHighScore(_txtName.Text, _score);
            this.Close();
        }

        private void AddHighScoreForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Your score was " + _score.ToString("N0");
            List<HighScore> scores = HighScore.GetAllHighScores();

            if (scores.Count > 0)
                _txtName.Text = scores[0].Name;
        }
    }
}
