using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Model
{
    public class Conversations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConversationID { get; set; }
        public int PrimaryUserId { get; set; }
        public int SecondaryUserId { get; set; }
        public int ConsumerClientId { get; set; }
        public string? LastMessage { get; set; }
        public int ConsumerID { get; set; }
        public int UnReadMessageCount { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdatedDate { get; set; } = DateTime.UtcNow;
    }
}
