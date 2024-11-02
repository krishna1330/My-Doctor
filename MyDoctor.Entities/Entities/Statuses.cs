using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Entities.Entities
{
    [Table("statuses")]
    public class Statuses
    {
        [Key]
        [Column("statusid")]
        public int StatusId { get; set; }
        [Column("status")]
        public string? Status { get; set; }
    }
}
