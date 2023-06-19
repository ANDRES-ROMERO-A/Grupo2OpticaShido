using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class AjusteLente
    {
        public int AjuLeId { get; set; }
        public DateTime AjuLeFecha { get; set; }
        public int? UsId { get; set; }

        public virtual Usuario? Us { get; set; }
    }
}
