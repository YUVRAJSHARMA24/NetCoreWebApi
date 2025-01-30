using AutoMapper;
using FootBallersApi.DTOs;
using FootBallersApi.Models;

namespace FootBallersApi.Services
{
    public class FootballerService : IFootballerService
    {
        private List<FootballerModel> Footballers = new List<FootballerModel>();
        private readonly IMapper _mapper;

        public FootballerService(IMapper mapper)
        {
            _mapper = mapper;
            Footballers.Add(new FootballerModel { Id = 1, Name = "Lionel Messi", Club = "Inter Miami", Age = 34, Salary = 1000000 });
        }

        public FootballerDto CreateFootballer(FootballerDto footballerDto)
        {
            var footballer = _mapper.Map<FootballerModel>(footballerDto);
            footballer.Id = Footballers.Count + 1;
            Footballers.Add(footballer);

            return _mapper.Map<FootballerDto>(footballer);
        }

        public void DeleteFootballer(int id)
        {
            var footballer = Footballers.FirstOrDefault(f => f.Id == id);

            if (footballer != null)
            {
                Footballers.Remove(footballer);
            }
        }

        public FootballerDto GetFootballerById(int id)
        {
            var footballer = _mapper.Map<FootballerDto>(Footballers.FirstOrDefault(f => f.Id == id));

            return footballer;
        }

        public List<FootballerDto> GetFootballers()
        {
            return _mapper.Map<List<FootballerDto>>(Footballers);
        }

        public FootballerDto UpdateFootballer(int id, FootballerDto footballerDto)
        {
            var footballer = Footballers.FirstOrDefault(f => f.Id == id);
            if (footballer == null)
                return null;

            _mapper.Map(footballerDto, footballer);

            return _mapper.Map<FootballerDto>(footballer);
        }
    }
}
