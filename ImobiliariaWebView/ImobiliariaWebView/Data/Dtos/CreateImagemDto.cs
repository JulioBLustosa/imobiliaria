using ImobiliariaWebView.Models;
using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace ImobiliariaWebView.Data.Dtos;

public class CreateImagemDto
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
