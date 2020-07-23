namespace SMI.Infrastructure.Mappings
{
    using AutoMapper;
    using SMI.Core.DTOs;
    using SMI.Core.Entites;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Empleado, EmpleadoDto>();
            CreateMap<EmpleadoDto, Empleado>();
        }
    }
}
