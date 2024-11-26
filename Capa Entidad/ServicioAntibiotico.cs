using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class ServicioAntibiotico
{
    public int IdServicioAntibitocio { get; set; }

    public int? IdServicio { get; set; }

    public int? IdAntibiotico { get; set; }

    public virtual ICollection<DatosVigilancium> DatosVigilancia { get; set; } = new List<DatosVigilancium>();

    public virtual Antibiotico? IdAntibioticoNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }
}
