using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_sellos_disponibles")]
    public partial class OcSellosDisponible
    {
        [Key]
        [Column("color")]
        [StringLength(1)]
        public string Color { get; set; }
        [Key]
        [Column("sello")]
        [StringLength(10)]
        public string Sello { get; set; }
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
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
