using DiceSimulationProject.DTOs;
using DiceSimulationProject.Models;
using DiceSimulationProject.Repositories.IRepositories;
using DiceSimulationProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DiceSimulationProject.Controllers
{
    public class DiceController : Controller
    {
        private IDiceRepository _diceRepository;
        public DiceController(IDiceRepository diceRepository)
        {
            _diceRepository = diceRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Simulate(DiceViewModel model)
        {
            Random random = new Random();
            model.ResultsDie1 = new List<int>();
            model.ResultsDie2 = new List<int>();

            DiceRollDto diceRollDto = new DiceRollDto();
            diceRollDto.NumberOfRolls = model.NumberOfRolls;
            DiceRollModel diceRollModel = _diceRepository.CreateDiceRoll(diceRollDto);

            for (int i = 0; i < model.NumberOfRolls; i++)
            {
                int resultDie1 = SimulateDieRoll(model.FavoredFaceDie1, model.FactorDie1, random);
                int resultDie2 = SimulateDieRoll(model.FavoredFaceDie2, model.FactorDie2, random);

                DiceResultDto diceResultDto = new DiceResultDto();
                diceResultDto.ResultsDie1 = resultDie1;
                diceResultDto.ResultsDie2 = resultDie2;
                diceResultDto.DiceRoll = diceRollModel;

                _diceRepository.CreateDiceResult(diceResultDto);
                // Store the results of each die separately
                model.ResultsDie1.Add(resultDie1);
                model.ResultsDie2.Add(resultDie2);
            }
            var res = _diceRepository.GetAllDiceResultsWithRolls();
            return View("Results", res);
        }


        private int SimulateDieRoll(int favoredFace, int factor, Random random)
        {
            int roll = random.Next(1, (6 + factor));

            // Check if the roll should be the favored face
            if (roll > 6)
            {
                return favoredFace;
            }

            return roll;
        }
    }

}

