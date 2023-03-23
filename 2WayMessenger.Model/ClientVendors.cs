using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Model
{
    public class ClientVendors
    {
        [Key]
        public int ClientVendorId { get; set; }

        [Required]
        public int ConsumerClientId { get; set; }

        

        [Required]
        public int VendorId { get; set; }


        [Required]
        public int ConsumerId { get; set; }

       
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

       
        public DateTime LastUpdatedDate { get; set; } = DateTime.UtcNow;
    }

}
