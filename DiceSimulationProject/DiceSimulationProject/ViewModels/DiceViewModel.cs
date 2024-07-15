namespace DiceSimulationProject.ViewModels
{
    public class DiceViewModel
    {

        public int FavoredFaceDie1 { get; set; }

        public int FactorDie1 { get; set; }

        public int FavoredFaceDie2 { get; set; }

        public int FactorDie2 { get; set; }

        public int NumberOfRolls { get; set; }


        // Non Input values
        public List<int>? ResultsDie1 { get; set; }
        public List<int>? ResultsDie2 { get; set; }
    }

}
