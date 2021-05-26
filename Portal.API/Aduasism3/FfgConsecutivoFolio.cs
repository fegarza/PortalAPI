using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_consecutivo_folio")]
    public partial class FfgConsecutivoFolio
    {
        [Column("consecutivo_folio", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoFolio { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("serie")]
        [StringLength(10)]
        public string Serie { get; set; }
        [Key]
        [Column("folio_inicial", TypeName = "numeric(7, 0)")]
        public decimal FolioInicial { get; set; }
        [Column("folio_final", TypeName = "numeric(7, 0)")]
        public decimal FolioFinal { get; set; }
        [Column("consecutivo_folio_elect", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoFolioElect { get; set; }
        [Column("no_Aprobacion", TypeName = "numeric(14, 0)")]
        public decimal NoAprobacion { get; set; }
        [Required]
        [Column("anio_Aprobacion")]
        [StringLength(4)]
        public string AnioAprobacion { get; set; }
        [Required]
        [Column("activo")]
        [StringLength(1)]
        public string Activo { get; set; }
    }
}
