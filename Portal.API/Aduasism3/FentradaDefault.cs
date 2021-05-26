using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fentrada_defaults")]
    public partial class FentradaDefault
    {
        [Key]
        [Column("cve_tipo_transporte")]
        [StringLength(2)]
        public string CveTipoTransporte { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Column("marca_mcia")]
        [StringLength(20)]
        public string MarcaMcia { get; set; }
        [Column("seccion_entrada")]
        [StringLength(15)]
        public string SeccionEntrada { get; set; }
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Column("directa")]
        [StringLength(1)]
        public string Directa { get; set; }
        [Column("guia_flete")]
        [StringLength(25)]
        public string GuiaFlete { get; set; }
        [Column("cve_flete_pagado", TypeName = "numeric(1, 0)")]
        public decimal? CveFletePagado { get; set; }
    }
}
