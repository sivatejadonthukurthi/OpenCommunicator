using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReqChat.Interface;
using ReqChatRepository.Models;

namespace ReqChatRepository.Repository
{
    public class AllMessageRepository : IAllMessageRepository
    {
        private readonly appContext _context;

        public AllMessageRepository(appContext context)
        {
            _context = context;
        }

        public IEnumerable<AllMessage> GetAllMessagesByConversationId(int conversationId)
        {
            return _context.messages.Where(x => x.ConversationId == conversationId).OrderByDescending(x => x).ToList();
        }

        public void InsertMessage(AllMessage message)
        {
            _context.messages.Add(message);
            _context.SaveChanges();
        }

       
    }

}
