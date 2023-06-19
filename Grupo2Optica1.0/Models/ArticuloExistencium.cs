using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class ArticuloExistencium
    {
        public int ArEId { get; set; }
        public string? ArCodigo { get; set; }
        public int UbId { get; set; }
        public int ArEExistencia { get; set; }
        public string ArEUltimaFechaActualizacion { get; set; } = null!;
        public string ArEUltimaHoraActualizacion { get; set; } = null!;

        public virtual Articulo? ArCodigoNavigation { get; set; }
        public virtual Ubicacion Ub { get; set; } = null!;
    }
}
