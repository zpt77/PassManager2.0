using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassManager2._0
{
    public class User: DbObject
    {

        [MaxLength(30)]
        [Required]
        public string LoginName { get; set; }
        [Required]
        public string Password { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
    }
}
