using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fgcertificado_origen")]
    public partial class FgcertificadoOrigen
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("producer")]
        [StringLength(100)]
        public string Producer { get; set; }
        [Column("address")]
        [StringLength(50)]
        public string Address { get; set; }
        [Column("no_tax_cliente")]
        [StringLength(20)]
        public string NoTaxCliente { get; set; }
        [Column("no_tax_proveedor")]
        [StringLength(20)]
        public string NoTaxProveedor { get; set; }
        [Column("no_tax_producer")]
        [StringLength(20)]
        public string NoTaxProducer { get; set; }
        [Column("id_contacto")]
        [StringLength(6)]
        public string IdContacto { get; set; }
        [Column("nombre_contacto")]
        [StringLength(80)]
        public string NombreContacto { get; set; }
        [Column("razon_social_proveedor")]
        [StringLength(120)]
        public string RazonSocialProveedor { get; set; }
        [Column("titulo")]
        [StringLength(80)]
        public string Titulo { get; set; }
        [Column("telefono")]
        [StringLength(15)]
        public string Telefono { get; set; }
        [Column("fax")]
        [StringLength(15)]
        public string Fax { get; set; }
        [Column("fecha_actual", TypeName = "datetime")]
        public DateTime? FechaActual { get; set; }
        [Column("fecha_inicio", TypeName = "datetime")]
        public DateTime? FechaInicio { get; set; }
        [Column("fecha_fin", TypeName = "datetime")]
        public DateTime? FechaFin { get; set; }
    }
}
