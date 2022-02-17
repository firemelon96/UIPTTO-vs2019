using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.Models
{
    [Table("patent_Table")]
    public partial class PatentTable
    {
        [Key]
        [Column("pt_Id")]
        public int PtId { get; set; }
        [Column("pt_Title")]
        [StringLength(255)]
        public string? PtTitle { get; set; }
        [Column("pt_Status")]
        [StringLength(15)]
        public string? PtStatus { get; set; }
        [Column("pt_DateFiled", TypeName = "date")]
        public DateTime? PtDateFiled { get; set; }
        [Column("pt_RegNo")]
        public int? PtRegNo { get; set; }
        [Column("pr_ApprDate", TypeName = "date")]
        public DateTime? PrApprDate { get; set; }
        [Column("p_Id")]
        public int? PId { get; set; }

        [ForeignKey(nameof(PId))]
        [InverseProperty(nameof(ProfileTable.PatentTables))]
        public virtual ProfileTable? PIdNavigation { get; set; }
    }
}
