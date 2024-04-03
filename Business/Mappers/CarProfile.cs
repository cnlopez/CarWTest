using AutoMapper;
using Business.ModelsDTO;
using Data.Models;


namespace Business.Mappers
{
    public class CarProfile : Profile
    {
        public CarProfile() 
        {
            DomainToDTO();
        }

        public void DomainToDTO()
        {
            CreateMap<CarInfo, CarInfoDTO>();
        }
    }
}
