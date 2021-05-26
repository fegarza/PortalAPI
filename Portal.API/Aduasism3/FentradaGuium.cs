using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fentrada_guia")]
    [Index(nameof(Rowguid), Name = "index_770817808", IsUnique = true)]
    public partial class FentradaGuium
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(5, 0)")]
        public decimal Secuencial { get; set; }
        [Required]
        [Column("cve_tipo_guia")]
        [StringLength(1)]
        public string CveTipoGuia { get; set; }
        [Column("guia")]
        [StringLength(35)]
        public string Guia { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("importe_flete", TypeName = "numeric(10, 2)")]
        public decimal ImporteFlete { get; set; }
        [Column("peso", TypeName = "numeric(14, 2)")]
        public decimal? Peso { get; set; }
    }
}
