using ImobiliariaWebView.Models;
using Microsoft.EntityFrameworkCore;

namespace ImobiliariaWebView.Data;

public class ImobiliariaContext : DbContext
{
    public ImobiliariaContext(DbContextOptions<ImobiliariaContext> opts) : base(opts)
    {

    }

    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Imagem> ImagemImovel { get; set; }
    public DbSet<Imovel> Imovel { get; set; }
    public DbSet<LocacaoImovel> LocacaoImovel { get; set; }
    public DbSet<TipoImovel> TipoImovel { get; set; }
}
