using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_organizacion")]
    [Index(nameof(Rowguid), Name = "index_770101784", IsUnique = true)]
    public partial class FtipoOrganizacion
    {
        public FtipoOrganizacion()
        {
            Fcontactos = new HashSet<Fcontacto>();
        }

        [Key]
        [Column("cve_tipo_organizacion")]
        [StringLength(2)]
        public string CveTipoOrganizacion { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(Fcontacto.CveTipoOrganizacionNavigation))]
        public virtual ICollection<Fcontacto> Fcontactos { get; set; }
    }
}
