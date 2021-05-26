using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("festado")]
    [Index(nameof(Rowguid), Name = "index_1426104121", IsUnique = true)]
    public partial class Festado
    {
        public Festado()
        {
            Fmunicipios = new HashSet<Fmunicipio>();
        }

        [Key]
        [Column("id_estado")]
        [StringLength(4)]
        public string IdEstado { get; set; }
        [Required]
        [Column("id_pais")]
        [StringLength(4)]
        public string IdPais { get; set; }
        [Column("descripcion")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        [Column("desc_breve")]
        [StringLength(10)]
        public string DescBreve { get; set; }
        [Column("entidad")]
        [StringLength(3)]
        public string Entidad { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("descripcion_shipper")]
        [StringLength(2)]
        public string DescripcionShipper { get; set; }
        [Column("inactivo")]
        [StringLength(1)]
        public string Inactivo { get; set; }

        [ForeignKey(nameof(IdPais))]
        [InverseProperty(nameof(Fpai.Festados))]
        public virtual Fpai IdPaisNavigation { get; set; }
        [InverseProperty(nameof(Fmunicipio.IdEstadoNavigation))]
        public virtual ICollection<Fmunicipio> Fmunicipios { get; set; }
    }
}
