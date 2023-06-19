using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            AjusteArticulos = new HashSet<AjusteArticulo>();
            AjusteLentes = new HashSet<AjusteLente>();
        }

        public int UsId { get; set; }
        public string? UsUsuario { get; set; }
        public string? UsClave { get; set; }
        public int? RolUId { get; set; }
        public bool? Estatus { get; set; }

        public virtual RolUsuario? RolU { get; set; }
        public virtual ICollection<AjusteArticulo> AjusteArticulos { get; set; }
        public virtual ICollection<AjusteLente> AjusteLentes { get; set; }
    }
}
