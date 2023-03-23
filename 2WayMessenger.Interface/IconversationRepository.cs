using Microsoft.VisualBasic;
using _2WayMessenger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Interface
{
    public interface IconversationRepository
    {
        IEnumerable<Conversation> GetPrevConversation();
        IEnumerable<Conversation> GetConversation(int conversationId);
        void InsertConversation(Conversation conversation);
        void UpdateConversation(int conversationId, string message, string SentFrom);
        void DeleteConversation(Conversation conversation);
    }
}
