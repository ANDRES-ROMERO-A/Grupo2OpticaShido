using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class AjusteArticulo
    {
        public int AjuArId { get; set; }
        public DateTime AjuArFecha { get; set; }
        public int? UsId { get; set; }

        public virtual Usuario? Us { get; set; }
    }
}
