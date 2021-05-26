using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("oc_producto_observacion_detalle")]
    public partial class OcProductoObservacionDetalle
    {
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("ficha_tecnica")]
        public bool? FichaTecnica { get; set; }
        [Column("certificado_MTR")]
        public bool? CertificadoMtr { get; set; }
        [Column("certificado_MSDS")]
        public bool? CertificadoMsds { get; set; }
        [Column("certificado_analisis")]
        public bool? CertificadoAnalisis { get; set; }
        [Column("parte_funcion")]
        public bool? ParteFuncion { get; set; }
        [Column("solicitar_factura")]
        public bool? SolicitarFactura { get; set; }
        [Column("falta_previo")]
        public bool? FaltaPrevio { get; set; }
        [Column("falta_foto")]
        public bool? FaltaFoto { get; set; }
        [Column("otros")]
        public bool? Otros { get; set; }

        [ForeignKey("IdCliente,TipoOperacion,IdProducto")]
        public virtual OcProducto OcProducto { get; set; }
    }
}
