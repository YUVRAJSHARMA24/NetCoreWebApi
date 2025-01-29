using FootBallersApi.DTOs;

namespace FootBallersApi.Services
{
    public interface IFootballerService
    {
        public List<FootballerDto> GetFootballers();
        public FootballerDto GetFootballerById(int id);
        public FootballerDto CreateFootballer(FootballerDto footballerDto);
        public FootballerDto UpdateFootballer(int id, FootballerDto footballerDto);
        public void DeleteFootballer(int id);
    }
}
