using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("no_empresa")]
    public partial class NoEmpresa
    {
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(20)]
        public string Nombre { get; set; }
        [Column("direccion")]
        [StringLength(255)]
        public string Direccion { get; set; }
        [Column("telefono1")]
        [StringLength(16)]
        public string Telefono1 { get; set; }
        [Column("telefono2")]
        [StringLength(16)]
        public string Telefono2 { get; set; }
        [Column("cp", TypeName = "numeric(7, 0)")]
        public decimal? Cp { get; set; }
        [Column("fax")]
        [StringLength(16)]
        public string Fax { get; set; }
        [Column("rfc")]
        [StringLength(14)]
        public string Rfc { get; set; }
        [Column("infonavit")]
        [StringLength(14)]
        public string Infonavit { get; set; }
        [Column("ciudad")]
        [StringLength(255)]
        public string Ciudad { get; set; }
        [Column("tipoempresa")]
        public int? Tipoempresa { get; set; }
        [Column("fax2")]
        [StringLength(16)]
        public string Fax2 { get; set; }
        [Column("calle")]
        [StringLength(30)]
        public string Calle { get; set; }
        [Column("colonia")]
        [StringLength(30)]
        public string Colonia { get; set; }
        [Column("estado")]
        [StringLength(30)]
        public string Estado { get; set; }
        [Column("pais")]
        [StringLength(30)]
        public string Pais { get; set; }
        [Column("facsubs", TypeName = "decimal(14, 4)")]
        public decimal? Facsubs { get; set; }
        [Column("por_facsubs", TypeName = "decimal(14, 4)")]
        public decimal? PorFacsubs { get; set; }
        [Column("prima_vac", TypeName = "decimal(14, 4)")]
        public decimal? PrimaVac { get; set; }
        [Column("prima_dom", TypeName = "decimal(14, 4)")]
        public decimal? PrimaDom { get; set; }
        [Column("version")]
        [StringLength(100)]
        public string Version { get; set; }
        [Column("fecha_generacion_exe", TypeName = "datetime")]
        public DateTime? FechaGeneracionExe { get; set; }
        [Column("nombre_corporativo")]
        [StringLength(80)]
        public string NombreCorporativo { get; set; }
        [Column("no_exterior")]
        [StringLength(20)]
        public string NoExterior { get; set; }
        [Column("no_interior")]
        [StringLength(20)]
        public string NoInterior { get; set; }
        [Column("localidad")]
        [StringLength(255)]
        public string Localidad { get; set; }
        [Column("referencia")]
        [StringLength(255)]
        public string Referencia { get; set; }
        [Column("contacto")]
        [StringLength(250)]
        public string Contacto { get; set; }
    }
}
