using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class Antibiotico
{
    public int IdAntibiotico { get; set; }

    public string? NombreAntibitocio { get; set; }

    public virtual ICollection<ServicioAntibiotico> ServicioAntibioticos { get; set; } = new List<ServicioAntibiotico>();
}
