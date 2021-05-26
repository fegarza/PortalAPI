using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("gto_claves_iso")]
    public partial class GtoClavesIso
    {
        [Column("id_clave_iso")]
        public int IdClaveIso { get; set; }
        [Column("clave_rep_iso")]
        [StringLength(20)]
        public string ClaveRepIso { get; set; }
        [Column("revision_iso")]
        [StringLength(10)]
        public string RevisionIso { get; set; }
        [Column("fecha_captura_iso", TypeName = "datetime")]
        public DateTime? FechaCapturaIso { get; set; }
        [Column("Observaciones_iso", TypeName = "text")]
        public string ObservacionesIso { get; set; }
    }
}
