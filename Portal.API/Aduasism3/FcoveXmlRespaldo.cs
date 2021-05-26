using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcove_xml_respaldo")]
    public partial class FcoveXmlRespaldo
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("identificador", TypeName = "numeric(9, 0)")]
        public decimal Identificador { get; set; }
        [Key]
        [Column("movimiento")]
        [StringLength(1)]
        public string Movimiento { get; set; }
        [Key]
        [Column("request")]
        [StringLength(1)]
        public string Request { get; set; }
        [Key]
        [Column("numero_transaccion")]
        [StringLength(15)]
        public string NumeroTransaccion { get; set; }
        [Column("xml")]
        public string Xml { get; set; }
    }
}
