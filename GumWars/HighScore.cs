using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumWars
{
    public class HighScore
    {
        public static string OUTPUT_FILE = "HighScores.txt";

        const int TOP_SCORES_THAT_MATTER = 10;

        public String Name
        {
            get;
            set;
        }

        public int Score
        {
            get;
            set;
        }

        public static bool IsTopTen(int score)
        {
            List<HighScore> scores = HighScore.GetAllHighScores();
            if (scores.Count < TOP_SCORES_THAT_MATTER)
                return true;

            for(int i = 0; i < TOP_SCORES_THAT_MATTER; i++)
            {
                HighScore s = scores[i];
                if (score > s.Score)
                    return true;
            }
            return false;
        }


        public static void AddHighScore(string name, int score)
        {
            if (HighScore.IsTopTen(score) == false)
                return;

            string outputString = String.Empty;
            List<HighScore> scores = HighScore.GetAllHighScores();
            string thisScore = name + "\t" + score.ToString();

            bool beatPreviousScore = false;
            bool outputtedScore = false;

            foreach (HighScore s in scores)
            {
                if(s.Score <= score && outputtedScore == false)
                {
                    outputString += thisScore + Environment.NewLine;
                    beatPreviousScore = true;
                    outputtedScore = true;
                }
                outputString += s.Name + "\t" + s.Score.ToString() + Environment.NewLine;
            }

            if (!beatPreviousScore && scores.Count < 10 && scores.Count > 0)
                outputString += Environment.NewLine + thisScore;
            else if (!beatPreviousScore && scores.Count < 10 && scores.Count == 0)
                outputString = thisScore;
            File.WriteAllText(OUTPUT_FILE, outputString);
        }

        public static List<HighScore> GetAllHighScores()
        {
            List<HighScore> returnList = new List<HighScore>();

            if (File.Exists(HighScore.OUTPUT_FILE) == false)
                return returnList;
                
            string[] lines = File.ReadAllLines(HighScore.OUTPUT_FILE);

            foreach(string line in lines)
            {
                if (line == String.Empty)
                    continue;
                string name = line.Split('\t')[0];
                int score = 0;
                int.TryParse(line.Split('\t')[1], out score);

                HighScore highScore = new HighScore();
                highScore.Name = name;
                highScore.Score = score;
                returnList.Add(highScore);
            }
            return returnList;
        }
    }
}
