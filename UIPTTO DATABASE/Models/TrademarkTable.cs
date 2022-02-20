using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.Models
{
    [Table("trademark_Table")]
    public partial class TrademarkTable
    {
        [Key]
        [Column("t_Id")]
        public int TId { get; set; }
        [Column("t_Title")]
        [StringLength(255)]
        public string? TTitle { get; set; }
        [Column("t_Status")]
        [StringLength(15)]
        public string? tStatus { get; set; }
        [Column("t_DateFiled", TypeName = "date")]
        public DateTime? TDateFiled { get; set; }
        [Column("t_RegNo")]
        public int? TRegNo { get; set; }
        [Column("t_ApprDate", TypeName = "date")]
        public DateTime? TApprDate { get; set; }
        [Column("t_DAUFiling", TypeName = "date")]
        public DateTime? TDaufiling { get; set; }
        [Column("t_ExpiryDate", TypeName = "date")]
        public DateTime? TExpiryDate { get; set; }
    }
}
