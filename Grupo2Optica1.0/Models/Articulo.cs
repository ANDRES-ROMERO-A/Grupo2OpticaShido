using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class Articulo
    {
        public Articulo()
        {
            ArticuloExistencia = new HashSet<ArticuloExistencium>();
            DetalleAjusteArticulos = new HashSet<DetalleAjusteArticulo>();
            DetalleDesplazamientoArticulos = new HashSet<DetalleDesplazamientoArticulo>();
            DetalleEntradaArticulos = new HashSet<DetalleEntradaArticulo>();
            DetalleSalidaArticulos = new HashSet<DetalleSalidaArticulo>();
        }

        public string ArCodigo { get; set; } = null!;
        public string ArNombre { get; set; } = null!;
        public string? ArDescripcion { get; set; }
        public byte[]? ArImagen { get; set; }
        public decimal? ArPrecio { get; set; }
        public int? TipoAId { get; set; }

        public virtual TipoArticulo? TipoA { get; set; }
        public virtual ICollection<ArticuloExistencium> ArticuloExistencia { get; set; }
        public virtual ICollection<DetalleAjusteArticulo> DetalleAjusteArticulos { get; set; }
        public virtual ICollection<DetalleDesplazamientoArticulo> DetalleDesplazamientoArticulos { get; set; }
        public virtual ICollection<DetalleEntradaArticulo> DetalleEntradaArticulos { get; set; }
        public virtual ICollection<DetalleSalidaArticulo> DetalleSalidaArticulos { get; set; }
    }
}
