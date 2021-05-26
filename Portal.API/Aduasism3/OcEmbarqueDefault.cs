using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_embarque_defaults")]
    public partial class OcEmbarqueDefault
    {
        [Key]
        [Column("cve_transporte")]
        [StringLength(2)]
        public string CveTransporte { get; set; }
        [Required]
        [Column("id_tipo_embarque")]
        [StringLength(1)]
        public string IdTipoEmbarque { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("id_transfer")]
        [StringLength(4)]
        public string IdTransfer { get; set; }
        [Required]
        [Column("id_transfer_pagado")]
        [StringLength(7)]
        public string IdTransferPagado { get; set; }
    }
}
