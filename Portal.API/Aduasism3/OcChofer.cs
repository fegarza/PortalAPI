using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_chofer")]
    public partial class OcChofer
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("no_control")]
        [StringLength(20)]
        public string NoControl { get; set; }
        [Column("fecha_arribo", TypeName = "datetime")]
        public DateTime FechaArribo { get; set; }
        [Column("fecha_salida", TypeName = "datetime")]
        public DateTime? FechaSalida { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column("linea_transportista")]
        [StringLength(40)]
        public string LineaTransportista { get; set; }
        [Required]
        [Column("no_licencia")]
        [StringLength(30)]
        public string NoLicencia { get; set; }
        [Required]
        [Column("estado_licencia")]
        [StringLength(40)]
        public string EstadoLicencia { get; set; }
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
        [Column("no_control_guia")]
        [StringLength(8)]
        public string NoControlGuia { get; set; }
    }
}
