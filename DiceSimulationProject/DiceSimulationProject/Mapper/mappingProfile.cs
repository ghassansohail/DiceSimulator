using AutoMapper;
using DiceSimulationProject.DTOs;
using DiceSimulationProject.Models;

namespace DiceSimulationProject.Mapper
{
    public class mappingProfiles : Profile
    {
        public mappingProfiles()
        {
            CreateMap<DiceResultDto, DiceResultModel>().ReverseMap();
            CreateMap<DiceRollDto, DiceRollModel>().ReverseMap();
        }
    }
}
