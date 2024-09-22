using MemoryMagi.Models;
using MemoryMagi.Models._2._0;

namespace MemoryMagi.Controllers.ApiModels
{
    public class ResultApiModel
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime DatePlayed { get; set; }
        public bool Passed { get; set; }
        public string UserId { get; set; }
        public string? Username { get; set; }
        public List<UserAchievement> UserAchievements { get; set; } = new();
        public string? DifficultyLevelName { get; set; }

        public ResultApiModel(ResultModel result)
        {
            Id = GetResultId(result);
            GameId = GetGameId(result);
            Time = GetTime(result);
            DatePlayed = GetDatePlayed(result);
            Passed = GetPassed(result);
            UserId = GetUserId(result);
            Username = GetUserName(result);
            UserAchievements = GetUserAchievements(result);
            DifficultyLevelName = GetDifficultyLevelName(result);
        }

        private int GetResultId(ResultModel result)
        {
            return result.Id;
        }

        private int GetGameId(ResultModel result)
        {
            return result.GameId;
        }
        private TimeSpan GetTime(ResultModel result)
        {
            return result.Time;
        }
        private DateTime GetDatePlayed(ResultModel result)
        {
            return result.DatePlayed;
        }
        private bool GetPassed(ResultModel result)
        {
            return result.Passed;
        }
        private string GetUserId(ResultModel result)
        {
            return result.UserId;
        }
        private string? GetUserName(ResultModel result)
        {
            return result.User.UserName;
        }

        private List<UserAchievement> GetUserAchievements(ResultModel result)
        {
            return result.User.UserAchievements.Select(ua => new UserAchievement
            {
                AchievementId = ua.AchievementId,
                UserId = ua.UserId,
                AchievementDate = ua.AchievementDate
            }).ToList();
        }

        private string? GetDifficultyLevelName(ResultModel result)
        {
            return result.Game?.DifficultyLevel?.Name ?? null;
        }
    }
}
