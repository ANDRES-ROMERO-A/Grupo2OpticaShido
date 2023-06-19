using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Grupo2Optica1._0.Models
{
    public partial class Optica10Context : DbContext
    {
        public Optica10Context()
        {
        }

        public Optica10Context(DbContextOptions<Optica10Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AjusteArticulo> AjusteArticulos { get; set; } = null!;
        public virtual DbSet<AjusteLente> AjusteLentes { get; set; } = null!;
        public virtual DbSet<Articulo> Articulos { get; set; } = null!;
        public virtual DbSet<ArticuloExistencium> ArticuloExistencia { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<DesplazamientoArticulo> DesplazamientoArticulos { get; set; } = null!;
        public virtual DbSet<DesplazamientoLente> DesplazamientoLentes { get; set; } = null!;
        public virtual DbSet<DetalleAjusteArticulo> DetalleAjusteArticulos { get; set; } = null!;
        public virtual DbSet<DetalleAjusteLente> DetalleAjusteLentes { get; set; } = null!;
        public virtual DbSet<DetalleDesplazamientoArticulo> DetalleDesplazamientoArticulos { get; set; } = null!;
        public virtual DbSet<DetalleDesplazamientoLente> DetalleDesplazamientoLentes { get; set; } = null!;
        public virtual DbSet<DetalleEntradaArticulo> DetalleEntradaArticulos { get; set; } = null!;
        public virtual DbSet<DetalleEntradaLente> DetalleEntradaLentes { get; set; } = null!;
        public virtual DbSet<DetalleSalidaArticulo> DetalleSalidaArticulos { get; set; } = null!;
        public virtual DbSet<DetalleSalidaLente> DetalleSalidaLentes { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<EntradaArticulo> EntradaArticulos { get; set; } = null!;
        public virtual DbSet<EntradaLente> EntradaLentes { get; set; } = null!;
        public virtual DbSet<Lente> Lentes { get; set; } = null!;
        public virtual DbSet<LentesExistencium> LentesExistencia { get; set; } = null!;
        public virtual DbSet<MarcaLente> MarcaLentes { get; set; } = null!;
        public virtual DbSet<RolUsuario> RolUsuarios { get; set; } = null!;
        public virtual DbSet<SalidaArticulo> SalidaArticulos { get; set; } = null!;
        public virtual DbSet<SalidaLente> SalidaLentes { get; set; } = null!;
        public virtual DbSet<TipoArticulo> TipoArticulos { get; set; } = null!;
        public virtual DbSet<TipoLente> TipoLentes { get; set; } = null!;
        public virtual DbSet<Ubicacion> Ubicacions { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DevConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AjusteArticulo>(entity =>
            {
                entity.HasKey(e => e.AjuArId)
                    .HasName("PK__Ajuste_A__809B8A23D93C691A");

                entity.ToTable("Ajuste_Articulo");

                entity.Property(e => e.AjuArId).HasColumnName("AjuAr_id");

                entity.Property(e => e.AjuArFecha)
                    .HasColumnType("date")
                    .HasColumnName("AjuAr_Fecha");

                entity.Property(e => e.UsId).HasColumnName("Us_id");

                entity.HasOne(d => d.Us)
                    .WithMany(p => p.AjusteArticulos)
                    .HasForeignKey(d => d.UsId)
                    .HasConstraintName("FK__Ajuste_Ar__Us_id__6A30C649");
            });

            modelBuilder.Entity<AjusteLente>(entity =>
            {
                entity.HasKey(e => e.AjuLeId)
                    .HasName("PK__Ajuste_L__BD9293460A30AA9B");

                entity.ToTable("Ajuste_Lentes");

                entity.Property(e => e.AjuLeId).HasColumnName("AjuLe_id");

                entity.Property(e => e.AjuLeFecha)
                    .HasColumnType("date")
                    .HasColumnName("AjuLe_Fecha");

                entity.Property(e => e.UsId).HasColumnName("Us_id");

                entity.HasOne(d => d.Us)
                    .WithMany(p => p.AjusteLentes)
                    .HasForeignKey(d => d.UsId)
                    .HasConstraintName("FK__Ajuste_Le__Us_id__4F7CD00D");
            });

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasKey(e => e.ArCodigo)
                    .HasName("PK__Articulo__E60D00541996DA67");

                entity.ToTable("Articulo");

                entity.Property(e => e.ArCodigo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Ar_codigo");

                entity.Property(e => e.ArDescripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Ar_descripcion");

                entity.Property(e => e.ArImagen)
                    .HasColumnType("image")
                    .HasColumnName("Ar_imagen");

                entity.Property(e => e.ArNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ar_nombre");

                entity.Property(e => e.ArPrecio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Ar_precio");

                entity.Property(e => e.TipoAId).HasColumnName("TipoA_id");

                entity.HasOne(d => d.TipoA)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.TipoAId)
                    .HasConstraintName("FK__Articulo__TipoA___38996AB5");
            });

            modelBuilder.Entity<ArticuloExistencium>(entity =>
            {
                entity.HasKey(e => e.ArEId)
                    .HasName("PK__Articulo__58B20E81E7A5F714");

                entity.ToTable("Articulo_Existencia");

                entity.Property(e => e.ArEId).HasColumnName("ArE_id");

                entity.Property(e => e.ArCodigo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Ar_codigo");

                entity.Property(e => e.ArEExistencia).HasColumnName("ArE_Existencia");

                entity.Property(e => e.ArEUltimaFechaActualizacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ArE_UltimaFechaActualizacion");

                entity.Property(e => e.ArEUltimaHoraActualizacion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ArE_UltimaHoraActualizacion");

                entity.Property(e => e.UbId).HasColumnName("Ub_id");

                entity.HasOne(d => d.ArCodigoNavigation)
                    .WithMany(p => p.ArticuloExistencia)
                    .HasForeignKey(d => d.ArCodigo)
                    .HasConstraintName("FK__Articulo___Ar_co__70DDC3D8");

                entity.HasOne(d => d.Ub)
                    .WithMany(p => p.ArticuloExistencia)
                    .HasForeignKey(d => d.UbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Articulo___Ub_id__71D1E811");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.ClId)
                    .HasName("PK__Cliente__E8A0B8CF042B1091");

                entity.ToTable("Cliente");

                entity.Property(e => e.ClId).HasColumnName("Cl_id");

                entity.Property(e => e.ClEmpresa)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Cl_empresa");

                entity.Property(e => e.ClNombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cl_nombre");

                entity.Property(e => e.ClSnte).HasColumnName("Cl_SNTE");

                entity.Property(e => e.ClTelefono)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Cl_telefono");
            });

            modelBuilder.Entity<DesplazamientoArticulo>(entity =>
            {
                entity.HasKey(e => e.DesArId)
                    .HasName("PK__Desplaza__293D2026C8A4A759");

                entity.ToTable("Desplazamiento_Articulo");

                entity.Property(e => e.DesArId).HasColumnName("DesAr_id");

                entity.Property(e => e.DesArFecha)
                    .HasColumnType("date")
                    .HasColumnName("DesAr_Fecha");
            });

            modelBuilder.Entity<DesplazamientoLente>(entity =>
            {
                entity.HasKey(e => e.DesLeId)
                    .HasName("PK__Desplaza__73497E66860A971A");

                entity.ToTable("Desplazamiento_Lentes");

                entity.Property(e => e.DesLeId).HasColumnName("DesLe_id");

                entity.Property(e => e.DesLeFecha)
                    .HasColumnType("date")
                    .HasColumnName("DesLe_Fecha");
            });

            modelBuilder.Entity<DetalleAjusteArticulo>(entity =>
            {
                entity.HasKey(e => e.DetAjuId)
                    .HasName("PK__Detalle___2B38376BF555F3BA");

                entity.ToTable("Detalle_AjusteArticulo");

                entity.Property(e => e.DetAjuId).HasColumnName("DetAju_id");

                entity.Property(e => e.AjuArId).HasColumnName("AjuAr_id");

                entity.Property(e => e.ArCodigo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Ar_codigo");

                entity.Property(e => e.ArticuloCantidad).HasColumnName("Articulo_cantidad");

                entity.Property(e => e.UbOrigenId).HasColumnName("UbOrigen_id");

                entity.HasOne(d => d.ArCodigoNavigation)
                    .WithMany(p => p.DetalleAjusteArticulos)
                    .HasForeignKey(d => d.ArCodigo)
                    .HasConstraintName("FK__Detalle_A__Ar_co__6D0D32F4");

                entity.HasOne(d => d.UbOrigen)
                    .WithMany(p => p.DetalleAjusteArticulos)
                    .HasForeignKey(d => d.UbOrigenId)
                    .HasConstraintName("FK__Detalle_A__UbOri__6E01572D");
            });

            modelBuilder.Entity<DetalleAjusteLente>(entity =>
            {
                entity.HasKey(e => e.DetAjuId)
                    .HasName("PK__Detalle___2B38376BF64184C6");

                entity.ToTable("Detalle_AjusteLentes");

                entity.Property(e => e.DetAjuId).HasColumnName("DetAju_id");

                entity.Property(e => e.AjuLeId).HasColumnName("AjuLe_id");

                entity.Property(e => e.LeCodigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Le_codigo");

                entity.Property(e => e.LentesCantidad).HasColumnName("Lentes_cantidad");

                entity.Property(e => e.UbOrigenId).HasColumnName("UbOrigen_id");

                entity.HasOne(d => d.LeCodigoNavigation)
                    .WithMany(p => p.DetalleAjusteLentes)
                    .HasForeignKey(d => d.LeCodigo)
                    .HasConstraintName("FK__Detalle_A__Le_co__52593CB8");

                entity.HasOne(d => d.UbOrigen)
                    .WithMany(p => p.DetalleAjusteLentes)
                    .HasForeignKey(d => d.UbOrigenId)
                    .HasConstraintName("FK__Detalle_A__UbOri__534D60F1");
            });

            modelBuilder.Entity<DetalleDesplazamientoArticulo>(entity =>
            {
                entity.HasKey(e => e.DetDesId)
                    .HasName("PK__Detalle___233307CD86B254A3");

                entity.ToTable("Detalle_Desplazamiento_Articulo");

                entity.Property(e => e.DetDesId).HasColumnName("DetDes_id");

                entity.Property(e => e.ArCodigo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Ar_codigo");

                entity.Property(e => e.ArticuloCantidad).HasColumnName("Articulo_cantidad");

                entity.Property(e => e.DesArId).HasColumnName("DesAr_id");

                entity.Property(e => e.UbDestinoId).HasColumnName("UbDestino_id");

                entity.Property(e => e.UbOrigenId).HasColumnName("UbOrigen_id");

                entity.HasOne(d => d.ArCodigoNavigation)
                    .WithMany(p => p.DetalleDesplazamientoArticulos)
                    .HasForeignKey(d => d.ArCodigo)
                    .HasConstraintName("FK__Detalle_D__Ar_co__656C112C");

                entity.HasOne(d => d.UbDestino)
                    .WithMany(p => p.DetalleDesplazamientoArticuloUbDestinos)
                    .HasForeignKey(d => d.UbDestinoId)
                    .HasConstraintName("FK__Detalle_D__UbDes__6754599E");

                entity.HasOne(d => d.UbOrigen)
                    .WithMany(p => p.DetalleDesplazamientoArticuloUbOrigens)
                    .HasForeignKey(d => d.UbOrigenId)
                    .HasConstraintName("FK__Detalle_D__UbOri__66603565");
            });

            modelBuilder.Entity<DetalleDesplazamientoLente>(entity =>
            {
                entity.HasKey(e => e.DetDesId)
                    .HasName("PK__Detalle___233307CD554F6069");

                entity.ToTable("Detalle_Desplazamiento_Lentes");

                entity.Property(e => e.DetDesId).HasColumnName("DetDes_id");

                entity.Property(e => e.DesLeId).HasColumnName("DesLe_id");

                entity.Property(e => e.LeCodigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Le_codigo");

                entity.Property(e => e.LentesCantidad).HasColumnName("Lentes_cantidad");

                entity.Property(e => e.UbDestinoId).HasColumnName("UbDestino_id");

                entity.Property(e => e.UbOrigenId).HasColumnName("UbOrigen_id");

                entity.HasOne(d => d.LeCodigoNavigation)
                    .WithMany(p => p.DetalleDesplazamientoLentes)
                    .HasForeignKey(d => d.LeCodigo)
                    .HasConstraintName("FK__Detalle_D__Le_co__4AB81AF0");

                entity.HasOne(d => d.UbDestino)
                    .WithMany(p => p.DetalleDesplazamientoLenteUbDestinos)
                    .HasForeignKey(d => d.UbDestinoId)
                    .HasConstraintName("FK__Detalle_D__UbDes__4CA06362");

                entity.HasOne(d => d.UbOrigen)
                    .WithMany(p => p.DetalleDesplazamientoLenteUbOrigens)
                    .HasForeignKey(d => d.UbOrigenId)
                    .HasConstraintName("FK__Detalle_D__UbOri__4BAC3F29");
            });

            modelBuilder.Entity<DetalleEntradaArticulo>(entity =>
            {
                entity.HasKey(e => e.DetEnId)
                    .HasName("PK__Detalle___F965D88523EEBC34");

                entity.ToTable("Detalle_Entrada_Articulo");

                entity.Property(e => e.DetEnId).HasColumnName("DetEn_id");

                entity.Property(e => e.ArCodigo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Ar_codigo");

                entity.Property(e => e.ArticuloCantidad).HasColumnName("Articulo_cantidad");

                entity.Property(e => e.EnArId).HasColumnName("EnAr_id");

                entity.Property(e => e.PrecioArticuloEntrada)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Precio_articulo_Entrada");

                entity.Property(e => e.UbDestinoId).HasColumnName("UbDestino_id");

                entity.HasOne(d => d.ArCodigoNavigation)
                    .WithMany(p => p.DetalleEntradaArticulos)
                    .HasForeignKey(d => d.ArCodigo)
                    .HasConstraintName("FK__Detalle_E__Ar_co__5812160E");

                entity.HasOne(d => d.UbDestino)
                    .WithMany(p => p.DetalleEntradaArticulos)
                    .HasForeignKey(d => d.UbDestinoId)
                    .HasConstraintName("FK__Detalle_E__UbDes__59063A47");
            });

            modelBuilder.Entity<DetalleEntradaLente>(entity =>
            {
                entity.HasKey(e => e.DetEnId)
                    .HasName("PK__Detalle___F965D885BEB76823");

                entity.ToTable("Detalle_Entrada_Lentes");

                entity.Property(e => e.DetEnId).HasColumnName("DetEn_id");

                entity.Property(e => e.EnLeId).HasColumnName("EnLe_id");

                entity.Property(e => e.LeCodigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Le_codigo");

                entity.Property(e => e.LentesCantidad).HasColumnName("Lentes_cantidad");

                entity.Property(e => e.PrecioLentesEntrada)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Precio_lentes_Entrada");

                entity.Property(e => e.UbDestinoId).HasColumnName("UbDestino_id");

                entity.HasOne(d => d.LeCodigoNavigation)
                    .WithMany(p => p.DetalleEntradaLentes)
                    .HasForeignKey(d => d.LeCodigo)
                    .HasConstraintName("FK__Detalle_E__Le_co__3D5E1FD2");

                entity.HasOne(d => d.UbDestino)
                    .WithMany(p => p.DetalleEntradaLentes)
                    .HasForeignKey(d => d.UbDestinoId)
                    .HasConstraintName("FK__Detalle_E__UbDes__3E52440B");
            });

            modelBuilder.Entity<DetalleSalidaArticulo>(entity =>
            {
                entity.HasKey(e => e.DetSaId)
                    .HasName("PK__Detalle___7077E47F9D24C052");

                entity.ToTable("Detalle_Salida_Articulo");

                entity.Property(e => e.DetSaId).HasColumnName("DetSa_id");

                entity.Property(e => e.ArCodigo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Ar_codigo");

                entity.Property(e => e.ArticuloCantidad).HasColumnName("Articulo_cantidad");

                entity.Property(e => e.PrecioArticuloSalida)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Precio_articulo_salida");

                entity.Property(e => e.SaArId).HasColumnName("SaAr_id");

                entity.Property(e => e.UbOrigenId).HasColumnName("UbOrigen_id");

                entity.HasOne(d => d.ArCodigoNavigation)
                    .WithMany(p => p.DetalleSalidaArticulos)
                    .HasForeignKey(d => d.ArCodigo)
                    .HasConstraintName("FK__Detalle_S__Ar_co__5FB337D6");

                entity.HasOne(d => d.UbOrigen)
                    .WithMany(p => p.DetalleSalidaArticulos)
                    .HasForeignKey(d => d.UbOrigenId)
                    .HasConstraintName("FK__Detalle_S__UbOri__60A75C0F");
            });

            modelBuilder.Entity<DetalleSalidaLente>(entity =>
            {
                entity.HasKey(e => e.DetSaId)
                    .HasName("PK__Detalle___7077E47F3C4AF842");

                entity.ToTable("Detalle_Salida_Lentes");

                entity.Property(e => e.DetSaId).HasColumnName("DetSa_id");

                entity.Property(e => e.LeCodigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Le_codigo");

                entity.Property(e => e.LentesCantidad).HasColumnName("Lentes_cantidad");

                entity.Property(e => e.PrecioLentesSalida)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Precio_lentes_Salida");

                entity.Property(e => e.SaLeId).HasColumnName("SaLe_id");

                entity.Property(e => e.UbOrigenId).HasColumnName("UbOrigen_id");

                entity.HasOne(d => d.LeCodigoNavigation)
                    .WithMany(p => p.DetalleSalidaLentes)
                    .HasForeignKey(d => d.LeCodigo)
                    .HasConstraintName("FK__Detalle_S__Le_co__44FF419A");

                entity.HasOne(d => d.UbOrigen)
                    .WithMany(p => p.DetalleSalidaLentes)
                    .HasForeignKey(d => d.UbOrigenId)
                    .HasConstraintName("FK__Detalle_S__UbOri__45F365D3");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.EmId)
                    .HasName("PK__Empleado__AF7DA9A1737F7C8A");

                entity.ToTable("Empleado");

                entity.Property(e => e.EmId).HasColumnName("Em_id");

                entity.Property(e => e.EmNombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Em_nombre");
            });

            modelBuilder.Entity<EntradaArticulo>(entity =>
            {
                entity.HasKey(e => e.EnArId)
                    .HasName("PK__Entrada___207CDF5CB94C8781");

                entity.ToTable("Entrada_Articulo");

                entity.Property(e => e.EnArId).HasColumnName("EnAr_id");

                entity.Property(e => e.EnArFecha)
                    .HasColumnType("date")
                    .HasColumnName("EnAr_Fecha");
            });

            modelBuilder.Entity<EntradaLente>(entity =>
            {
                entity.HasKey(e => e.EnLeId)
                    .HasName("PK__Entrada___B101C88747283669");

                entity.ToTable("Entrada_Lentes");

                entity.Property(e => e.EnLeId).HasColumnName("EnLe_id");

                entity.Property(e => e.EnLeFecha)
                    .HasColumnType("date")
                    .HasColumnName("EnLe_Fecha");
            });

            modelBuilder.Entity<Lente>(entity =>
            {
                entity.HasKey(e => e.LeCodigo)
                    .HasName("PK__Lentes__3600CA0F2AD47E44");

                entity.Property(e => e.LeCodigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Le_codigo");

                entity.Property(e => e.LeColor)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Le_color");

                entity.Property(e => e.LeDescripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Le_descripcion");

                entity.Property(e => e.LeImagen)
                    .HasColumnType("image")
                    .HasColumnName("Le_imagen");

                entity.Property(e => e.LeNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Le_nombre");

                entity.Property(e => e.LePrecio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Le_precio");

                entity.Property(e => e.MarcaId).HasColumnName("Marca_id");

                entity.Property(e => e.TipoLId).HasColumnName("TipoL_id");

                entity.HasOne(d => d.Marca)
                    .WithMany(p => p.Lentes)
                    .HasForeignKey(d => d.MarcaId)
                    .HasConstraintName("FK__Lentes__Marca_id__34C8D9D1");

                entity.HasOne(d => d.TipoL)
                    .WithMany(p => p.Lentes)
                    .HasForeignKey(d => d.TipoLId)
                    .HasConstraintName("FK__Lentes__TipoL_id__35BCFE0A");
            });

            modelBuilder.Entity<LentesExistencium>(entity =>
            {
                entity.HasKey(e => e.LeEId)
                    .HasName("PK__Lentes_E__3F40423877668D5C");

                entity.ToTable("Lentes_Existencia");

                entity.Property(e => e.LeEId).HasColumnName("LeE_id");

                entity.Property(e => e.LeCodigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Le_codigo");

                entity.Property(e => e.LeEExistencia).HasColumnName("LeE_Existencia");

                entity.Property(e => e.LeEUltimaFechaActualizacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LeE_UltimaFechaActualizacion");

                entity.Property(e => e.LeEUltimaHoraActualizacion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("LeE_UltimaHoraActualizacion");

                entity.Property(e => e.UbId).HasColumnName("Ub_id");

                entity.HasOne(d => d.LeCodigoNavigation)
                    .WithMany(p => p.LentesExistencia)
                    .HasForeignKey(d => d.LeCodigo)
                    .HasConstraintName("FK__Lentes_Ex__Le_co__74AE54BC");

                entity.HasOne(d => d.Ub)
                    .WithMany(p => p.LentesExistencia)
                    .HasForeignKey(d => d.UbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lentes_Ex__Ub_id__75A278F5");
            });

            modelBuilder.Entity<MarcaLente>(entity =>
            {
                entity.HasKey(e => e.MarcaId)
                    .HasName("PK__Marca_Le__5546B22C0C71B83D");

                entity.ToTable("Marca_Lentes");

                entity.Property(e => e.MarcaId).HasColumnName("Marca_id");

                entity.Property(e => e.MarcaNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Marca_nombre");
            });

            modelBuilder.Entity<RolUsuario>(entity =>
            {
                entity.HasKey(e => e.RolUId)
                    .HasName("PK__Rol_Usua__337A9F67E059D251");

                entity.ToTable("Rol_Usuario");

                entity.Property(e => e.RolUId).HasColumnName("RolU_id");

                entity.Property(e => e.RolUNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RolU_nombre");
            });

            modelBuilder.Entity<SalidaArticulo>(entity =>
            {
                entity.HasKey(e => e.SaArId)
                    .HasName("PK__Salida_A__4B03AFFE91EE5D56");

                entity.ToTable("Salida_Articulo");

                entity.Property(e => e.SaArId).HasColumnName("SaAr_id");

                entity.Property(e => e.ClId).HasColumnName("Cl_id");

                entity.Property(e => e.EmId).HasColumnName("Em_id");

                entity.Property(e => e.SaArFecha)
                    .HasColumnType("date")
                    .HasColumnName("SaAr_Fecha");

                entity.HasOne(d => d.Cl)
                    .WithMany(p => p.SalidaArticulos)
                    .HasForeignKey(d => d.ClId)
                    .HasConstraintName("FK__Salida_Ar__Cl_id__5BE2A6F2");

                entity.HasOne(d => d.Em)
                    .WithMany(p => p.SalidaArticulos)
                    .HasForeignKey(d => d.EmId)
                    .HasConstraintName("FK__Salida_Ar__Em_id__5CD6CB2B");
            });

            modelBuilder.Entity<SalidaLente>(entity =>
            {
                entity.HasKey(e => e.SaLeId)
                    .HasName("PK__Salida_L__7954F610AC17ACE9");

                entity.ToTable("Salida_Lentes");

                entity.Property(e => e.SaLeId).HasColumnName("SaLe_id");

                entity.Property(e => e.ClId).HasColumnName("Cl_id");

                entity.Property(e => e.EmId).HasColumnName("Em_id");

                entity.Property(e => e.SaLeFecha)
                    .HasColumnType("date")
                    .HasColumnName("SaLe_Fecha");

                entity.HasOne(d => d.Cl)
                    .WithMany(p => p.SalidaLentes)
                    .HasForeignKey(d => d.ClId)
                    .HasConstraintName("FK__Salida_Le__Cl_id__412EB0B6");

                entity.HasOne(d => d.Em)
                    .WithMany(p => p.SalidaLentes)
                    .HasForeignKey(d => d.EmId)
                    .HasConstraintName("FK__Salida_Le__Em_id__4222D4EF");
            });

            modelBuilder.Entity<TipoArticulo>(entity =>
            {
                entity.HasKey(e => e.TipoAId)
                    .HasName("PK__Tipo_Art__F45FB5F046DD67E8");

                entity.ToTable("Tipo_Articulo");

                entity.Property(e => e.TipoAId).HasColumnName("TipoA_id");

                entity.Property(e => e.TipoADescripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TipoA_descripcion");

                entity.Property(e => e.TipoANombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TipoA_nombre");
            });

            modelBuilder.Entity<TipoLente>(entity =>
            {
                entity.HasKey(e => e.TipoLId)
                    .HasName("PK__Tipo_Len__1FC4FF1912C74B26");

                entity.ToTable("Tipo_Lentes");

                entity.Property(e => e.TipoLId).HasColumnName("TipoL_id");

                entity.Property(e => e.TipoLDescripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TipoL_descripcion");

                entity.Property(e => e.TipoLNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TipoL_nombre");
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.HasKey(e => e.UbId)
                    .HasName("PK__Ubicacio__7AAC0C9236D549E6");

                entity.ToTable("Ubicacion");

                entity.Property(e => e.UbId).HasColumnName("Ub_id");

                entity.Property(e => e.UbDescripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Ub_descripcion");

                entity.Property(e => e.UbNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ub_nombre");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsId)
                    .HasName("PK__Usuario__60D32D0150D702CB");

                entity.ToTable("Usuario");

                entity.Property(e => e.UsId).HasColumnName("Us_id");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.RolUId).HasColumnName("RolU_id");

                entity.Property(e => e.UsClave)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Us_clave");

                entity.Property(e => e.UsUsuario)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Us_usuario");

                entity.HasOne(d => d.RolU)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolUId)
                    .HasConstraintName("FK__Usuario__RolU_id__31EC6D26");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
