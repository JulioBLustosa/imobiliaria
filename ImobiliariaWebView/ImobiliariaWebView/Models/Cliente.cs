using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ImobiliariaWebView.Models;

public class Cliente
{
    public int IdCliente { get; set; }
    public string Nome { get; set; }
    public string Cpf_Cnpj { get; set; }
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set;  }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Uf { get; set; }  
    public string Telefone_Residencial { get; set; }
    public string Telefone_Celular { get; set; }
    public string Email { get; set; }
}
