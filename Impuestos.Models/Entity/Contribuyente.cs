using System;
using System.Collections.Generic;

namespace Impuestos.Models;

public partial class Contribuyente
{
    public string RncCedula { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }

    public string? Estatus { get; set; }

    public virtual ICollection<ComprobantesFiscale> ComprobantesFiscales { get; } = new List<ComprobantesFiscale>();
}
