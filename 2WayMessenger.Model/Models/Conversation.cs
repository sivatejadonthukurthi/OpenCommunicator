using System.ComponentModel.DataAnnotations;

namespace _2WayMessenger.Model
{
    public class Conversation
    {
        [Key]
        public int ConversationId { get; set; }
        public int UnReadMessageCount { get; set; }
        public int RecieverID { get; set; }
        public int SenderID { get; set; }
        public int ClientID { get; set; }

        //public string? displayDate { get; set; }
        public string? Message { get; set; }
        public DateTime SentOn { get; set; }
        public List<AllMessage>? AllMessages { get; set; }
    }
}