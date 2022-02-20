using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.Models
{
    [Keyless]
    [Table("user_Table")]
    public partial class UserTable
    {
        [Key]
        [Column("u_Id")]
        public int UId { get; set; }
        [Column("u_Fname")]
        [StringLength(50)]
        public string? UFname { get; set; }
        [Column("u_Lname")]
        [StringLength(50)]
        public string? ULname { get; set; }
        [Column("u_Email")]
        [StringLength(50)]
        public string? UEmail { get; set; }
        [Column("u_College")]
        [StringLength(50)]
        public string? UCollege { get; set; }
        [Column("u_Username")]
        [StringLength(50)]
        public string? UUsername { get; set; }
        [Column("u_Password")]
        [StringLength(50)]
        public string? UPassword { get; set; }
        [Column("u_DOB", TypeName = "date")]
        public DateTime? UDob { get; set; }
        [Column("u_Gender")]
        [StringLength(10)]
        [Unicode(false)]
        public string? UGender { get; set; }

        public string? PFullname {
            get {
                return UFname + " " + ULname;
            }
        }
    }
}
