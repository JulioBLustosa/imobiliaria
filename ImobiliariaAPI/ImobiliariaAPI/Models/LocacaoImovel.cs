using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImobiliariaWebView.Models;

[Table("locacao_imovel")]
public class LocacaoImovel
{
    [Key]
    [Column("id_locacao")]
    public int IdLocacao { get; set; }

    [Required]
    [Column("id_imovel")]
    public int IdImovel { get; set; }

    /*[ForeignKey("id_imovel")]
    public Imovel Imovel { get; set; }*/

    [Required]
    [Column("id_locatario")]
    public int IdLocatario { get; set; }

    /*[ForeignKey("id_cliente")]
    public Cliente Cliente { get; set; }*/

    [Required]
    [Column("data_locacao")]
    public DateTime DataLocacao { get; set; }

    [Required]
    [Column("periodo_minino_locacao")]
    public int PeriodoMinicoLocacao { get; set; }

    [Required]
    [Column("data_inicio_vigencia")]
    public DateTime DataInicioVigencia { get; set; }

    [Column("data_fim_vigencia")]
    public DateTime DataFimVigencia { get; set; }

    [Required]
    [Column("valor_aluguel")]
    public float ValorAluguel { get; set; }

    [Required]
    [Column("taxa_administracao")]
    public float TaxaAdministracao { get; set; }

    [Required]
    [Column("finalidade_locacao")]
    public string FinalidadeLocacao { get; set; }

}
