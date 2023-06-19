using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class TipoArticulo
    {
        public TipoArticulo()
        {
            Articulos = new HashSet<Articulo>();
        }

        public int TipoAId { get; set; }
        public string TipoANombre { get; set; } = null!;
        public string? TipoADescripcion { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
