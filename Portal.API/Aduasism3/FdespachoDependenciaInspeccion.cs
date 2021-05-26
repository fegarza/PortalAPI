using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdespacho_dependencia_inspeccion")]
    public partial class FdespachoDependenciaInspeccion
    {
        [Key]
        [Column("num_control")]
        [StringLength(30)]
        public string NumControl { get; set; }
        [Key]
        [Column("numero_bl")]
        [StringLength(25)]
        public string NumeroBl { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(9, 0)")]
        public decimal Secuencial { get; set; }
        [Key]
        [Column("dependencia_inspeccion")]
        [StringLength(2)]
        public string DependenciaInspeccion { get; set; }
        [Column("folio_licencia_certificado")]
        [StringLength(25)]
        public string FolioLicenciaCertificado { get; set; }
        [Column("edocument_licencia_certificado")]
        [StringLength(13)]
        public string EdocumentLicenciaCertificado { get; set; }
    }
}
