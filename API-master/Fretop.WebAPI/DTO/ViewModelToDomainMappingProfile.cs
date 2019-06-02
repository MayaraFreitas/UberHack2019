using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Fretop.Infraestrutura.Classes;
using Fretop.ViewModel.DTO;

namespace Fretop.WebAPI.DTO
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuarioDTO, Usuario>();
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
    }
}