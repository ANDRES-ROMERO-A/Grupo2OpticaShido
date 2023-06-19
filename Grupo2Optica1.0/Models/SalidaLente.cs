using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class SalidaLente
    {
        public int SaLeId { get; set; }
        public DateTime SaLeFecha { get; set; }
        public int? ClId { get; set; }
        public int? EmId { get; set; }

        public virtual Cliente? Cl { get; set; }
        public virtual Empleado? Em { get; set; }
    }
}
