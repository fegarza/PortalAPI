﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_email_almacen")]
    public partial class WrEmailAlmacen
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_email")]
        public int IdEmail { get; set; }
        [Key]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(8)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(8)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
    }
}
