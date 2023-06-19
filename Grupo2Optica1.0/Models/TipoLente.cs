using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class TipoLente
    {
        public TipoLente()
        {
            Lentes = new HashSet<Lente>();
        }

        public int TipoLId { get; set; }
        public string TipoLNombre { get; set; } = null!;
        public string? TipoLDescripcion { get; set; }

        public virtual ICollection<Lente> Lentes { get; set; }
    }
}
