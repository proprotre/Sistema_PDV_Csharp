using Microsoft.EntityFrameworkCore;

namespace Login
{
    public class SistemaPdv : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ItemVenda> ItensVendas { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public string DbPath { get; }

        public SistemaPdv()
        {
            DbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dbPDV.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal ValorVenda { get; set; }
        public int Quantidade { get; set; }
    }
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
    public class Venda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public decimal ValorTotal { get; set; }
    }
    public class ItemVenda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }

    }
}
