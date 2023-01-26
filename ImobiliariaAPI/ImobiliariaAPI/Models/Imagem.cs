using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace ImobiliariaWebView.Models;

[Table("imagem_imovel")]
public class Imagem
{
    [Key]
    [Required]
    [Column("id_imagem")]
    public int IdImagem { get; set; }

    [Required]
    [Column("id_imovel")]
    public int IdImovel { get; set; }

    /*[ForeignKey("id_imovel")]
    public Imovel Imovel { get; set; }*/

    [Column("ordem_imagem")]
    public int OrdemImagem { get; set; }

    [Required]
    [Column("imagem")]
    public string ImagemPath { get; set; }
}
