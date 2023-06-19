using System;
using System.Collections.Generic;

namespace Grupo2Optica1._0.Models
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            ArticuloExistencia = new HashSet<ArticuloExistencium>();
            DetalleAjusteArticulos = new HashSet<DetalleAjusteArticulo>();
            DetalleAjusteLentes = new HashSet<DetalleAjusteLente>();
            DetalleDesplazamientoArticuloUbDestinos = new HashSet<DetalleDesplazamientoArticulo>();
            DetalleDesplazamientoArticuloUbOrigens = new HashSet<DetalleDesplazamientoArticulo>();
            DetalleDesplazamientoLenteUbDestinos = new HashSet<DetalleDesplazamientoLente>();
            DetalleDesplazamientoLenteUbOrigens = new HashSet<DetalleDesplazamientoLente>();
            DetalleEntradaArticulos = new HashSet<DetalleEntradaArticulo>();
            DetalleEntradaLentes = new HashSet<DetalleEntradaLente>();
            DetalleSalidaArticulos = new HashSet<DetalleSalidaArticulo>();
            DetalleSalidaLentes = new HashSet<DetalleSalidaLente>();
            LentesExistencia = new HashSet<LentesExistencium>();
        }

        public int UbId { get; set; }
        public string UbNombre { get; set; } = null!;
        public string? UbDescripcion { get; set; }

        public virtual ICollection<ArticuloExistencium> ArticuloExistencia { get; set; }
        public virtual ICollection<DetalleAjusteArticulo> DetalleAjusteArticulos { get; set; }
        public virtual ICollection<DetalleAjusteLente> DetalleAjusteLentes { get; set; }
        public virtual ICollection<DetalleDesplazamientoArticulo> DetalleDesplazamientoArticuloUbDestinos { get; set; }
        public virtual ICollection<DetalleDesplazamientoArticulo> DetalleDesplazamientoArticuloUbOrigens { get; set; }
        public virtual ICollection<DetalleDesplazamientoLente> DetalleDesplazamientoLenteUbDestinos { get; set; }
        public virtual ICollection<DetalleDesplazamientoLente> DetalleDesplazamientoLenteUbOrigens { get; set; }
        public virtual ICollection<DetalleEntradaArticulo> DetalleEntradaArticulos { get; set; }
        public virtual ICollection<DetalleEntradaLente> DetalleEntradaLentes { get; set; }
        public virtual ICollection<DetalleSalidaArticulo> DetalleSalidaArticulos { get; set; }
        public virtual ICollection<DetalleSalidaLente> DetalleSalidaLentes { get; set; }
        public virtual ICollection<LentesExistencium> LentesExistencia { get; set; }
    }
}
