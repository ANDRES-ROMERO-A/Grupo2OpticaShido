using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class DetalleEntradaLente
    {
        public int DetEnId { get; set; }
        public int EnLeId { get; set; }
        public string? LeCodigo { get; set; }
        public int? UbDestinoId { get; set; }
        public int LentesCantidad { get; set; }
        public decimal PrecioLentesEntrada { get; set; }

        public virtual Lente? LeCodigoNavigation { get; set; }
        public virtual Ubicacion? UbDestino { get; set; }
    }
}
