using System.ComponentModel.DataAnnotations;

namespace ReqChatRepository.Models
{
    public class CandidateReq
    {
        public string? AutoReq { get; set; }
        [Key]
        public int Reqid { get; set; }
        public string? Title { get; set; }
    }
}