using MemoryMagi.Models;

namespace MemoryMagi.Controllers.ApiModels
{
    public class GameApiModel
    {
        public int Id { get; set; }
        public DifficultyLevelModel? DifficultyLevel { get; set; }
        public string? GameType { get; set; }
        public string? CreatedBy { get; set; }
        public bool IsComplete { get; set; } = false;
        public List<ItemModel> Items { get; set; } = new();
        public GameApiModel(GameModel game)
        {
            Id = GetGameId(game);
            DifficultyLevel = GetDifficultyLevel(game);
            GameType = GetGameType(game);
            CreatedBy = GetCreatedBy(game);
            IsComplete = GetCompletionStatus(game);
            Items = GetItems(game);
        }

        private int GetGameId(GameModel game)
        {
            return game.Id;
        }

        private DifficultyLevelModel GetDifficultyLevel(GameModel game)
        {
            return game.DifficultyLevel;
        }

        private string? GetGameType(GameModel game)
        {
            return game.GameType;
        }

        private string GetCreatedBy(GameModel game)
        {
            return game.CreatedBy;
        }

        private List<ItemModel> GetItems(GameModel game)
        {
            return game.Items;
        }

        private bool GetCompletionStatus(GameModel game)
        {
            //Hitta game id i usergame-tabellen och kolla om passed är true
            ResultModel? gameResult = game.Results.FirstOrDefault(g => g.Passed == true);
            if (gameResult != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
