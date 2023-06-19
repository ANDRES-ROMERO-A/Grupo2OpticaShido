using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class LentesExistencium
    {
        public int LeEId { get; set; }
        public string? LeCodigo { get; set; }
        public int UbId { get; set; }
        public int LeEExistencia { get; set; }
        public string LeEUltimaFechaActualizacion { get; set; } = null!;
        public string LeEUltimaHoraActualizacion { get; set; } = null!;

        public virtual Lente? LeCodigoNavigation { get; set; }
        public virtual Ubicacion Ub { get; set; } = null!;
    }
}
