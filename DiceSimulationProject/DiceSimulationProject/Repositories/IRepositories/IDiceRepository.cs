using DiceSimulationProject.DTOs;
using DiceSimulationProject.Models;

namespace DiceSimulationProject.Repositories.IRepositories
{
    public interface IDiceRepository
    {
        DiceResultModel CreateDiceResult(DiceResultDto model);
        DiceRollModel CreateDiceRoll(DiceRollDto model);
        List<DiceRollModel> GetAllDiceResultsWithRolls();
    }
}
