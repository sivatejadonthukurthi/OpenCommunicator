using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Model
{
    public class ConversationDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConversationDetailID { get; set; }
        public int ConversationID { get; set; }
        public bool MessageInitiatorRole { get; set; }
        public DateTime DateSent { get; set; }
        public string? Message { get; set; }
        public string? MessageStatus { get; set; }
    }

}
