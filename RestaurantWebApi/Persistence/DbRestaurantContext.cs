using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RestaurantWebApi.Model;

namespace RestaurantWebApi.Persistence
{
    public partial class DbRestaurantContext : DbContext
    {
        public DbRestaurantContext()
        {
        }

        public DbRestaurantContext(DbContextOptions<DbRestaurantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CabeceraFactura> CabeceraFacturas { get; set; } = null!;
        public virtual DbSet<Carta> Carta { get; set; } = null!;
        public virtual DbSet<CategoriaCarta> CategoriaCarta { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<CorrelativoFactura> CorrelativoFacturas { get; set; } = null!;
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<GrupoCarta> GrupoCarta { get; set; } = null!;
        public virtual DbSet<Mesa> Mesas { get; set; } = null!;
        public virtual DbSet<MesaEstado> MesaEstados { get; set; } = null!;
        public virtual DbSet<Perfil> Perfils { get; set; } = null!;
        public virtual DbSet<PermisoEmpresa> PermisoEmpresas { get; set; } = null!;
        public virtual DbSet<PermisoPerfil> PermisoPerfils { get; set; } = null!;
        public virtual DbSet<PermisoUsuario> PermisoUsuarios { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Sistema> Sistemas { get; set; } = null!;
        public virtual DbSet<SuperCategoriaCarta> SuperCategoriaCarta { get; set; } = null!;
        public virtual DbSet<TipoCambio> TipoCambios { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CabeceraFactura>(entity =>
            {
                entity.HasKey(e => new { e.Codemp, e.Tipdoc, e.Nroser, e.Nrodoc })
                    .HasName("PK__FAD200__94E30DF6E13D15A4");

                entity.ToTable("CabeceraFactura");

                entity.Property(e => e.Codemp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tipdoc)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codcli)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Codmon)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Codusu)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Estdoc)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecdoc).HasColumnType("datetime");

                entity.Property(e => e.Fecdpa).HasColumnType("datetime");

                entity.Property(e => e.Fecreg).HasColumnType("datetime");

                entity.Property(e => e.Forpag)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdFad200).ValueGeneratedOnAdd();

                entity.Property(e => e.Impdsc).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Impigv).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Modvta)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Monbru).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Mondpa).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Monnet).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Nrodpa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Tipcam).HasColumnType("numeric(15, 7)");

                entity.Property(e => e.Tipcli)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tipdpa)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Carta>(entity =>
            {
                entity.HasKey(e => e.CodCarta)
                    .HasName("PK__CARTA_C1D3C3560BC6C43E");

                entity.Property(e => e.NivelCarta)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCarta)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioCarta).HasColumnType("numeric(8, 2)");

                entity.HasOne(d => d.CodCategoriaCartaNavigation)
                    .WithMany(p => p.Carta)
                    .HasForeignKey(d => d.CodCategoriaCarta)
                    .HasConstraintName("FK__T_CARTA__COD_CAT__0DAF0CB0");

                entity.HasOne(d => d.CodGrupoCartaNavigation)
                    .WithMany(p => p.Carta)
                    .HasForeignKey(d => d.CodGrupoCarta)
                    .HasConstraintName("FK__Carta__CodGrupoC__236943A5");
            });

            modelBuilder.Entity<CategoriaCarta>(entity =>
            {
                entity.HasKey(e => e.CodCategoriaCarta)
                    .HasName("PK__T_CATEGO__D3CEAB8107020F21");

                entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCategoriaCarta)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodSuperCategoriaCartaNavigation)
                    .WithMany(p => p.CategoriaCarta)
                    .HasForeignKey(d => d.CodSuperCategoriaCarta)
                    .HasConstraintName("FK__T_CATEGOR__COD_S__08EA5793");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => new { e.Codemp, e.Tipcli, e.Codcli })
                    .HasName("PK__FAM010__528C14E1C1326D0D");

                entity.Property(e => e.Codemp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tipcli)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Codcli)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Codofi)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Codubi)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codusu)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Contac)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Direcc)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Estcli)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecreg).HasColumnType("datetime");

                entity.Property(e => e.IdFam010).ValueGeneratedOnAdd();

                entity.Property(e => e.Nrocel)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nrodni)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Nrotel)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Razcom)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Razsoc)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorrelativoFactura>(entity =>
            {
                entity.HasKey(e => new { e.Codemp, e.Tipdoc })
                    .HasName("PK__FAT002__2F3C305B4731F43A");

                entity.ToTable("CorrelativoFactura");

                entity.Property(e => e.Codemp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tipdoc)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codusu)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Estreg)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecreg).HasColumnType("datetime");

                entity.Property(e => e.IdFat002).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.HasKey(e => new { e.Codemp, e.Tipdoc, e.Nroser, e.Nrodoc, e.Nroite })
                    .HasName("PK__FAD210__9AAB8E4E2FD63DB9");

                entity.ToTable("DetalleFactura");

                entity.Property(e => e.Codemp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tipdoc)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codpro)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codusu)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Estpro)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecreg).HasColumnType("datetime");

                entity.Property(e => e.IdFad210).ValueGeneratedOnAdd();

                entity.Property(e => e.Impcos).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Impvta).HasColumnType("numeric(15, 5)");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.CodigoEmpresa);

                entity.ToTable("Empresa");

                entity.Property(e => e.CodigoEmpresa)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CestadoEmpresa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CEstadoEmpresa")
                    .IsFixedLength();

                entity.Property(e => e.ConceptoCuotaAgua)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoCuotaLuz)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoCuotaMora)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoCuotaOrdinaria)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CtipoDocumento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CTipoDocumento");

                entity.Property(e => e.DireccionEmpresa)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAgrega).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.LogoEmpresa)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NextelEmpresa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEmpresa)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeMora).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RucEmpresa)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SerieDocumento)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TelCelularEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TelFijoEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAgrega)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GrupoCarta>(entity =>
            {
                entity.HasKey(e => e.CodGrupoCarta)
                    .HasName("PK__GrupoCar__798F9357C0038D1C");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombreGrupoCarta)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCategoriaCartaNavigation)
                    .WithMany(p => p.GrupoCarta)
                    .HasForeignKey(d => d.CodCategoriaCarta)
                    .HasConstraintName("FK__GrupoCart__CodCa__1CBC4616");
            });

            modelBuilder.Entity<Mesa>(entity =>
            {
                entity.HasKey(e => e.CodMesa)
                    .HasName("PK__Mesa__0ACE62102962A492");

                entity.ToTable("Mesa");

                entity.HasIndex(e => e.CodMesa, "UQ__Mesa__0ACE6211416F4425")
                    .IsUnique();

                entity.Property(e => e.NombreMesa)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMesa)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MesaEstado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MesaEstado");

                entity.Property(e => e.NEstado).HasColumnName("nEstado");

                entity.Property(e => e.NNumeroMesa)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("nNumeroMesa");
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasKey(e => e.CodigoPerfil);

                entity.ToTable("Perfil");

                entity.Property(e => e.CodigoPerfil)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CestadoPerfil)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CEstadoPerfil")
                    .IsFixedLength();

                entity.Property(e => e.DescripcionPerfil)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EliminablePerfil)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAgrega).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.NombrePerfil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAgrega)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PermisoEmpresa>(entity =>
            {
                entity.HasKey(e => e.ClavePermisoEmpresa);

                entity.ToTable("PermisoEmpresa");

                entity.Property(e => e.ClavePermisoEmpresa)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEmpresa)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cpermitir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CPermitir")
                    .IsFixedLength();

                entity.Property(e => e.FechaAgrega).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAgrega)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PermisoPerfil>(entity =>
            {
                entity.HasKey(e => e.ClavePermisoPerfil);

                entity.ToTable("PermisoPerfil");

                entity.Property(e => e.ClavePermisoPerfil)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBoton)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPerfil)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoVentana)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cpermitir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CPermitir")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PermisoUsuario>(entity =>
            {
                entity.HasKey(e => e.ClavePermisoUsuario);

                entity.ToTable("PermisoUsuario");

                entity.Property(e => e.ClavePermisoUsuario)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBoton)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoVentana)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cpermitir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CPermitir")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => new { e.Codemp, e.Codpro })
                    .HasName("PK__FAM020__AB6807B4E9A42143");

                entity.ToTable("Producto");

                entity.Property(e => e.Codemp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codpro)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Codmon)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("codmon");

                entity.Property(e => e.Codusu)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Estpro)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecreg).HasColumnType("datetime");

                entity.Property(e => e.IdFam020).ValueGeneratedOnAdd();

                entity.Property(e => e.Marcom).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Nompro)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Precos).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Prevta).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Prevts).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Salstk)
                    .HasColumnType("numeric(15, 5)")
                    .HasColumnName("salstk");

                entity.Property(e => e.Unimed)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("unimed");
            });

            modelBuilder.Entity<Sistema>(entity =>
            {
                entity.HasKey(e => new { e.Codemp, e.NroTab, e.Codigo })
                    .HasName("PK__FAT001__750E4FCBB44E78C6");

                entity.ToTable("Sistema");

                entity.Property(e => e.Codemp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NroTab)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codusu)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Descr1)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Descr2)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Descri)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Descrv)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Estreg)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecreg).HasColumnType("datetime");

                entity.Property(e => e.IdFat001).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SuperCategoriaCarta>(entity =>
            {
                entity.HasKey(e => e.CodSuperCategoriaCarta)
                    .HasName("PK__T_SUPERC__4595662603317E3D");

                entity.Property(e => e.NombreSuperCategoriaCarta)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoCambio>(entity =>
            {
                entity.HasKey(e => new { e.Codemp, e.Tipcam, e.Feccam })
                    .HasName("PK__FAM015__9B035B5497C208BA");

                entity.ToTable("TipoCambio");

                entity.Property(e => e.Codemp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tipcam)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Feccam).HasColumnType("datetime");

                entity.Property(e => e.CodUsu)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EstReg)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FecReg).HasColumnType("datetime");

                entity.Property(e => e.IdFam015).ValueGeneratedOnAdd();

                entity.Property(e => e.Impcom).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Impvta).HasColumnType("numeric(15, 5)");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.CodigoUsuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.CodigoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CestadoUsuario)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CEstadoUsuario")
                    .IsFixedLength();

                entity.Property(e => e.ClaveUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPerfil)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPersonal)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoUsuario)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionUsuario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAgrega).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.FotoUsuario)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelCelularUsuario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TelFijoUsuario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAgrega)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
