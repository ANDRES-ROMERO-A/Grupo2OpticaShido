using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class DetalleEntradaArticulo
    {
        public int DetEnId { get; set; }
        public int EnArId { get; set; }
        public string? ArCodigo { get; set; }
        public int? UbDestinoId { get; set; }
        public int ArticuloCantidad { get; set; }
        public decimal PrecioArticuloEntrada { get; set; }

        public virtual Articulo? ArCodigoNavigation { get; set; }
        public virtual Ubicacion? UbDestino { get; set; }
    }
}
