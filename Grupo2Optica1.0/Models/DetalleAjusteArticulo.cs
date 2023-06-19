using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class DetalleAjusteArticulo
    {
        public int DetAjuId { get; set; }
        public int AjuArId { get; set; }
        public string? ArCodigo { get; set; }
        public int? UbOrigenId { get; set; }
        public int ArticuloCantidad { get; set; }

        public virtual Articulo? ArCodigoNavigation { get; set; }
        public virtual Ubicacion? UbOrigen { get; set; }
    }
}
