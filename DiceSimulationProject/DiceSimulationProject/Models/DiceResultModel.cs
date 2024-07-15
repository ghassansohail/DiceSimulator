using System.ComponentModel.DataAnnotations;

namespace DiceSimulationProject.Models
{
    public class DiceResultModel
    {
        [Key]
        public int Id { get; set; }

        public int ResultsDie1 { get; set; }
        public int ResultsDie2 { get; set; }
        public DiceRollModel DiceRoll { get; set; } = null!;

    }

}
