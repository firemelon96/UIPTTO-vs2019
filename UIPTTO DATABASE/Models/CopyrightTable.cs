using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.Models
{
    [Table("copyright_Table")]
    public partial class CopyrightTable
    {
        [Key]
        [Column("c_Id")]
        public int CId { get; set; }
        [Column("c_Title")]
        [StringLength(255)]
        public string? CTitle { get; set; }
        [Column("c_DateFiled", TypeName = "date")]
        public DateTime? CDateFiled { get; set; }
        [Column("c_RegNo")]
        public int? CRegNo { get; set; }
        [Column("c_ApprDate", TypeName = "date")]
        public DateTime? CApprDate { get; set; }
        [Column("p_Id")]
        public int? PId { get; set; }
        [Column("c_Status")]
        [StringLength(15)]
        public string? CStatus { get; set; }

        [ForeignKey(nameof(PId))]
        [InverseProperty(nameof(ProfileTable.CopyrightTables))]
        public virtual ProfileTable? PIdNavigation { get; set; }
    }
}
