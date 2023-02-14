using ReqChatRepository.Models;

namespace ReqChat.Interface
{
    public interface IAllMessageRepository
    {
        IEnumerable<AllMessage> GetAllMessagesByConversationId(int conversationId);
        void InsertMessage(AllMessage message);
    }

}