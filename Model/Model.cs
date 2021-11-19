using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AcessoBiometria.Model
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<agrotoxico> agrotoxico { get; set; }
        public virtual DbSet<biometria> biometria { get; set; }
        public virtual DbSet<destino> destino { get; set; }
        public virtual DbSet<fiscal> fiscal { get; set; }
        public virtual DbSet<nivel> nivel { get; set; }
        public virtual DbSet<producaoagricola> producaoagricola { get; set; }
        public virtual DbSet<produto> produto { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<agrotoxico>()
                .Property(e => e.Nome)
                .IsUnicode(false);       

            modelBuilder.Entity<biometria>()
                .Property(e => e.biometria1);

            modelBuilder.Entity<biometria>()
                .HasMany(e => e.usuario)
                .WithRequired(e => e.Biometria)
                .HasForeignKey(e => e.Biometria_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<destino>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<destino>()
                .HasMany(e => e.producaoagricola)
                .WithRequired(e => e.destino)
                .HasForeignKey(e => e.Destino_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nivel>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<nivel>()
                .HasMany(e => e.biometria)
                .WithRequired(e => e.nivel)
                .HasForeignKey(e => e.Nivel_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<producaoagricola>()
                .Property(e => e.NomeUniProd)
                .IsUnicode(false);

            modelBuilder.Entity<producaoagricola>()
                .Property(e => e.NivelAuto)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .HasMany(e => e.producaoagricola)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.Produto_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.Senha)
                .IsUnicode(false);
        }
    }
}
