using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_archivo_encargo")]
    public partial class FconsecutivoArchivoEncargo
    {
        [Column("Cons_arch")]
        public int ConsArch { get; set; }
    }
}
