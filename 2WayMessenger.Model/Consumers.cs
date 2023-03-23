using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Model
{
    public class Consumers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int consumerID { get; set; }

        public string? consumerName { get; set; }

        public string? consumerDomain { get; set; }

        public string? consumerAPIKey { get; set; }

    }
}
