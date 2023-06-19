using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class SalidaArticulo
    {
        public int SaArId { get; set; }
        public DateTime SaArFecha { get; set; }
        public int? ClId { get; set; }
        public int? EmId { get; set; }

        public virtual Cliente? Cl { get; set; }
        public virtual Empleado? Em { get; set; }
    }
}
