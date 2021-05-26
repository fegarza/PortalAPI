using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("pdf_entrada")]
    public partial class PdfEntradum
    {
        [Key]
        [Column("id_pdf", TypeName = "numeric(18, 0)")]
        public decimal IdPdf { get; set; }
        [Key]
        [Column("entrada")]
        [StringLength(10)]
        public string Entrada { get; set; }
        [Column("ruta_pdf")]
        [StringLength(200)]
        public string RutaPdf { get; set; }
    }
}
