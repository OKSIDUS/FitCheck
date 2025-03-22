using AutoMapper;
using FitCheck.BAL.Dtos;
using FitCheck.DAL.DataContext.Entity;

namespace FitCheck.Common.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BodyMeasurementDto, BodyMeasurements>().ReverseMap();
            CreateMap<CreateBodyMeasurementDto, BodyMeasurements>().ReverseMap();
        }

    }
}
