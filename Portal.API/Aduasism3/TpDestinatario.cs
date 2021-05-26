using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_destinatario")]
    public partial class TpDestinatario
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_destinatario")]
        public short IdDestinatario { get; set; }
        [Column("identificador_fiscal")]
        [StringLength(17)]
        public string IdentificadorFiscal { get; set; }
        [Column("nombre")]
        [StringLength(120)]
        public string Nombre { get; set; }
        [Column("calle")]
        [StringLength(80)]
        public string Calle { get; set; }
        [Column("numero_exterior")]
        [StringLength(10)]
        public string NumeroExterior { get; set; }
        [Column("numero_interior")]
        [StringLength(10)]
        public string NumeroInterior { get; set; }
        [Column("ciudad_municipio")]
        [StringLength(80)]
        public string CiudadMunicipio { get; set; }
        [Column("codigo_postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Column("pais_direccion")]
        [StringLength(250)]
        public string PaisDireccion { get; set; }
        [Column("entidad_federativa")]
        [StringLength(250)]
        public string EntidadFederativa { get; set; }
        [Column("pais")]
        [StringLength(3)]
        public string Pais { get; set; }
    }
}
