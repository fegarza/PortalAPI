using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_archivo_extensiones")]
    public partial class DigArchivoExtensione
    {
        [Key]
        [Column("extension")]
        [StringLength(5)]
        public string Extension { get; set; }
        [Column("maxSize")]
        public int? MaxSize { get; set; }
    }
}
