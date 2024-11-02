using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Entities.Entities
{
    [Table("usertypes")]
    public class UserTypes
    {
        [Key]
        [Column("usertypeid")]
        public int UserTypeId { get; set; }
        [Column("usertype")]
        public string? UserType { get; set; }
    }
}
