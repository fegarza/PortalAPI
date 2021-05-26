using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("oc_instruccion_bak")]
    public partial class OcInstruccionBak
    {
        [Required]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Required]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("tipo_importacion")]
        [StringLength(1)]
        public string TipoImportacion { get; set; }
        [Required]
        [Column("clave_documento")]
        [StringLength(5)]
        public string ClaveDocumento { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("valor_factura", TypeName = "decimal(12, 2)")]
        public decimal ValorFactura { get; set; }
        [Column("importe_flete", TypeName = "decimal(12, 2)")]
        public decimal ImporteFlete { get; set; }
        [Column("importe_seguro", TypeName = "decimal(12, 2)")]
        public decimal ImporteSeguro { get; set; }
        [Column("importe_embalaje", TypeName = "decimal(12, 2)")]
        public decimal ImporteEmbalaje { get; set; }
        [Column("importe_otros", TypeName = "decimal(12, 2)")]
        public decimal ImporteOtros { get; set; }
        [Column("destino")]
        [StringLength(50)]
        public string Destino { get; set; }
        [Column("contacto")]
        [StringLength(50)]
        public string Contacto { get; set; }
        [Column("remesa")]
        public bool Remesa { get; set; }
        [Column("numero_remesa")]
        public int NumeroRemesa { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion")]
        public short? IdRectificacion { get; set; }
        [Column("corresponsalia")]
        public bool Corresponsalia { get; set; }
        [Required]
        [Column("corresponsal")]
        [StringLength(8)]
        public string Corresponsal { get; set; }
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Column("seccion")]
        [StringLength(2)]
        public string Seccion { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("autorizado")]
        public bool Autorizado { get; set; }
        [Column("fecha_autoriza", TypeName = "datetime")]
        public DateTime? FechaAutoriza { get; set; }
        [Column("usuario_autoriza")]
        [StringLength(6)]
        public string UsuarioAutoriza { get; set; }
    }
}
