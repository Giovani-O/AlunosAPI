using AlunosAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AlunosAPI.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno { Id = 1, Nome = "Nerevarine", Email = "nerevarine@gmail.com", Idade = 30 },
                new Aluno { Id = 2, Nome = "Miraak", Email = "miraak@gmail.com", Idade = 45 },
                new Aluno { Id = 3, Nome = "Martin Septim", Email = "martin@gmail.com", Idade = 32 },
                new Aluno { Id = 4, Nome = "Barenziah", Email = "barenziah@gmail.com", Idade = 50 },
                new Aluno { Id = 5, Nome = "Divayth Fyr", Email = "divayth@gmail.com", Idade = 4000 },
                new Aluno { Id = 6, Nome = "Jagar Tharn", Email = "jagar@gmail.com", Idade = 60 },
                new Aluno { Id = 7, Nome = "Nocturnal", Email = "nocturnal@gmail.com", Idade = 1000 },
                new Aluno { Id = 8, Nome = "Lucien Lachance", Email = "lucien@gmail.com", Idade = 45 },
                new Aluno { Id = 9, Nome = "Sheogorath", Email = "sheogorath@gmail.com", Idade = 1000 },
                new Aluno { Id = 10, Nome = "Almalexia", Email = "almalexia@gmail.com", Idade = 3000 }
            );

        }
    }
}
