using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.Models
{
    [Table("issn_Table")]
    public partial class IssnTable
    {
        [Key]
        [Column("i_Id")]
        public int IId { get; set; }
        [Column("i_Title")]
        [StringLength(255)]
        public string? ITitle { get; set; }
        [Column("i_DateFiled", TypeName = "date")]
        public DateTime? IDateFiled { get; set; }
        [Column("i_IssuedNo")]
        public int? IIssuedNo { get; set; }
        [Column("i_ApprDate", TypeName = "date")]
        public DateTime? IApprDate { get; set; }
        [Column("p_Id")]
        public int? PId { get; set; }
        [Column("i_Status")]
        [StringLength(15)]
        public string? IStatus { get; set; }

        [ForeignKey(nameof(PId))]
        [InverseProperty(nameof(ProfileTable.IssnTables))]
        public virtual ProfileTable? PIdNavigation { get; set; }
    }
}
