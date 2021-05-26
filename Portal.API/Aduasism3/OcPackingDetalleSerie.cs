using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_packing_detalle_serie")]
    public partial class OcPackingDetalleSerie
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
        [Column("id_packing")]
        [StringLength(15)]
        public string IdPacking { get; set; }
        [Key]
        [Column("secuencial_packing")]
        public int SecuencialPacking { get; set; }
        [Key]
        [Column("secuencial_serie")]
        public int SecuencialSerie { get; set; }
        [Column("marca")]
        [StringLength(100)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Column("sub_modelo")]
        [StringLength(50)]
        public string SubModelo { get; set; }
        [Column("numero_serie")]
        [StringLength(25)]
        public string NumeroSerie { get; set; }
        [Column("procesada")]
        public bool Procesada { get; set; }
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
