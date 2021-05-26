using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("se_usuarios")]
    public partial class SeUsuario
    {
        [Key]
        [Column("usr_id")]
        [StringLength(8)]
        public string UsrId { get; set; }
        [Column("usr_nm")]
        [StringLength(80)]
        public string UsrNm { get; set; }
        [Column("usr_pw")]
        [StringLength(10)]
        public string UsrPw { get; set; }
        [Column("master")]
        [StringLength(1)]
        public string Master { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
    }
}
