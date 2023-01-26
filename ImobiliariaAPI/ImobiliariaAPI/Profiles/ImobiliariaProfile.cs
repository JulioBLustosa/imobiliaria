using AutoMapper;
using ImobiliariaWebView.Data.Dtos;
using ImobiliariaWebView.Models;

namespace ImobiliariaWebView.Profiles;

public class ImobiliariaProfile : Profile
{
    public ImobiliariaProfile()
    {
        // Mapeamento das classes ClienteDto, Cliente e ReadClienteDto referente a tabela cliente
        CreateMap<ClienteDto, Cliente>();
        CreateMap<Cliente, ReadClienteDto>();

        // Mapeamento das classes ImovelDto, Imovel e ReadImovelDto referente a tabela imovel
        CreateMap<ImovelDto, Imovel>();
        CreateMap<Imovel, ReadImovelDto>();

        // Mapeamento das classes ImagenDto, Imagem  e ReadImagemDto referente a tabela imagem
        CreateMap<ImagemDto, Imagem>();
        CreateMap<Imagem, ReadImagemDto>();
    }
}
