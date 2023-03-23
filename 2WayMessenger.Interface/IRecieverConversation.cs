using _2WayMessenger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Interface
{
    public interface IRecieverConversation
    {
        IEnumerable<RecieversInfo> GetConversationList(int senderID, string keyWord);
    }
}
