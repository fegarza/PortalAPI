using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsolicitud_encargo")]
    [Index(nameof(Rowguid), Name = "index_1965302111", IsUnique = true)]
    public partial class FsolicitudEncargo
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
        [Column("tipo_act")]
        public int? TipoAct { get; set; }
        [Column("firma")]
        [StringLength(8)]
        public string Firma { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime FechaReg { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
