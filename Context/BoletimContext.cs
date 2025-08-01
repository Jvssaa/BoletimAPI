using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BoletimAPI.Entities;

namespace BoletimAPI.Context
{
    public class BoletimContext : DbContext
    {
        public BoletimContext(DbContextOptions<BoletimContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunoDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AlunoDisciplina>()
                .HasKey(ad => new { ad.AlunoId, ad.DisciplinaId });

            modelBuilder.Entity<AlunoDisciplina>()
                .HasOne(ad => ad.Aluno)
                .WithMany(a => a.AlunoDisciplinas)
                .HasForeignKey(ad => ad.AlunoId);

            modelBuilder.Entity<AlunoDisciplina>()
                .HasOne(ad => ad.Disciplina)
                .WithMany(d => d.AlunoDisciplinas)
                .HasForeignKey(ad => ad.DisciplinaId);
        }
    }
}