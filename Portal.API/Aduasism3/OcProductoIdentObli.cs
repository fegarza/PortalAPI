﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_producto_ident_obli")]
    public partial class OcProductoIdentObli
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Key]
        [Column("id_producto")]
        [StringLength(20)]
        public string IdProducto { get; set; }
        [Key]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Key]
        [Column("tipo_caso")]
        [StringLength(3)]
        public string TipoCaso { get; set; }
        [Key]
        [Column("iden_caso")]
        [StringLength(20)]
        public string IdenCaso { get; set; }
        [Key]
        [Column("complemento2")]
        [StringLength(30)]
        public string Complemento2 { get; set; }
        [Column("complemento3")]
        [StringLength(30)]
        public string Complemento3 { get; set; }
        [Column("fecha_vencimiento", TypeName = "datetime")]
        public DateTime? FechaVencimiento { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
    }
}
