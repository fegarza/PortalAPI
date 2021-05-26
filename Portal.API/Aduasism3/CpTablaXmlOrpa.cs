using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_tabla_xml_orpa")]
    public partial class CpTablaXmlOrpa
    {
        [Key]
        [Column("consecutivo", TypeName = "numeric(18, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("xml")]
        [StringLength(350)]
        public string Xml { get; set; }
        [Column("serie")]
        [StringLength(10)]
        public string Serie { get; set; }
        [Column("folio")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("uuid")]
        [StringLength(50)]
        public string Uuid { get; set; }
        [Column("fecha_proceso", TypeName = "datetime")]
        public DateTime? FechaProceso { get; set; }
        [Column("procesado")]
        [StringLength(10)]
        public string Procesado { get; set; }
        [Column("mensaje")]
        [StringLength(350)]
        public string Mensaje { get; set; }
        [Column("ruta")]
        [StringLength(350)]
        public string Ruta { get; set; }
        [Column("rfc_emisor")]
        [StringLength(15)]
        public string RfcEmisor { get; set; }
        [Column("rfc_receptor")]
        [StringLength(15)]
        public string RfcReceptor { get; set; }
    }
}
