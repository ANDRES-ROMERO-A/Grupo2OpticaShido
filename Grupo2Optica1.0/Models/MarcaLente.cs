using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class MarcaLente
    {
        public MarcaLente()
        {
            Lentes = new HashSet<Lente>();
        }

        public int MarcaId { get; set; }
        public string MarcaNombre { get; set; } = null!;

        public virtual ICollection<Lente> Lentes { get; set; }
    }
}
