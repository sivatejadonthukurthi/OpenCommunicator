using _2WayMessenger.Interface;
using _2WayMessenger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2WayMessenger.Repository
{
    public class ConversationRepository : IconversationRepository
    {
        private readonly appContext _context;

        public ConversationRepository(appContext context)
        {
            _context = context;
        }

        public void DeleteConversation(Conversation conversation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Conversation> GetConversation(int conversationId)
        {
            return _context.Conversations.Where(conversation=>conversation.ConversationId== conversationId).Take(10).ToList();
        }

        public IEnumerable<Conversation> GetPrevConversation()
        {
            throw new NotImplementedException();
        }

        public void  InsertConversation(Conversation conversation)
        {
            _context.Conversations.Add(conversation);
            _context.SaveChanges();
        }

        public void UpdateConversation(int conversationId, string message, string SentFrom)
        {
            throw new NotImplementedException();
        }
    }
}
