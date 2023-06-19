using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class DetalleAjusteLente
    {
        public int DetAjuId { get; set; }
        public int AjuLeId { get; set; }
        public string? LeCodigo { get; set; }
        public int? UbOrigenId { get; set; }
        public int LentesCantidad { get; set; }

        public virtual Lente? LeCodigoNavigation { get; set; }
        public virtual Ubicacion? UbOrigen { get; set; }
    }
}
