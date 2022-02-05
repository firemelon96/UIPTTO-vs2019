using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.Models
{
    [Table("isbn_Table")]
    public partial class IsbnTable
    {
        [Key]
        [Column("is_Id")]
        public int IsId { get; set; }
        [Column("is_Title")]
        [StringLength(50)]
        public string? IsTitle { get; set; }
        [Column("is_DateFiled", TypeName = "date")]
        public DateTime? IsDateFiled { get; set; }
        [Column("is_IssuedNo")]
        public int? IsIssuedNo { get; set; }
        [Column("is_ApprDate", TypeName = "date")]
        public DateTime? IsApprDate { get; set; }
        [Column("p_Id")]
        public int? PId { get; set; }

        [ForeignKey(nameof(PId))]
        [InverseProperty(nameof(ProfileTable.IsbnTables))]
        public virtual ProfileTable? PIdNavigation { get; set; }
    }
}
