using System.ComponentModel.DataAnnotations;

namespace _2WayMessenger.Model
{
    public class CandidateReq
    {
        public string? AutoReq { get; set; }
        [Key]
        public int Reqid { get; set; }
        public string? Title { get; set; }
    }
}