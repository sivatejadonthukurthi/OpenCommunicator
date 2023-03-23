using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Model
{
    public class UserDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrimaryUserId { get; set; }
        public string? PrimaryVirtualNumber { get; set; }
        public string? Userid { get; set; }
        public string? Password { get; set; }

        public string? SourceNumber { get; set; }
        public int ConsumerClientId { get; set; }
    }

}
