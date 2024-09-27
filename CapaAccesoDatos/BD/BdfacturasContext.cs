using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TallerEvaluativo.CapaAccesoDatos.BD;

public partial class BdfacturasContext : DbContext
{
    public BdfacturasContext()
    {
    }

    public BdfacturasContext(DbContextOptions<BdfacturasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductosPorFactura> ProductosPorFacturas { get; set; }

    public virtual DbSet<Vendedor> Vendedors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PC-MIGUELL\\SQLEXPRESS; Database=BDFacturas; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Cliente__40F9A2073F934DAF");

            entity.ToTable("Cliente");

            entity.Property(e => e.Codigo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.CodigoEmpresa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codigo_empresa");
            entity.Property(e => e.Credito).HasColumnName("credito");

            entity.HasOne(d => d.CodigoNavigation).WithOne(p => p.Cliente)
                .HasForeignKey<Cliente>(d => d.Codigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cliente__codigo__5070F446");

            entity.HasOne(d => d.CodigoEmpresaNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.CodigoEmpresa)
                .HasConstraintName("FK__Cliente__codigo___5165187F");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Empresa__40F9A207D5F9087E");

            entity.ToTable("Empresa");

            entity.Property(e => e.Codigo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Numero).HasName("PK__Factura__FC77F210CE470FB5");

            entity.ToTable("Factura");

            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.CodigoCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codigo_cliente");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.CodigoClienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoCliente)
                .HasConstraintName("FK__Factura__codigo___571DF1D5");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Persona__40F9A20764A4D0DD");

            entity.ToTable("Persona");

            entity.Property(e => e.Codigo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Producto__40F9A2074A6E2E4A");

            entity.ToTable("Producto");

            entity.Property(e => e.Codigo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.ValorUnitario).HasColumnName("valorUnitario");
        });

        modelBuilder.Entity<ProductosPorFactura>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactura, e.CodigoProducto }).HasName("PK__Producto__BCC1A23A2509EE87");

            entity.ToTable("ProductosPorFactura");

            entity.Property(e => e.NumeroFactura).HasColumnName("numero_factura");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Subtotal).HasColumnName("subtotal");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.ProductosPorFacturas)
                .HasForeignKey(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Productos__codig__5AEE82B9");

            entity.HasOne(d => d.NumeroFacturaNavigation).WithMany(p => p.ProductosPorFacturas)
                .HasForeignKey(d => d.NumeroFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Productos__numer__59FA5E80");
        });

        modelBuilder.Entity<Vendedor>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Vendedor__40F9A207554A02F0");

            entity.ToTable("Vendedor");

            entity.Property(e => e.Codigo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Carnet).HasColumnName("carnet");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("direccion");

            entity.HasOne(d => d.CodigoNavigation).WithOne(p => p.Vendedor)
                .HasForeignKey<Vendedor>(d => d.Codigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vendedor__codigo__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}



//Comando por consola para mapear la base de datos y generar automaticamente el DbContext en Visual Studio
//Scaffold-DbContext "Server=TU_SERVIDOR_SQL;Database=TuBaseDeDatos;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir CapaAccesoDatos/BD

//Comando por consola para mapear la base de datos y generar automaticamente el DbContext en Visual Studio Code
//dotnet ef dbcontext scaffold "Server=TU_SERVIDOR_SQL;Database=TuBaseDeDatos;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models
