using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftabulador_plano")]
    public partial class FtabuladorPlano
    {
        [Key]
        [Column("id_tipo_cliente")]
        [StringLength(3)]
        public string IdTipoCliente { get; set; }
        [Key]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Column("imp_unit_importacion", TypeName = "numeric(11, 2)")]
        public decimal ImpUnitImportacion { get; set; }
        [Column("imp_unit_exportacion", TypeName = "numeric(11, 2)")]
        public decimal ImpUnitExportacion { get; set; }
    }
}
