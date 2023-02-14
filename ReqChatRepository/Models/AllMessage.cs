using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqChatRepository.Models
{
    public class AllMessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }
        public string? Message { get; set; }
        public string? FromUser { get; set; }
        public DateTime SentOn { get; set; }
        public string? MessageStatus { get; set; }
        public int ConversationId { get;  set; }
    }
}
