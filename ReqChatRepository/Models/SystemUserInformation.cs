using System.ComponentModel.DataAnnotations;

namespace ReqChatRepository.Models
{
    public class SystemUserInformation
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        [Key]
        public int UserID { get; set; }
        public string? Email { get; set; }
        public int VirtualNumber { get; set; }
    }
}