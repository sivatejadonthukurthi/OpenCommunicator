using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2WayMessenger.Interface;
using _2WayMessenger.Model;

namespace _2WayMessenger.Repository
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
