using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_inst_packing_detalle_serie")]
    public partial class OcInstPackingDetalleSerie
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Key]
        [Column("id_instruccion")]
        [StringLength(10)]
        public string IdInstruccion { get; set; }
        [Key]
        [Column("id_packing")]
        [StringLength(15)]
        public string IdPacking { get; set; }
        [Key]
        [Column("secuencial_packing")]
        public int SecuencialPacking { get; set; }
        [Key]
        [Column("secuencial_serie")]
        public int SecuencialSerie { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
    }
}
