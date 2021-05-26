using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_proceso_directorio_documentos_parametros")]
    public partial class OcProcesoDirectorioDocumentosParametro
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("proceso")]
        public short Proceso { get; set; }
        [Key]
        [Column("id_aplicacion")]
        [StringLength(10)]
        public string IdAplicacion { get; set; }
        [Key]
        [Column("id_modulo")]
        [StringLength(20)]
        public string IdModulo { get; set; }
        [Key]
        [Column("id_documento")]
        public short IdDocumento { get; set; }
        [Key]
        [Column("id_parametro")]
        [StringLength(20)]
        public string IdParametro { get; set; }
        [Column("orden")]
        public short? Orden { get; set; }
        [Column("separador")]
        [StringLength(1)]
        public string Separador { get; set; }
        [Column("valor")]
        [StringLength(50)]
        public string Valor { get; set; }
    }
}
