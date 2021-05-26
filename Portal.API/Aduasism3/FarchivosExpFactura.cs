using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("farchivos_exp_facturas")]
    public partial class FarchivosExpFactura
    {
        [Required]
        [Column("archivo")]
        [StringLength(33)]
        public string Archivo { get; set; }
        [Column("archivodet")]
        [StringLength(33)]
        public string Archivodet { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("cliente")]
        [StringLength(6)]
        public string Cliente { get; set; }
        [Column("factura")]
        [StringLength(15)]
        public string Factura { get; set; }
        [Column("proveedor")]
        [StringLength(6)]
        public string Proveedor { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("tipofac")]
        [StringLength(50)]
        public string Tipofac { get; set; }
        [Column("valorfac", TypeName = "decimal(17, 2)")]
        public decimal? Valorfac { get; set; }
    }
}
