using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassManager2._0
{
    public class Password : DbObject
    {
        [MaxLength(30)]
        [Required]
        public string PTitle { get; set; }

        [MaxLength(20)]
        public string PLogin { get; set; }

        [MaxLength(30)]
        public string PEmail { get; set; }

        [Required]
        public string PPassword { get; set; }

        [MaxLength(100)]
        public string PURL { get; set; }

        [MaxLength(100)]
        public string PDetails { get; set; }

       [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
