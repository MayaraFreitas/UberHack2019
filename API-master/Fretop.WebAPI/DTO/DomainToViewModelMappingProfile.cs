using AutoMapper;
using AutoMapper.Configuration;
using Fretop.Infraestrutura.Classes;
using Fretop.ViewModel.DTO;

namespace Fretop.WebAPI.DTO
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}
