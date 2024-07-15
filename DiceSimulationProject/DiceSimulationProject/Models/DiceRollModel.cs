using System.ComponentModel.DataAnnotations;

namespace DiceSimulationProject.Models
{
    public class DiceRollModel
    {
        public DiceRollModel(int numberOfRolls)
        {
            NumberOfRolls = numberOfRolls;
        }

        [Key]
        public int Id { get; set; }
        public int NumberOfRolls { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<DiceResultModel> DiceResults { get; } = new List<DiceResultModel>();
    }
}
