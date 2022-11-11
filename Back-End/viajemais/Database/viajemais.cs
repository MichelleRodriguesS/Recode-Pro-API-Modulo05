using Microsoft.EntityFrameworkCore;
using viajemais.Model;

namespace viajemais.Database
{
    public class ImperioDbContext : DbContext
    {
        public viajemaisDbContext(DbContextOptions<ImperioDbContext>
        options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var clientes = modelBuilder.Entity<Cliente>();
            clientes.ToTable("clientes");
            clientes.HasKey(x => x.Id);
            clientes.Property(x => x.IdCliente).HasColumnName("IdCliente").ValueGeneratedOnAdd();
            clientes.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            clientes.Property(x => x.email).HasColumnName("email").IsRequired();
            clientes.Property(x => x.nascimento).HasColumnName("nascimento").IsRequired();
            clientes.Property(x => x.telefone).HasColumnName("telefone").IsRequired();
        }

        public DbSet<Passagem> Destino { get; set; }

        public DbSet<Promocoes> Promocoes { get; set; }

        public DbSet<ContatoReclamacao> Contato { get; set; }
    }
}