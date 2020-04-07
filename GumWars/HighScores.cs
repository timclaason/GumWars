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
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            List<HighScore> scores = HighScore.GetAllHighScores();
            _dgvScores.DataSource = scores;
        }
    }
}
