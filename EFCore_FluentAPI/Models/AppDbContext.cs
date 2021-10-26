using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_FluentAPI.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<AlunoCursos> AlunoCursos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=teste;Integrated Security=True;Pooling=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ------------------------------- Produto -----------------------------------
            modelBuilder.Entity<Produto>()
                .Property(p => p.Nome)
                .HasMaxLength(80)
                .IsRequired();

            modelBuilder.Entity<Produto>()
                .Property(p => p.Descricao)
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<Produto>()
                .Property(p => p.DataCompra)
                .HasColumnType("Date");

            // ---------------------------------- Cliente ----------------------------------
            modelBuilder.Entity<Cliente>()
                .ToTable("ClientesEspeciais");

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.Codigo);

            modelBuilder.Entity<Cliente>()
                .HasIndex(c => c.Nome);

            modelBuilder.Entity<Cliente>()
                .Property(p => p.Nome)
                .HasMaxLength(80)
                .IsRequired();

            modelBuilder.Entity<Cliente>()
                .Property(p => p.Email)
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<Cliente>()
                .Property(c => c.Ativo)
                .HasDefaultValue(0);

            modelBuilder.Entity<Cliente>()
                .Property(c => c.DataNascimento)
                .IsRequired()
                .HasColumnType("Date");

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Codigo = 1,
                    Nome = "Maria",
                    Email = "maria@teste.com",
                    Ativo = 0,
                    DataNascimento = new DateTime(1975, 9, 11)
                }
            );

            // ---------------------------------- Setor ----------------------------------
            modelBuilder.Entity<Setor>()
                .HasMany(f => f.Funcionarios)
                .WithOne(s => s.Setor)
                .IsRequired();

            // ---------------------------------- AlunoCursos ----------------------------------
            modelBuilder.Entity<AlunoCursos>()
                .HasKey(ac => new { ac.AlunoId, ac.CursoId });

        }
    }
}
