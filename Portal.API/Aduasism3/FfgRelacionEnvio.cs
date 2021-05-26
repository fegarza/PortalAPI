using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_relacion_envio")]
    public partial class FfgRelacionEnvio
    {
        [Key]
        [Column("id_relacion")]
        [StringLength(10)]
        public string IdRelacion { get; set; }
        [Column("fecha_relacion", TypeName = "datetime")]
        public DateTime FechaRelacion { get; set; }
        [Column("fecha_entrega", TypeName = "datetime")]
        public DateTime FechaEntrega { get; set; }
        [Required]
        [Column("tipo_relacion")]
        [StringLength(1)]
        public string TipoRelacion { get; set; }
        [Required]
        [Column("id_destino")]
        [StringLength(3)]
        public string IdDestino { get; set; }
        [Required]
        [Column("id_tipo_orgnizacion")]
        [StringLength(2)]
        public string IdTipoOrgnizacion { get; set; }
        [Required]
        [Column("id_organizacion")]
        [StringLength(8)]
        public string IdOrganizacion { get; set; }
        [Column("no_guia")]
        [StringLength(30)]
        public string NoGuia { get; set; }
        [Column("mensajeria")]
        [StringLength(50)]
        public string Mensajeria { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("atencion")]
        [StringLength(50)]
        public string Atencion { get; set; }
        [Column("recepcion")]
        [StringLength(80)]
        public string Recepcion { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
    }
}
