using Microsoft.VisualBasic;
using ReqChatRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqChat.Interface
{
    public interface IconversationRepository
    {
        IEnumerable<Conversation> GetPrevConversation();
        IEnumerable<Conversation> GetConversation(int candidateID);
        void InsertConversation(Conversation conversation);
        void UpdateConversation(int conversationId,string message,string SentFrom);
        // void DeleteConversation(Conversation conversation);
    }
}
