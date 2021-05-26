using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_lista_envios")]
    public partial class FfgListaEnvio
    {
        [Required]
        [Column("cve_tipo_organizacion")]
        [StringLength(2)]
        public string CveTipoOrganizacion { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
    }
}
