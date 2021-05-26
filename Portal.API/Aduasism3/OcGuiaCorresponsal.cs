using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_guia_corresponsal")]
    public partial class OcGuiaCorresponsal
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
        [Column("secuencial_guia")]
        public short SecuencialGuia { get; set; }
        [Required]
        [Column("tipo_guia")]
        [StringLength(1)]
        public string TipoGuia { get; set; }
        [Required]
        [Column("numero_guia")]
        [StringLength(35)]
        public string NumeroGuia { get; set; }
        [Column("fecha_guia", TypeName = "datetime")]
        public DateTime FechaGuia { get; set; }
        [Column("bultos_guia")]
        public int BultosGuia { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
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
