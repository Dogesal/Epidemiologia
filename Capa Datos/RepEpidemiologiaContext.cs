using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Capa_Entidad;

public partial class RepEpidemiologiaContext : DbContext
{
    public RepEpidemiologiaContext()
    {
    }

    public RepEpidemiologiaContext(DbContextOptions<RepEpidemiologiaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Antibiotico> Antibioticos { get; set; }

    public virtual DbSet<DatosVigilancium> DatosVigilancia { get; set; }

    public virtual DbSet<DispositivosMedico> DispositivosMedicos { get; set; }

    public virtual DbSet<EvolucionDiarium> EvolucionDiaria { get; set; }

    public virtual DbSet<FuncionesVitale> FuncionesVitales { get; set; }

    public virtual DbSet<Microbiologium> Microbiologia { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<PacienteServicio> PacienteServicios { get; set; }

    public virtual DbSet<Reporte> Reportes { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<ServicioAntibiotico> ServicioAntibioticos { get; set; }

    public virtual DbSet<ServicioDispositivosMedico> ServicioDispositivosMedicos { get; set; }

    public virtual DbSet<ServicioFuncionesVitale> ServicioFuncionesVitales { get; set; }

    public virtual DbSet<ServicioMicrobiologium> ServicioMicrobiologia { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Name=ConnectionStrings:cn");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Antibiotico>(entity =>
        {
            entity.HasKey(e => e.IdAntibiotico).HasName("PK__antibiot__F01F767815E0D03C");

            entity.ToTable("antibiotico");

            entity.Property(e => e.IdAntibiotico).HasColumnName("ID_antibiotico");
            entity.Property(e => e.NombreAntibitocio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_antibitocio");
        });

        modelBuilder.Entity<DatosVigilancium>(entity =>
        {
            entity.HasKey(e => e.IdDatosVigilancia).HasName("PK__datos_vi__102C496191BE81E8");

            entity.ToTable("datos_vigilancia");

            entity.Property(e => e.IdDatosVigilancia).HasColumnName("ID_datos_vigilancia");
            entity.Property(e => e.Datos).HasColumnName("datos");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdServicioAntibiotico).HasColumnName("ID_servicio_antibiotico");
            entity.Property(e => e.IdServicioDispositivoMedico).HasColumnName("ID_servicio_dispositivo_medico");
            entity.Property(e => e.IdServicioFuncionesVitales).HasColumnName("ID_servicio_funciones_vitales");
            entity.Property(e => e.IdServicioMicrobiologia).HasColumnName("ID_servicio_microbiologia");

            entity.HasOne(d => d.IdServicioAntibioticoNavigation).WithMany(p => p.DatosVigilancia)
                .HasForeignKey(d => d.IdServicioAntibiotico)
                .HasConstraintName("FK__datos_vig__ID_se__30F848ED");

            entity.HasOne(d => d.IdServicioDispositivoMedicoNavigation).WithMany(p => p.DatosVigilancia)
                .HasForeignKey(d => d.IdServicioDispositivoMedico)
                .HasConstraintName("FK__datos_vig__ID_se__33D4B598");

            entity.HasOne(d => d.IdServicioFuncionesVitalesNavigation).WithMany(p => p.DatosVigilancia)
                .HasForeignKey(d => d.IdServicioFuncionesVitales)
                .HasConstraintName("FK__datos_vig__ID_se__32E0915F");

            entity.HasOne(d => d.IdServicioMicrobiologiaNavigation).WithMany(p => p.DatosVigilancia)
                .HasForeignKey(d => d.IdServicioMicrobiologia)
                .HasConstraintName("FK__datos_vig__ID_se__31EC6D26");
        });

        modelBuilder.Entity<DispositivosMedico>(entity =>
        {
            entity.HasKey(e => e.IdDispositivosMedicos).HasName("PK__disposit__F3F46CEDCA3E86E1");

            entity.ToTable("dispositivos_medicos");

            entity.Property(e => e.IdDispositivosMedicos).HasColumnName("ID_dispositivos_medicos");
            entity.Property(e => e.NombreDispositivosMedicos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_dispositivos_medicos");
        });

        modelBuilder.Entity<EvolucionDiarium>(entity =>
        {
            entity.HasKey(e => e.IdEvolucionDiaria).HasName("PK__evolucio__F61BE527092FF34A");

            entity.ToTable("evolucion_diaria");

            entity.Property(e => e.IdEvolucionDiaria).HasColumnName("ID_evolucion_diaria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
        });

        modelBuilder.Entity<FuncionesVitale>(entity =>
        {
            entity.HasKey(e => e.IdFuncionesVitales).HasName("PK__funcione__7A9B8C1AC1E80D7E");

            entity.ToTable("funciones_vitales");

            entity.Property(e => e.IdFuncionesVitales).HasColumnName("ID_funciones_vitales");
            entity.Property(e => e.NombreFuncionesVitales)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_funciones_vitales");
        });

        modelBuilder.Entity<Microbiologium>(entity =>
        {
            entity.HasKey(e => e.IdMicrobiologia).HasName("PK__microbio__430B14040A4D6EC6");

            entity.ToTable("microbiologia");

            entity.Property(e => e.IdMicrobiologia).HasColumnName("ID_microbiologia");
            entity.Property(e => e.NombreMicrobiologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_microbiologia");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.IdPaciente).HasName("PK__paciente__68EDE79C3E5FAFD2");

            entity.ToTable("paciente");

            entity.Property(e => e.IdPaciente).HasColumnName("ID_paciente");
            entity.Property(e => e.Diagnostico)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diagnostico");
            entity.Property(e => e.Dni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.Genero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("genero");
            entity.Property(e => e.NombrePaciente)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nombre_paciente");
        });

        modelBuilder.Entity<PacienteServicio>(entity =>
        {
            entity.HasKey(e => e.IdPacienteServicio).HasName("PK__paciente__2B8941269A617C0F");

            entity.ToTable("paciente_servicio");

            entity.Property(e => e.IdPacienteServicio).HasColumnName("ID_paciente_servicio");
            entity.Property(e => e.Active)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("active");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdPaciente).HasColumnName("ID_paciente");
            entity.Property(e => e.IdServicio).HasColumnName("ID_servicio");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.PacienteServicios)
                .HasForeignKey(d => d.IdPaciente)
                .HasConstraintName("FK__paciente___ID_pa__35BCFE0A");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.PacienteServicios)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__paciente___ID_se__34C8D9D1");
        });

        modelBuilder.Entity<Reporte>(entity =>
        {
            entity.HasKey(e => e.IdReporte).HasName("PK__reporte__41AEEB641C03FCC8");

            entity.ToTable("reporte");

            entity.Property(e => e.IdReporte).HasColumnName("ID_reporte");
            entity.Property(e => e.FechaGeneracion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_generacion");
            entity.Property(e => e.IdDatosVigilancia).HasColumnName("ID_datos_vigilancia");
            entity.Property(e => e.IdEvolucionDiaria).HasColumnName("ID_evolucion_diaria");
            entity.Property(e => e.IdPacienteServicio).HasColumnName("ID_paciente_servicio");

            entity.HasOne(d => d.IdDatosVigilanciaNavigation).WithMany(p => p.Reportes)
                .HasForeignKey(d => d.IdDatosVigilancia)
                .HasConstraintName("FK__reporte__ID_dato__36B12243");

            entity.HasOne(d => d.IdEvolucionDiariaNavigation).WithMany(p => p.Reportes)
                .HasForeignKey(d => d.IdEvolucionDiaria)
                .HasConstraintName("FK__reporte__ID_evol__37A5467C");

            entity.HasOne(d => d.IdPacienteServicioNavigation).WithMany(p => p.Reportes)
                .HasForeignKey(d => d.IdPacienteServicio)
                .HasConstraintName("FK__reporte__ID_paci__38996AB5");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicios).HasName("PK__servicio__AADCD9E0073CC929");

            entity.ToTable("servicios");

            entity.Property(e => e.IdServicios).HasColumnName("ID_servicios");
            entity.Property(e => e.NombreServicios)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre_servicios");
        });

        modelBuilder.Entity<ServicioAntibiotico>(entity =>
        {
            entity.HasKey(e => e.IdServicioAntibitocio).HasName("PK__servicio__30D396016329855F");

            entity.ToTable("servicio_antibiotico");

            entity.Property(e => e.IdServicioAntibitocio).HasColumnName("ID_servicio_antibitocio");
            entity.Property(e => e.IdAntibiotico).HasColumnName("ID_antibiotico");
            entity.Property(e => e.IdServicio).HasColumnName("ID_servicio");

            entity.HasOne(d => d.IdAntibioticoNavigation).WithMany(p => p.ServicioAntibioticos)
                .HasForeignKey(d => d.IdAntibiotico)
                .HasConstraintName("FK__servicio___ID_an__29572725");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ServicioAntibioticos)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__servicio___ID_se__2D27B809");
        });

        modelBuilder.Entity<ServicioDispositivosMedico>(entity =>
        {
            entity.HasKey(e => e.IdServicioDispositivosMedicos).HasName("PK__servicio__DDA0B02E369BD92F");

            entity.ToTable("servicio_dispositivos_medicos");

            entity.Property(e => e.IdServicioDispositivosMedicos).HasColumnName("ID_servicio_dispositivos_medicos");
            entity.Property(e => e.IdDispositivosMedicos).HasColumnName("ID_dispositivos_medicos");
            entity.Property(e => e.IdSevicio).HasColumnName("ID_sevicio");

            entity.HasOne(d => d.IdDispositivosMedicosNavigation).WithMany(p => p.ServicioDispositivosMedicos)
                .HasForeignKey(d => d.IdDispositivosMedicos)
                .HasConstraintName("FK__servicio___ID_di__2B3F6F97");

            entity.HasOne(d => d.IdSevicioNavigation).WithMany(p => p.ServicioDispositivosMedicos)
                .HasForeignKey(d => d.IdSevicio)
                .HasConstraintName("FK__servicio___ID_se__2F10007B");
        });

        modelBuilder.Entity<ServicioFuncionesVitale>(entity =>
        {
            entity.HasKey(e => e.IdServicioFuncionesVitales).HasName("PK__servicio__8CA175DE2FB0DC44");

            entity.ToTable("servicio_funciones_vitales");

            entity.Property(e => e.IdServicioFuncionesVitales).HasColumnName("ID_servicio_funciones_vitales");
            entity.Property(e => e.IdFuncionesVitales).HasColumnName("ID_funciones_vitales");
            entity.Property(e => e.IdServicio).HasColumnName("ID_servicio");

            entity.HasOne(d => d.IdFuncionesVitalesNavigation).WithMany(p => p.ServicioFuncionesVitales)
                .HasForeignKey(d => d.IdFuncionesVitales)
                .HasConstraintName("FK__servicio___ID_fu__2A4B4B5E");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ServicioFuncionesVitales)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__servicio___ID_se__2E1BDC42");
        });

        modelBuilder.Entity<ServicioMicrobiologium>(entity =>
        {
            entity.HasKey(e => e.IdServicioMicrobiologia).HasName("PK__servicio__EBB17EEAE4B9520C");

            entity.ToTable("servicio_microbiologia");

            entity.Property(e => e.IdServicioMicrobiologia).HasColumnName("ID_servicio_microbiologia");
            entity.Property(e => e.IdMicrobiologia).HasColumnName("ID_microbiologia");
            entity.Property(e => e.IdServicio).HasColumnName("ID_servicio");

            entity.HasOne(d => d.IdMicrobiologiaNavigation).WithMany(p => p.ServicioMicrobiologia)
                .HasForeignKey(d => d.IdMicrobiologia)
                .HasConstraintName("FK__servicio___ID_mi__2C3393D0");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ServicioMicrobiologia)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__servicio___ID_se__300424B4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
