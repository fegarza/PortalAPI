using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_archivo_extension_tipo")]
    [Index(nameof(Tipo), Name = "UQ__dig_arch__E7F956494C1D9DBB", IsUnique = true)]
    public partial class DigArchivoExtensionTipo
    {
        public DigArchivoExtensionTipo()
        {
            DigArchivoExtensions = new HashSet<DigArchivoExtension>();
        }

        [Key]
        [Column("id_tipo")]
        public short IdTipo { get; set; }
        [Required]
        [Column("tipo")]
        [StringLength(50)]
        public string Tipo { get; set; }

        [InverseProperty(nameof(DigArchivoExtension.IdTipoNavigation))]
        public virtual ICollection<DigArchivoExtension> DigArchivoExtensions { get; set; }
    }
}
