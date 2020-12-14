using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace ShootingStar
{
    public class LeaderboardData
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }

    public class LeaderboardComparer : IComparer<LeaderboardData>
    {
        public int Compare(LeaderboardData x, LeaderboardData y)
        {
            var compare = x.Score.CompareTo(y.Score);
            var result = compare > 0 ? -1 : 1;
            return result;
        }
    }

    public static class Leaderboard
    {
        public const string LeaderboardFileName = "shootingstar.leaderboard";

        private static string _filePath => Path.Combine(_programDirectoryPath, LeaderboardFileName);

        private static string _programDirectoryPath => Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName;

        public static IReadOnlyList<LeaderboardData> Data => _leaderboard.ToList();
        private static SortedSet<LeaderboardData> _leaderboard;

        static Leaderboard()
        {
            ReadData();
        }

        public static void AddPlayer(string name, int score)
        {
            _leaderboard.Add(new LeaderboardData { Name = name, Score = score });

            var jsonString = JsonSerializer.Serialize(Data);
            File.WriteAllText(_filePath, jsonString);
        }

        private static void ReadData()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    File.Create(_filePath).Close();
                }
                var json = File.ReadAllText(_filePath);
                var item = JsonSerializer.Deserialize<IEnumerable<LeaderboardData>>(json);
                _leaderboard = new SortedSet<LeaderboardData>(item, new LeaderboardComparer());
            }
            catch (JsonException)
            {
                _leaderboard = new SortedSet<LeaderboardData>(new LeaderboardComparer());
            }
        }
    }
}
