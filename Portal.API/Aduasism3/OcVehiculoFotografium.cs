using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_vehiculo_fotografia")]
    public partial class OcVehiculoFotografium
    {
        [Key]
        [Column("id")]
        public short Id { get; set; }
        [Column("descripcion")]
        [StringLength(70)]
        public string Descripcion { get; set; }
        [Column("descripcion_en")]
        [StringLength(70)]
        public string DescripcionEn { get; set; }
        [Required]
        [Column("tipo")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column("orden")]
        public short? Orden { get; set; }
        [Column("dinamico")]
        public bool Dinamico { get; set; }
        [Column("cargado")]
        public bool Cargado { get; set; }
    }
}
