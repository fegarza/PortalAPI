using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("funidad")]
    [Index(nameof(Rowguid), Name = "index_1026102696", IsUnique = true)]
    public partial class Funidad
    {
        public Funidad()
        {
            FbultoDetalles = new HashSet<FbultoDetalle>();
            FbultoTrafDeta = new HashSet<FbultoTrafDetum>();
        }

        [Key]
        [Column("id_unidad")]
        [StringLength(5)]
        public string IdUnidad { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("descripcion_en")]
        [StringLength(30)]
        public string DescripcionEn { get; set; }

        [InverseProperty(nameof(FbultoDetalle.IdUnidadNavigation))]
        public virtual ICollection<FbultoDetalle> FbultoDetalles { get; set; }
        [InverseProperty(nameof(FbultoTrafDetum.IdUnidadNavigation))]
        public virtual ICollection<FbultoTrafDetum> FbultoTrafDeta { get; set; }
    }
}
