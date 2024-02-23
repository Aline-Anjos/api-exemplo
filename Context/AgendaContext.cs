
using APIExemplo.Contatos;
using Microsoft.EntityFrameworkCore;

namespace APIExemplo.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext>options):base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }  
    }
}
