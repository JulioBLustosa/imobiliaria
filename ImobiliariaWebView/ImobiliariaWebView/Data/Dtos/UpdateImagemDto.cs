using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ImobiliariaWebView.Models;

namespace ImobiliariaWebView.Data.Dtos;

public class UpdateImagemDto
{
    [Required]
    [Column("id_imovel")]
    public int IdImovel { get; set; }

    [ForeignKey("id_imovel")]
    public Imovel Imovel { get; set; }

    [Column("ordem_imagem")]
    public int OrdemImagem { get; set; }

    [Required]
    [Column("imagem")]
    public string ImagemPath { get; set; }
}
