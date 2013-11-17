using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BallOfDuty
{
    [Serializable]
    public class HighScore : IComparable
    {
        public string PlayerName { get; set; }

        public int Score { get; set; }

        public int CompareTo(object obj)
        {
            var otherScore = (HighScore)obj;
            if (Score == otherScore.Score)
                return 0;

            if (Score < otherScore.Score)
                return 1;

            return -1;
        }
    }

    class HighScoreTable
    {
        public static List<HighScore> highScores;

        public static void saveHighScores(HighScore hs)
        {
            loadHighScores();
            if (highScores.Count == 10)
            {
                highScores.Sort();
                if (highScores[9].Score <= hs.Score)
                    highScores[9] = hs;
            }
            else
                highScores.Add(hs);
            
            using (var fileStream = new FileStream(@"scores.dat", FileMode.Create, FileAccess.Write))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, highScores);
            }
        }

        public static void saveHighScores()
        {

            using (var fileStream = new FileStream(@"scores.dat", FileMode.Create, FileAccess.Write))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, highScores);
            }
        }

        public static void loadHighScores()
        {
            try
            {
                using (var fileStream = new FileStream(@"scores.dat", FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    highScores = (List<HighScore>)formatter.Deserialize(fileStream);
                }
            }
            catch (Exception)
            {
                generateHighScores();
            }
        }

        

        private static void generateHighScores()
        {
            highScores = new List<HighScore>()
            {
                new HighScore { PlayerName = "Helen", Score = 10 },
                new HighScore { PlayerName = "Christophe", Score = 20 },
                new HighScore { PlayerName = "Ruben", Score = 20 },
                new HighScore { PlayerName = "John", Score = 40 },
                new HighScore { PlayerName = "The Last Starfighter", Score = 50 }
            };
            saveHighScores();
        }

        public static string displayScores()
        {
            loadHighScores();
            highScores.Sort();
            string result = "";
            int i = 1;
            foreach (HighScore score in highScores)
            {
                if(score.PlayerName.Length / 8 < 1)
                    result += String.Format("{0}. {1}\t\t\t{2}\r\n", i, score.PlayerName, score.Score);
                else if (score.PlayerName.Length / 8 == 1)
                    result += String.Format("{0}. {1}\t\t{2}\r\n", i, score.PlayerName, score.Score);
                else
                    result += String.Format("{0}. {1}\t{2}\r\n", i, score.PlayerName, score.Score);
                i++;
            }
            return result;
        }
    }
}
