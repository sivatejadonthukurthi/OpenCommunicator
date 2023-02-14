using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqChatRepository.Models
{
    public class CandidateList
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Email { get; set; }
        [Key]
        public int CandidateId { get; set; }
        public string? PhoneNumber { get; set; }
        public List<CandidateReq>? UserVsCandidateReqs { get; set; }
        public Conversation? Conversation { get; set; }


    }

}
