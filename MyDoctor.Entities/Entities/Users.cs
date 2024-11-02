using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Entities.Entities
{
    [Table("users")]
    public class Users
    {
        [Key]
        [Column("userid")]
        public int UserId { get; set; }
        [ForeignKey("UserTypes")]
        [Column("usertypeid")]
        public int UserTypeId { get; set; }
        [Column("firstname")]
        public string? FirstName { get; set; }
        [Column("lastname")]
        public string? LastName { get; set; }
        [Column("emailid")]
        public string? EmailId { get; set; }
        [Column("phone")]
        public string? Phone { get; set; }
        [Column("password")]
        public string? Password { get; set; }
        [Column("lastlogin")]
        public DateTime LastLogin { get; set; }
        [ForeignKey("Statuses")]
        [Column("statusid")]
        public int StatusId { get; set; }
        [Column("createdate")]
        public DateTime CreatedDate { get; set; }
        [Column("createdby")]
        public int CreatedBy { get; set; }
        [Column("modifieddate")]
        public DateTime ModifiedDate { get; set; }
        [Column("modifiedby")]
        public int ModifiedBy { get; set; }
    }
}
