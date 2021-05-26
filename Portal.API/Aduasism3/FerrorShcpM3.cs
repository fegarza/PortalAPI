using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ferror_shcp_m3")]
    [Index(nameof(Rowguid), Name = "index_2020918271", IsUnique = true)]
    public partial class FerrorShcpM3
    {
        [Key]
        [Column("registro")]
        [StringLength(4)]
        public string Registro { get; set; }
        [Key]
        [Column("tipo_error")]
        [StringLength(2)]
        public string TipoError { get; set; }
        [Key]
        [Column("error")]
        [StringLength(2)]
        public string Error { get; set; }
        [Key]
        [Column("campo")]
        [StringLength(2)]
        public string Campo { get; set; }
        [Column("descripcion")]
        [StringLength(550)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("justificable")]
        [StringLength(1)]
        public string Justificable { get; set; }
        [Column("justificable2")]
        [StringLength(1)]
        public string Justificable2 { get; set; }
    }
}
