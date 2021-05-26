using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_codigopostalCFDI")]
    public partial class FfgCodigopostalCfdi
    {
        [Key]
        [Column("id_codigopostalCFDI")]
        public int IdCodigopostalCfdi { get; set; }
        [Required]
        [Column("c_CodigoPostal")]
        [StringLength(5)]
        public string CCodigoPostal { get; set; }
        [Column("c_Estado")]
        [StringLength(3)]
        public string CEstado { get; set; }
        [Column("c_Municipio")]
        [StringLength(3)]
        public string CMunicipio { get; set; }
        [Column("c_Localidad")]
        [StringLength(2)]
        public string CLocalidad { get; set; }
    }
}
