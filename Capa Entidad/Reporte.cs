using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class Reporte
{
    public int IdReporte { get; set; }

    public DateTime? FechaGeneracion { get; set; }

    public int? IdDatosVigilancia { get; set; }

    public int? IdEvolucionDiaria { get; set; }

    public int? IdPacienteServicio { get; set; }

    public virtual DatosVigilancium? IdDatosVigilanciaNavigation { get; set; }

    public virtual EvolucionDiarium? IdEvolucionDiariaNavigation { get; set; }

    public virtual PacienteServicio? IdPacienteServicioNavigation { get; set; }
}
