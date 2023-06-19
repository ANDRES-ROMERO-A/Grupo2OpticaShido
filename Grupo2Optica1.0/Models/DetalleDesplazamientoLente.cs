using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class DetalleDesplazamientoLente
    {
        public int DetDesId { get; set; }
        public int DesLeId { get; set; }
        public string? LeCodigo { get; set; }
        public int? UbOrigenId { get; set; }
        public int? UbDestinoId { get; set; }
        public int LentesCantidad { get; set; }

        public virtual Lente? LeCodigoNavigation { get; set; }
        public virtual Ubicacion? UbDestino { get; set; }
        public virtual Ubicacion? UbOrigen { get; set; }
    }
}
