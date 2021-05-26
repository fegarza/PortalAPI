using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_archivo_extension")]
    public partial class DigArchivoExtension
    {
        [Key]
        [Column("extension")]
        [StringLength(5)]
        public string Extension { get; set; }
        [Column("id_tipo")]
        public short IdTipo { get; set; }
        [Column("maxSize")]
        public long MaxSize { get; set; }

        [ForeignKey(nameof(IdTipo))]
        [InverseProperty(nameof(DigArchivoExtensionTipo.DigArchivoExtensions))]
        public virtual DigArchivoExtensionTipo IdTipoNavigation { get; set; }
    }
}
