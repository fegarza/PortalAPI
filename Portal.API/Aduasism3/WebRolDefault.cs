using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webRol_default")]
    public partial class WebRolDefault
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("rol")]
        public short Rol { get; set; }
        [Required]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Required]
        [Column("localizacion_almacen")]
        [StringLength(15)]
        public string LocalizacionAlmacen { get; set; }
        [Required]
        [Column("tipo_transporte")]
        [StringLength(2)]
        public string TipoTransporte { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Required]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Required]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Required]
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }
        [Required]
        [Column("tipo_guia")]
        [StringLength(1)]
        public string TipoGuia { get; set; }
        [Column("bultos_guia")]
        public int BultosGuia { get; set; }
        [Required]
        [Column("tipo_bulto")]
        [StringLength(5)]
        public string TipoBulto { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("tipo_flete")]
        public short TipoFlete { get; set; }
        [Column("importe_flete", TypeName = "decimal(10, 2)")]
        public decimal ImporteFlete { get; set; }
        [Required]
        [Column("moneda_flete")]
        [StringLength(4)]
        public string MonedaFlete { get; set; }
        [Required]
        [Column("id_pais_origen")]
        [StringLength(3)]
        public string IdPaisOrigen { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_tipo_embarque")]
        [StringLength(1)]
        public string IdTipoEmbarque { get; set; }
        [Column("id_clase")]
        public short IdClase { get; set; }
    }
}
