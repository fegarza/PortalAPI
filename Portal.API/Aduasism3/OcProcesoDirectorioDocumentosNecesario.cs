using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_proceso_directorio_documentos_necesarios")]
    public partial class OcProcesoDirectorioDocumentosNecesario
    {
        [Key]
        [Column("proceso")]
        public short Proceso { get; set; }
        [Key]
        [Column("id_documento")]
        public short IdDocumento { get; set; }
    }
}
