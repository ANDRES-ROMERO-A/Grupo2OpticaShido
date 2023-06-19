using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class Lente
    {
        public Lente()
        {
            DetalleAjusteLentes = new HashSet<DetalleAjusteLente>();
            DetalleDesplazamientoLentes = new HashSet<DetalleDesplazamientoLente>();
            DetalleEntradaLentes = new HashSet<DetalleEntradaLente>();
            DetalleSalidaLentes = new HashSet<DetalleSalidaLente>();
            LentesExistencia = new HashSet<LentesExistencium>();
        }

        public string LeCodigo { get; set; } = null!;
        public string LeNombre { get; set; } = null!;
        public int? MarcaId { get; set; }
        public int? TipoLId { get; set; }
        public string? LeDescripcion { get; set; }
        public string? LeColor { get; set; }
        public byte[]? LeImagen { get; set; }
        public decimal LePrecio { get; set; }

        public virtual MarcaLente? Marca { get; set; }
        public virtual TipoLente? TipoL { get; set; }
        public virtual ICollection<DetalleAjusteLente> DetalleAjusteLentes { get; set; }
        public virtual ICollection<DetalleDesplazamientoLente> DetalleDesplazamientoLentes { get; set; }
        public virtual ICollection<DetalleEntradaLente> DetalleEntradaLentes { get; set; }
        public virtual ICollection<DetalleSalidaLente> DetalleSalidaLentes { get; set; }
        public virtual ICollection<LentesExistencium> LentesExistencia { get; set; }
    }
}
