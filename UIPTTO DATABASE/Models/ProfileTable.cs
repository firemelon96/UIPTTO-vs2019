using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.Models
{
    [Table("profile_Table")]
    public partial class ProfileTable
    {
        public ProfileTable()
        {
            CopyrightTables = new HashSet<CopyrightTable>();
            IsbnTables = new HashSet<IsbnTable>();
            IssnTables = new HashSet<IssnTable>();
            PatentTables = new HashSet<PatentTable>();
        }

        [Key]
        [Column("p_Id")]
        public int PId { get; set; }
        [Column("p_Fname")]
        [StringLength(50)]
        public string? PFname { get; set; }
        [Column("p_Lname")]
        [StringLength(50)]
        public string? PLname { get; set; }
        [Column("p_Email")]
        [StringLength(50)]
        public string? PEmail { get; set; }
        [Column("p_College")]
        [StringLength(50)]
        public string? PCollege { get; set; }
        [Column("p_Gender")]
        [StringLength(50)]
        public string? PGender { get; set; }
        [Column("p_DOB", TypeName = "date")]
        public DateTime? PDob { get; set; }

        public string PFullname 
        {
            get 
            {
                return PFname + " " + PLname;
            }
        }

        [InverseProperty(nameof(CopyrightTable.PIdNavigation))]
        public virtual ICollection<CopyrightTable> CopyrightTables { get; set; }
        [InverseProperty(nameof(IsbnTable.PIdNavigation))]
        public virtual ICollection<IsbnTable> IsbnTables { get; set; }
        [InverseProperty(nameof(IssnTable.PIdNavigation))]
        public virtual ICollection<IssnTable> IssnTables { get; set; }
        [InverseProperty(nameof(PatentTable.PIdNavigation))]
        public virtual ICollection<PatentTable> PatentTables { get; set; }
    }
}
