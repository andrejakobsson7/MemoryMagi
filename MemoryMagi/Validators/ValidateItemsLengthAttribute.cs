using MemoryMagi.Models;
using MemoryMagi.Repositories;
using System.ComponentModel.DataAnnotations;

public class ValidateItemsLengthAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        GameModel newGame = (GameModel)validationContext.ObjectInstance;
        //Manually inject the service provider and get the service of generic repository, since it could not be done through the constructor.
        var serviceProvider = validationContext.GetService<IServiceProvider>();
        var genericRepository = serviceProvider.GetRequiredService<GenericRepository<DifficultyLevelModel>>();
        //Use the generic repo to get the difficulty level.
        DifficultyLevelModel? difficultyLevel = genericRepository.GetModelByIdSynchronously(newGame.DifficultyLevelId);
        if (difficultyLevel == null)
        {
            return new ValidationResult($"Difficulty level with id {newGame.DifficultyLevelId} could not be found");
        }
        else
        {
            //Validate the nr of items sent along and compare it against the difficulty "level nr of cards"-property
            if (newGame.Items.Count != difficultyLevel.NrOfCards)
            {
                return new ValidationResult("Game with difficulty level " + $"{difficultyLevel.Name}" + $" needs to have {difficultyLevel.NrOfCards} cards.");
            }
            else
            {
                return ValidationResult.Success;
            }

        }
    }
}
