using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_proveedor")]
    public partial class CmProveedor
    {
        [Key]
        [Column("cveproveedor", TypeName = "decimal(10, 0)")]
        public decimal Cveproveedor { get; set; }
        [Column("tipo_proveedor", TypeName = "decimal(2, 0)")]
        public decimal? TipoProveedor { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("rfc")]
        [StringLength(16)]
        public string Rfc { get; set; }
        [Column("direccion")]
        [StringLength(65)]
        public string Direccion { get; set; }
        [Column("telefono")]
        [StringLength(16)]
        public string Telefono { get; set; }
        [Column("telefono2")]
        [StringLength(16)]
        public string Telefono2 { get; set; }
        [Column("fax")]
        [StringLength(16)]
        public string Fax { get; set; }
        [Column("ciudad")]
        [StringLength(50)]
        public string Ciudad { get; set; }
        [Column("codigo_postal", TypeName = "decimal(6, 0)")]
        public decimal? CodigoPostal { get; set; }
        [Column("direccion_elec")]
        [StringLength(50)]
        public string DireccionElec { get; set; }
        [Column("nombre_contacto")]
        [StringLength(50)]
        public string NombreContacto { get; set; }
        [Column("contratista")]
        [StringLength(1)]
        public string Contratista { get; set; }
        [Column("dias_credito")]
        public int? DiasCredito { get; set; }
    }
}
