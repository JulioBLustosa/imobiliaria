using AutoMapper;
using ImobiliariaWebView.Data.Dtos;
using ImobiliariaWebView.Models;

namespace ImobiliariaWebView.Profiles;

public class ImobiliariaProfile : Profile
{
    public ImobiliariaProfile()
    {
        CreateMap<CreateClienteDto, Cliente>();
        CreateMap<UpdateClienteDto, Cliente>();
        CreateMap<Cliente, UpdateClienteDto>();
        CreateMap<Cliente, ReadClienteDto>();
    }
}
