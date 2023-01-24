using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ImobiliariaWebView.Data.Dtos
{
    public class ReadClienteDto
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("cpf_cnpj")]
        public string Cpf_Cnpj { get; set; }

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

        [Column("telefone_celular")]
        public string TelefoneCelular { get; set; }

        [Column("email")]
        public string Email { get; set; }
    }
}
