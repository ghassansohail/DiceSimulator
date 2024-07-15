using System.ComponentModel.DataAnnotations;

namespace DiceSimulationProject.DTOs
{
    public class DiceRollDto
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfRolls { get; set; }
    }
}
