using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsolicitud_251")]
    [Index(nameof(Rowguid), Name = "index_1981302168", IsUnique = true)]
    public partial class Fsolicitud251
    {
        [Key]
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Key]
        [Column("CURP")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Key]
        [Column("folio")]
        [StringLength(7)]
        public string Folio { get; set; }
        [Key]
        [Column("num_cons")]
        public int NumCons { get; set; }
        [Key]
        [Column("RFC")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Key]
        [Column("operacion")]
        [StringLength(1)]
        public string Operacion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
