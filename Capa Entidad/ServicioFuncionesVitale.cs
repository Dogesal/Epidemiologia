using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class ServicioFuncionesVitale
{
    public int IdServicioFuncionesVitales { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFuncionesVitales { get; set; }

    public virtual ICollection<DatosVigilancium> DatosVigilancia { get; set; } = new List<DatosVigilancium>();

    public virtual FuncionesVitale? IdFuncionesVitalesNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }
}
