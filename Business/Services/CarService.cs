using Business.Interfaces;
using Business.ModelsDTO;
using Data.Interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Business.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository carRepository;
        private readonly IMapper _mapper;
        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            this.carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CarInfoDTO>> GetCars()
        {
            var getcars = await carRepository.GetCars();
            var getCarsDTO = _mapper.Map<IEnumerable<CarInfoDTO>>(getcars);
            return getCarsDTO;
        }

        public async Task<IEnumerable<CarInfoDTO>> GetInfoCar()
        {
            var getcars = await carRepository.GetCarInfo();
            var getCarsDTO = _mapper.Map<IEnumerable<CarInfoDTO>>(getcars);
            return getCarsDTO;
        }

    }
}
