using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("pr_cliente")]
    public partial class PrCliente
    {
        [Key]
        [Column("cve_cliente")]
        [StringLength(10)]
        public string CveCliente { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("direccion")]
        [StringLength(100)]
        public string Direccion { get; set; }
        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("telefono_sec")]
        [StringLength(20)]
        public string TelefonoSec { get; set; }
        [Column("rfc")]
        [StringLength(20)]
        public string Rfc { get; set; }
        [Column("codigo_postal", TypeName = "decimal(10, 0)")]
        public decimal? CodigoPostal { get; set; }
        [Column("fax")]
        [StringLength(20)]
        public string Fax { get; set; }
        [Column("direccion_elec")]
        [StringLength(100)]
        public string DireccionElec { get; set; }
        [Column("estado", TypeName = "decimal(2, 0)")]
        public decimal? Estado { get; set; }
        [Column("ciudad")]
        [StringLength(50)]
        public string Ciudad { get; set; }
        [Column("tipo_cliente")]
        public int? TipoCliente { get; set; }
        [Column("contacto")]
        [StringLength(50)]
        public string Contacto { get; set; }
        [Column("comentarios")]
        [StringLength(100)]
        public string Comentarios { get; set; }
    }
}
