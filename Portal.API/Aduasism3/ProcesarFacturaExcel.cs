using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("procesar_factura_excel")]
    public partial class ProcesarFacturaExcel
    {
        [Key]
        [Column("procesar_factura_excel_id")]
        public short ProcesarFacturaExcelId { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
    }
}
