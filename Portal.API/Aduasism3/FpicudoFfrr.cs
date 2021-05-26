using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpicudo_ffrr")]
    [Index(nameof(Rowguid), Name = "index_1663344990", IsUnique = true)]
    public partial class FpicudoFfrr
    {
        [Key]
        [Column("id_cruce")]
        [StringLength(6)]
        public string IdCruce { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_escape")]
        public int IdEscape { get; set; }
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Column("fecha_arrastre", TypeName = "datetime")]
        public DateTime? FechaArrastre { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
