using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_encabezado")]
    public partial class OcEncabezado
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Key]
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Column("fecha_orden", TypeName = "date")]
        public DateTime FechaOrden { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Required]
        [Column("incoterm")]
        [StringLength(3)]
        public string Incoterm { get; set; }
        [Required]
        [Column("consignatario")]
        [StringLength(10)]
        public string Consignatario { get; set; }
        [Column("destinatario")]
        [StringLength(3)]
        public string Destinatario { get; set; }
        [Column("serie_orden_compra")]
        [StringLength(2)]
        public string SerieOrdenCompra { get; set; }
        [Column("compania")]
        [StringLength(4)]
        public string Compania { get; set; }
        [Column("fecha_procesada", TypeName = "datetime")]
        public DateTime? FechaProcesada { get; set; }
        [Column("fecha_operacion", TypeName = "datetime")]
        public DateTime? FechaOperacion { get; set; }
        [Column("status_orden")]
        public short StatusOrden { get; set; }
        [Column("incoterm_destino")]
        [StringLength(50)]
        public string IncotermDestino { get; set; }
        [Column("nueva_fecha_orden", TypeName = "datetime")]
        public DateTime? NuevaFechaOrden { get; set; }
    }
}
