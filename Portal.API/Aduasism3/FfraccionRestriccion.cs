using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffraccion_restriccion")]
    public partial class FfraccionRestriccion
    {
        [Key]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Column("vulnerable")]
        [StringLength(1)]
        public string Vulnerable { get; set; }
        [Column("usuario")]
        [StringLength(6)]
        public string Usuario { get; set; }
        [Column("permiso_economia")]
        [StringLength(1)]
        public string PermisoEconomia { get; set; }
        [Column("marca_reg")]
        [StringLength(1)]
        public string MarcaReg { get; set; }
        [Column("iva_anexo_27")]
        [StringLength(1)]
        public string IvaAnexo27 { get; set; }
        [Column("restriccion_horario")]
        [StringLength(1)]
        public string RestriccionHorario { get; set; }
        [Column("anexo_10")]
        [StringLength(1)]
        public string Anexo10 { get; set; }
        [Column("sensible_immex")]
        [StringLength(1)]
        public string SensibleImmex { get; set; }
        [Column("id_sector")]
        [StringLength(3)]
        public string IdSector { get; set; }
    }
}
