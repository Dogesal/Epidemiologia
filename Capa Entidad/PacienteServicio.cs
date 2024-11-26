using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class PacienteServicio
{
    public int IdPacienteServicio { get; set; }

    public int? IdPaciente { get; set; }

    public int? IdServicio { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaFin { get; set; }

    public string? Active { get; set; }

    public virtual Paciente? IdPacienteNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }

    public virtual ICollection<Reporte> Reportes { get; set; } = new List<Reporte>();
}
