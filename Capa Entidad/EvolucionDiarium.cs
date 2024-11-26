using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class EvolucionDiarium
{
    public int IdEvolucionDiaria { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual ICollection<Reporte> Reportes { get; set; } = new List<Reporte>();
}
