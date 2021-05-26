using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_rel_archivos_envio_pdf")]
    public partial class FfgRelArchivosEnvioPdf
    {
        [Key]
        [Column("id_pdf", TypeName = "numeric(18, 0)")]
        public decimal IdPdf { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("ruta_pdf")]
        [StringLength(200)]
        public string RutaPdf { get; set; }
    }
}
