using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            SalidaArticulos = new HashSet<SalidaArticulo>();
            SalidaLentes = new HashSet<SalidaLente>();
        }

        public int ClId { get; set; }
        public string? ClNombre { get; set; }
        public string? ClTelefono { get; set; }
        public string? ClEmpresa { get; set; }
        public bool? ClSnte { get; set; }

        public virtual ICollection<SalidaArticulo> SalidaArticulos { get; set; }
        public virtual ICollection<SalidaLente> SalidaLentes { get; set; }
    }
}
