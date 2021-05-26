using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fe_emisor")]
    public partial class FeEmisor
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Required]
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(120)]
        public string Nombre { get; set; }
        [Required]
        [Column("calle")]
        [StringLength(50)]
        public string Calle { get; set; }
        [Column("noExterior")]
        [StringLength(20)]
        public string NoExterior { get; set; }
        [Column("noInterior")]
        [StringLength(20)]
        public string NoInterior { get; set; }
        [Column("colonia")]
        [StringLength(50)]
        public string Colonia { get; set; }
        [Column("localidad")]
        [StringLength(255)]
        public string Localidad { get; set; }
        [Column("referencia")]
        [StringLength(255)]
        public string Referencia { get; set; }
        [Required]
        [Column("municipio")]
        [StringLength(255)]
        public string Municipio { get; set; }
        [Required]
        [Column("estado")]
        [StringLength(30)]
        public string Estado { get; set; }
        [Required]
        [Column("pais")]
        [StringLength(30)]
        public string Pais { get; set; }
        [Required]
        [Column("codigoPostal")]
        [StringLength(5)]
        public string CodigoPostal { get; set; }
    }
}
