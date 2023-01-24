using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ImobiliariaWebView.Data.Dtos;

public class CreateClienteDto
{
    [Required(ErrorMessage = "O nome do cliente é obrigatório", AllowEmptyStrings = false)]
    [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
        ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
    [StringLength(70, ErrorMessage = "O tamanho do nome não pode ser superior a 70 caracteres")]
    [Column("nome")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O número do CPF/CNPJ é obrigatorio.", AllowEmptyStrings = false)]
    [Column("cpf_cnpj")]
    public string Cpf_Cnpj { get; set; }

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

    [Column("telefone_residencial")]
    public string TelefoneResidencial { get; set; }

    [Required(ErrorMessage = "Número de telefone celular é obrigatório.", AllowEmptyStrings = false)]
    [Column("telefone_celular")]
    public string TelefoneCelular { get; set; }

    [Required(ErrorMessage = "Informe o seu email", AllowEmptyStrings = false)]
    [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
    [Column("email")]
    public string Email { get; set; }
}
