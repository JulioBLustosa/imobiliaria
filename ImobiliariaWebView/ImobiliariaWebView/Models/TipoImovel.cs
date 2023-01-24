using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImobiliariaWebView.Models;

[Table("tipo_imovel")]
public class TipoImovel
{
    [Key]
    [Column("id_tipo_imovel")]
    public int IdTipoImovel { get; set; }

    [Required]
    [Column("tipo_imovel")]
    public string DescicaoTipoImovel { get; set; }

}
