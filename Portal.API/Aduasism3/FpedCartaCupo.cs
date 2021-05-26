using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_carta_cupo")]
    [Index(nameof(Rowguid), Name = "index_1501300458", IsUnique = true)]
    public partial class FpedCartaCupo
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Required]
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Required]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Required]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("folio_carta")]
        [StringLength(8)]
        public string FolioCarta { get; set; }
        [Column("acuse_elec")]
        [StringLength(8)]
        public string AcuseElec { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
