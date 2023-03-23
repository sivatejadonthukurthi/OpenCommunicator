using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Model
{
    public class RecieversInfo
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Email { get; set; }
       
        public int RecieverID { get; set; }
        public string? PhoneNumber { get; set; }
        
        public Conversation? Conversation { get; set; }


    }

}
