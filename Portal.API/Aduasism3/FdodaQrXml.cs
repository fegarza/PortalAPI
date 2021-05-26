using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdoda_Qr_xml")]
    public partial class FdodaQrXml
    {
        [Key]
        [Column("num_control")]
        [StringLength(10)]
        public string NumControl { get; set; }
        [Key]
        [Column("ticket")]
        [StringLength(17)]
        public string Ticket { get; set; }
        [Key]
        [Column("movimiento")]
        [StringLength(1)]
        public string Movimiento { get; set; }
        [Key]
        [Column("request")]
        [StringLength(1)]
        public string Request { get; set; }
        [Column("xml")]
        public string Xml { get; set; }
    }
}
