using Backend_API.Models;
using Microsoft.EntityFrameworkCore;


namespace Backend_API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Joao Batista",
                    Email = "joaobatista@gmail.com",
                    Idade = 23
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Maria da Silva",
                    Email = "maria@gmail.com",
                    Idade = 22
                }
            );
        }
    }
}
