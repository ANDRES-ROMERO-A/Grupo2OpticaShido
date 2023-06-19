using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class DetalleSalidaLente
    {
        public int DetSaId { get; set; }
        public int SaLeId { get; set; }
        public string? LeCodigo { get; set; }
        public int? UbOrigenId { get; set; }
        public int LentesCantidad { get; set; }
        public decimal PrecioLentesSalida { get; set; }

        public virtual Lente? LeCodigoNavigation { get; set; }
        public virtual Ubicacion? UbOrigen { get; set; }
    }
}
