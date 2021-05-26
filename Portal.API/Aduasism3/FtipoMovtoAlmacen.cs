using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_movto_almacen")]
    public partial class FtipoMovtoAlmacen
    {
        [Key]
        [Column("id_tipo_movto")]
        [StringLength(4)]
        public string IdTipoMovto { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("cve_cargo_credito")]
        [StringLength(2)]
        public string CveCargoCredito { get; set; }
    }
}
