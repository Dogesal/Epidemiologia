using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class FuncionesVitale
{
    public int IdFuncionesVitales { get; set; }

    public string? NombreFuncionesVitales { get; set; }

    public virtual ICollection<ServicioFuncionesVitale> ServicioFuncionesVitales { get; set; } = new List<ServicioFuncionesVitale>();
}
