using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftransf_sello")]
    [Index(nameof(Rowguid), Name = "index_994102582", IsUnique = true)]
    public partial class FtransfSello
    {
        [Key]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Key]
        [Column("no_secuencial", TypeName = "numeric(3, 0)")]
        public decimal NoSecuencial { get; set; }
        [Column("id_transfer")]
        [StringLength(4)]
        public string IdTransfer { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("num_vehiculo")]
        [StringLength(20)]
        public string NumVehiculo { get; set; }
        [Required]
        [Column("sello")]
        [StringLength(21)]
        public string Sello { get; set; }
        [Column("nombre_chofer")]
        [StringLength(30)]
        public string NombreChofer { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("capacidad")]
        [StringLength(1)]
        public string Capacidad { get; set; }
        [Column("tipo_caja")]
        [StringLength(1)]
        public string TipoCaja { get; set; }
        [Column("categoria")]
        [StringLength(1)]
        public string Categoria { get; set; }
        [Column("motivo")]
        [StringLength(1)]
        public string Motivo { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("capacidad_salida")]
        [StringLength(1)]
        public string CapacidadSalida { get; set; }
        [Column("placas")]
        [StringLength(20)]
        public string Placas { get; set; }
        [Column("linea_fletera_origen")]
        [StringLength(4)]
        public string LineaFleteraOrigen { get; set; }
        [Column("id_transfer_pagado")]
        [StringLength(7)]
        public string IdTransferPagado { get; set; }
        [Column("me_number")]
        [StringLength(15)]
        public string MeNumber { get; set; }
    }
}
