using _2WayMessenger.Model;

namespace _2WayMessenger.Interface
{
    public interface IAllMessageRepository
    {
        IEnumerable<AllMessage> GetAllMessagesByConversationId(int conversationId);
        void InsertMessage(AllMessage message);
    }

}