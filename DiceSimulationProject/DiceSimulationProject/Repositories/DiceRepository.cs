using AutoMapper;
using DiceSimulationProject.Data;
using DiceSimulationProject.DTOs;
using DiceSimulationProject.Models;
using DiceSimulationProject.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DiceSimulation.Repositories
{
    public class DiceRepository : IDiceRepository
    {
        private ApplicationDbContext _db;
        private IMapper _mapper;
        public DiceRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public DiceResultModel CreateDiceResult(DiceResultDto model)
        {
            var diceResult = _mapper.Map<DiceResultDto, DiceResultModel>(model);
            var addedObject = _db.DiceResults.Add(diceResult);
            _db.SaveChanges();
            return diceResult;
        }

        public DiceRollModel CreateDiceRoll(DiceRollDto model)
        {
            var diceRoll = _mapper.Map<DiceRollDto, DiceRollModel>(model);
            var addedObject = _db.DiceRoll.Add(diceRoll);
            _db.SaveChanges();
            return diceRoll;
        }
        public List<DiceRollModel> GetAllDiceResultsWithRolls()
        {
            var diceRolls = _db.DiceRoll
                .Include(d => d.DiceResults)
                .OrderByDescending(d => d.CreatedDate)
                .ToList();

            return diceRolls;

        }
    }
}
