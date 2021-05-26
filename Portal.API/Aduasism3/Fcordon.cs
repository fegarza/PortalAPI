using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcordon")]
    [Index(nameof(Rowguid), Name = "index_29295214", IsUnique = true)]
    public partial class Fcordon
    {
        [Key]
        [Column("id_cordon")]
        [StringLength(2)]
        public string IdCordon { get; set; }
        [Column("descripcion")]
        [StringLength(31)]
        public string Descripcion { get; set; }
        [Column("cordon")]
        [StringLength(1)]
        public string Cordon { get; set; }
        [Column("zona")]
        [StringLength(1)]
        public string Zona { get; set; }
        [Column("estado")]
        [StringLength(3)]
        public string Estado { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
