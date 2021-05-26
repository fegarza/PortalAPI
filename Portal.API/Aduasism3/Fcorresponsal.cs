using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("FCORRESPONSAL")]
    [Index(nameof(Rowguid), Name = "index_1988918157", IsUnique = true)]
    public partial class Fcorresponsal
    {
        [Key]
        [Column("ID_CORRESPONSAL")]
        [StringLength(6)]
        public string IdCorresponsal { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        [Column("ap_paterno")]
        [StringLength(25)]
        public string ApPaterno { get; set; }
        [Column("ap_materno")]
        [StringLength(25)]
        public string ApMaterno { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("titulo")]
        [StringLength(4)]
        public string Titulo { get; set; }
        [Column("cve_telefono")]
        [StringLength(5)]
        public string CveTelefono { get; set; }
        [Column("fax")]
        [StringLength(7)]
        public string Fax { get; set; }
        [Column("correo_electronico")]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }
        [Column("telefono1")]
        [StringLength(7)]
        public string Telefono1 { get; set; }
        [Column("telefono2")]
        [StringLength(7)]
        public string Telefono2 { get; set; }
        [Column("telefono3")]
        [StringLength(7)]
        public string Telefono3 { get; set; }
        [Column("telefono4")]
        [StringLength(7)]
        public string Telefono4 { get; set; }
        [Required]
        [Column("calle")]
        [StringLength(30)]
        public string Calle { get; set; }
        [Required]
        [Column("numero")]
        [StringLength(8)]
        public string Numero { get; set; }
        [Required]
        [Column("colonia")]
        [StringLength(30)]
        public string Colonia { get; set; }
        [Column("codigo_postal")]
        [StringLength(8)]
        public string CodigoPostal { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modificacion", TypeName = "datetime")]
        public DateTime FechaUltModificacion { get; set; }
        [Required]
        [Column("ID_USUARIO_ULT_MODIF")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("PORCENTAJE_HONORARIOS", TypeName = "numeric(7, 4)")]
        public decimal? PorcentajeHonorarios { get; set; }
        [Column("CVE_OPERATICO")]
        [StringLength(1)]
        public string CveOperatico { get; set; }
        [Column("factor", TypeName = "numeric(7, 4)")]
        public decimal? Factor { get; set; }
        [Column("tipo_corresponsal_contable")]
        [StringLength(2)]
        public string TipoCorresponsalContable { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdMunicipio))]
        [InverseProperty(nameof(Fmunicipio.Fcorresponsals))]
        public virtual Fmunicipio IdMunicipioNavigation { get; set; }
        [ForeignKey(nameof(IdUsuarioRegistro))]
        [InverseProperty(nameof(Fusuario.Fcorresponsals))]
        public virtual Fusuario IdUsuarioRegistroNavigation { get; set; }
    }
}
