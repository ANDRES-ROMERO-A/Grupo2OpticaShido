using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            SalidaArticulos = new HashSet<SalidaArticulo>();
            SalidaLentes = new HashSet<SalidaLente>();
        }

        public int EmId { get; set; }
        public string? EmNombre { get; set; }

        public virtual ICollection<SalidaArticulo> SalidaArticulos { get; set; }
        public virtual ICollection<SalidaLente> SalidaLentes { get; set; }
    }
}
