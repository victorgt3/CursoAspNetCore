using AutoMapper;
using Eventos.Io.Domain.Eventos;
using Eventos.IO.Application.ViewModels;

namespace Eventos.IO.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Evento, EventoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Categoria, CategoriaViewModel>();
        }
    }
}

