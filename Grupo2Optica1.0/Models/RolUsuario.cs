using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class RolUsuario
    {
        public RolUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int RolUId { get; set; }
        public string? RolUNombre { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
