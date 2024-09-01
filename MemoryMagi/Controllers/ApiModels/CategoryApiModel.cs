using MemoryMagi.Models;

namespace MemoryMagi.Controllers.ApiModels
{
    public class CategoryApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Image { get; set; }
        public List<GameApiModel> AllGames { get; set; } = new();

        //En kategori kan innehålla både publika och privata spel. Därav behövs listor per kategori där man kan utläsa privat/public.
        public List<GameApiModel> PublicGames { get; set; } = new();
        public List<GameApiModel> PrivateGames { get; set; } = new();

        //Public games progress
        public bool HasPublicGames { get; set; }
        public int TotalPublicGames { get; set; }
        public int CompletedPublicGames { get; set; }
        public bool IsCategoryPublicComplete { get; set; }

        //Private games progress
        public bool HasPrivateGames { get; set; }
        public int TotalPrivateGames { get; set; }
        public int CompletedPrivateGames { get; set; }
        public bool IsCategoryPrivateComplete { get; set; }

        //Total games progress per category
        public int TotalGames { get; set; }
        public int CompletedGames { get; set; }
        public bool IsCategoryComplete { get; set; }

        public CategoryApiModel(CategoryModel category)
        {
            Id = GetCategoryId(category);
            Name = GetCategoryName(category);
            Image = GetImage(category);
            AllGames = ProjectGameModelToApiModel(category.Games);
            PublicGames = GetPublicGamesInCategory(AllGames);
            PrivateGames = GetPrivateGamesInCategory(AllGames);

            TotalPublicGames = GetTotalGames(PublicGames);
            CompletedPublicGames = GetCompletedGames(PublicGames);
            IsCategoryPublicComplete = GetCategoryCompletionStatus(TotalPublicGames, CompletedPublicGames);
            HasPublicGames = GetIfCategoryHasGameType(TotalPublicGames);

            TotalPrivateGames = GetTotalGames(PrivateGames);
            CompletedPrivateGames = GetCompletedGames(PrivateGames);
            IsCategoryPrivateComplete = GetCategoryCompletionStatus(TotalPrivateGames, CompletedPrivateGames);
            HasPrivateGames = GetIfCategoryHasGameType(TotalPrivateGames);

            TotalGames = GetTotalCategoryGames(TotalPublicGames, TotalPrivateGames);
            CompletedGames = GetTotalCategoryCompletedGames(CompletedPublicGames, CompletedPrivateGames);
            IsCategoryComplete = GetTotalCategoryCompletionStatus(IsCategoryPublicComplete, IsCategoryPrivateComplete);
        }
        private int GetCategoryId(CategoryModel category)
        {
            return category.Id;
        }
        private string GetCategoryName(CategoryModel category)
        {
            return category.Name;
        }

        private string GetImage(CategoryModel category)
        {
            return category.Image;
        }

        private List<GameApiModel> ProjectGameModelToApiModel(List<GameModel> games)
        {
            return games.Select(g => new GameApiModel(g)).ToList();
        }

        private bool GetCategoryCompletionStatus(int totalGames, int completedGames)
        {
            if (totalGames > completedGames)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int GetTotalGames(List<GameApiModel> games)
        {
            return games.Count;
        }

        private int GetCompletedGames(List<GameApiModel> games)
        {
            return games.Count(g => g.IsComplete);
        }

        private List<GameApiModel> GetPublicGamesInCategory(List<GameApiModel> games)
        {
            return AllGames.Where(g => g.GameType == "public").ToList();
        }

        private List<GameApiModel> GetPrivateGamesInCategory(List<GameApiModel> games)
        {
            return AllGames.Where(g => g.GameType == "private").ToList();
        }

        private int GetTotalCategoryGames(int publicGamesCount, int privateGamesCount)
        {
            return publicGamesCount + privateGamesCount;
        }
        private int GetTotalCategoryCompletedGames(int completedPublicGames, int completedPrivateGames)
        {
            return completedPublicGames + completedPrivateGames;
        }
        private bool GetTotalCategoryCompletionStatus(bool isPublicCompleted, bool isPrivateCompleted)
        {
            if (isPublicCompleted && isPrivateCompleted)
            {
                return true;
            }
            return false;
        }

        private bool GetIfCategoryHasGameType(int gameCount)
        {
            if (gameCount > 0)
            {
                return true;
            }
            return false;
        }
    }

}
