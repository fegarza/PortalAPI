﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("status_embarque")]
    public partial class StatusEmbarque
    {
        [Key]
        [Column("status_embarque")]
        public short StatusEmbarque1 { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
