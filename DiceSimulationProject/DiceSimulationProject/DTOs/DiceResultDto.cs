using DiceSimulationProject.Models;
using System.ComponentModel.DataAnnotations;

namespace DiceSimulationProject.DTOs
{
    public class DiceResultDto
    {
        public int Id { get; set; }
        [Required]
        public int ResultsDie1 { get; set; }
        public int ResultsDie2 { get; set; }
        public DiceRollModel DiceRoll { get; set; } = null!;


    }
}
