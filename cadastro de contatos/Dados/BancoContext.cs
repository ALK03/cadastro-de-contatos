using cadastro_de_contatos.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace cadastro_de_contatos.NewFolder3
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
        }
        
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
