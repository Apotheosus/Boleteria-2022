using AutoMapper;
using BoleteriaOnline.Web.Data.Models;
using BoleteriaOnline.Web.ViewModels.Requests;
using BoleteriaOnline.Web.ViewModels.Responses;

namespace BoleteriaOnline.Web.AutoMapper;
public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Usuario, RegistroRequest>()
            .ForMember(o => o.Dni, b => b.MapFrom(z => z.Id))
            .ReverseMap();
        CreateMap<Usuario, UsuarioResponse>()
            .ForMember(o => o.Dni, b => b.MapFrom(z => z.Id))
            .ReverseMap();
        CreateMap<Cliente, ClienteRequest>()
            .ForMember(o => o.Dni, b => b.MapFrom(z => z.Id))
            .ReverseMap();
        CreateMap<Cliente, ClienteResponse>()
            .ForMember(o => o.Dni, b => b.MapFrom(z => z.Id))
            .ReverseMap();
        CreateMap<Destino, DestinoRequest>()
            .ReverseMap();
        CreateMap<Destino, DestinoResponse>()
            .ReverseMap();
    }
}
