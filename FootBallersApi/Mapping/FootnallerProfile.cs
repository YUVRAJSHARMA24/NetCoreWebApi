using System.Runtime.InteropServices;
using AutoMapper;
using FootBallersApi.DTOs;
using FootBallersApi.Models;

namespace FootBallersApi.Mapping
{
    public class FootnallerProfile : Profile
    {
        public FootnallerProfile()
        {
            CreateMap<FootballerModel, FootballerDto>().ReverseMap();
        }
    }
}
