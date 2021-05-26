using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_RegimenFiscalCFDI")]
    public partial class FfgRegimenFiscalCfdi
    {
        [Key]
        [Column("id_RegimenFiscalCFDI")]
        public byte IdRegimenFiscalCfdi { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime FechaCaptura { get; set; }
        [Column("c_RegimenFiscal")]
        [StringLength(3)]
        public string CRegimenFiscal { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Column("aplicaTipoPerFisica")]
        [StringLength(1)]
        public string AplicaTipoPerFisica { get; set; }
        [Column("aplicaTipoPerMoral")]
        [StringLength(1)]
        public string AplicaTipoPerMoral { get; set; }
        [Column("fechaInicioVigencia", TypeName = "datetime")]
        public DateTime? FechaInicioVigencia { get; set; }
        [Column("fechaFinVigencia", TypeName = "datetime")]
        public DateTime? FechaFinVigencia { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
    }
}
