using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_transporte")]
    public partial class TpTransporte
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_transporte")]
        public short IdTransporte { get; set; }
        [Column("identificador")]
        [StringLength(17)]
        public string Identificador { get; set; }
        [Column("pais_transporte")]
        [StringLength(3)]
        public string PaisTransporte { get; set; }
        [Column("nombre")]
        [StringLength(120)]
        public string Nombre { get; set; }
        [Column("rfc_transportista")]
        [StringLength(13)]
        public string RfcTransportista { get; set; }
        [Column("curp_transportista")]
        [StringLength(18)]
        public string CurpTransportista { get; set; }
        [Column("domicilio_transportista")]
        [StringLength(150)]
        public string DomicilioTransportista { get; set; }
        [Column("candados")]
        [StringLength(21)]
        public string Candados { get; set; }
    }
}
