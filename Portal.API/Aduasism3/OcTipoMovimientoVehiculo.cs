using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_tipo_movimiento_vehiculo")]
    public partial class OcTipoMovimientoVehiculo
    {
        [Key]
        [Column("id_tipo_movimiento")]
        public short IdTipoMovimiento { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
        [Column("cargado")]
        public bool Cargado { get; set; }
        [Column("permite_carga")]
        public bool PermiteCarga { get; set; }
    }
}
