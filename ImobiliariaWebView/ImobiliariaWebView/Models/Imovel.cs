using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace ImobiliariaWebView.Models;

[Table("imovel")]
public class Imovel
{
    [Key]
    [Column("id_imovel")]
    public int IdImovel { get; set; }

    [Required(ErrorMessage = "O identificador do imóvel é obrigatório")]
    [Column("id_locador")]
    public int IdLocador { get; set; }

    [ForeignKey("id_cliente")]
    public Cliente Cliente { get; set; }

    [Column("id_tipo_imovel")]
    public int IdTipoImovel { get; set; }

    [ForeignKey("id_tipo_imovel")]
    public TipoImovel TipoImovel { get; set; }

    [Column("titulo_anuncio")]
    public string TituloAnuncio { get; set; }

    [Column("descricao_imovel")]
    public string DescricaoImovel { get; set; }

    [Required(ErrorMessage = "O CEP é obrigatório.", AllowEmptyStrings = false)]
    [Column("cep")]
    public string Cep { get; set; }

    [Column("logradouro")]
    public string Logradouro { get; set; }

    [Column("numero")]
    public string Numero { get; set; }

    [Column("complemento")]
    public string Complemento { get; set; }

    [Column("bairro")]
    public string Bairro { get; set; }

    [Column("cidade")]
    public string Cidade { get; set; }

    [Column("uf")]
    public string Uf { get; set; }

    [Column("area_aproximada")]
    public string AreaAproximada { get; set;}

    [Column("quartos")]
    public int Quartos { get; set; }

    [Column("banheiros")]
    public int Banheiros { get; set; }

    [Column("suite")]
    public int Suite { get; set; }

    [Column("vaga_coberta")]
    public int VagaCoberta { get; set; }

    [Column("vaga_descoberta")]
    public int VagaDescoberta { get; set; }

    [Column("elevador")]
    public bool Elevador { get; set; }

    [Column("valor_aluguel_proprietario")]
    public float ValorAluguelProprietario { get; set; }

    [Column("taxa_imobiliaria")]
    public float TaxaImobiliaria { get; set; }

    [Column("valor_condominio")]
    public float ValorCondominio { get; set; }

    [Column("valor_iptu")]
    public float ValorIptu { get; set; }

}


