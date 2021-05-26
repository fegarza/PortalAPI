using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_embarque_no_cruzo")]
    public partial class OcEmbarqueNoCruzo
    {
        [Key]
        [Column("id")]
        public short Id { get; set; }
        [Column("titulo")]
        [StringLength(50)]
        public string Titulo { get; set; }
    }
}
