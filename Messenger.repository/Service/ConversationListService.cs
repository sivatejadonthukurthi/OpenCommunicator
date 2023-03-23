using _2WayMessenger.Interface;
using _2WayMessenger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ReqChatRepository.Service
{
    public class ConversationListService: IRecieverConversation
    {
        public IEnumerable<RecieversInfo> GetConversationList(int senderID,string keyWord)
        {

            List<RecieversInfo> recievers = new List<RecieversInfo>(); // list of candidates retrieved from API


            var conversations = new List<Conversation>(); // list of conversations retrieved from data source containing conversationId


            List<RecieversInfo> mergedData = (List<RecieversInfo>)(from receiver in recievers
                             join conv in conversations on receiver.RecieverID equals conv.RecieverID into convs
                             from conversation in convs.DefaultIfEmpty()
                             select new RecieversInfo
                             {
                                 LastName = receiver.LastName,
                                 FirstName = receiver.FirstName,
                                 Email = receiver.Email,
                                 RecieverID = receiver.RecieverID,
                                 PhoneNumber = receiver.PhoneNumber,
                                 Conversation = conversation != null ? new Conversation
                                 {
                                     SenderID = conversation.SenderID,
                                     Message = conversation.Message,
                                     UnReadMessageCount = conversation.UnReadMessageCount,
                                     SentOn = conversation.SentOn
                                 } : null
                             });




            return mergedData;
           // throw new NotImplementedException();
        }
    }
}
