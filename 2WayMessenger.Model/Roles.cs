using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Model
{
    public class Roles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public bool RoleType { get; set; }

        public int ConsumerID { get; set; }
        public Consumers? Consumer { get; set; }
    }
}
