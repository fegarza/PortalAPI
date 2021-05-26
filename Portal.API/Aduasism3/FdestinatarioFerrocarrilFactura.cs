using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdestinatario_ferrocarril_factura")]
    public partial class FdestinatarioFerrocarrilFactura
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(25)]
        public string IdFactura { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("irs")]
        [StringLength(20)]
        public string Irs { get; set; }
        [Column("razon_social")]
        [StringLength(120)]
        public string RazonSocial { get; set; }
        [Column("calle")]
        [StringLength(80)]
        public string Calle { get; set; }
        [Column("numero")]
        [StringLength(10)]
        public string Numero { get; set; }
        [Column("numero_interior")]
        [StringLength(10)]
        public string NumeroInterior { get; set; }
        [Column("codigo_postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("municipio")]
        [StringLength(80)]
        public string Municipio { get; set; }
        [Column("entidad")]
        [StringLength(3)]
        public string Entidad { get; set; }
        [Column("id_pais")]
        [StringLength(3)]
        public string IdPais { get; set; }
    }
}
