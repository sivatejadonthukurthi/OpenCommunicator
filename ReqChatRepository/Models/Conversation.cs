using System.ComponentModel.DataAnnotations;

namespace ReqChatRepository.Models
{
    public class Conversation
    {
        [Key]
        public int ConversationId { get; set; }
        public int UnReadMessageCount { get; set; }
        public int CandidateId { get; set; }
        public int RecruiterId { get; set; }
       // public string? displayDate { get; set; }
        public string? Message { get; set; }
        public DateTime SentOn { get; set; }
        public List<AllMessage>? AllMessages { get; set; }
    }
}