using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("foliador_bc")]
    public partial class FoliadorBc
    {
        [Key]
        [Column("parametro")]
        [StringLength(20)]
        public string Parametro { get; set; }
        [Key]
        [Column("sucursal")]
        [StringLength(8)]
        public string Sucursal { get; set; }
        [Key]
        [Column("tipo_folio")]
        [StringLength(4)]
        public string TipoFolio { get; set; }
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Column("ultimo_folio")]
        public int? UltimoFolio { get; set; }
        [Column("companynbr")]
        public int? Companynbr { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(8)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(8)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
    }
}
