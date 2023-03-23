using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _2WayMessenger.Interface;
using _2WayMessenger.Model;

namespace ReqChatcassendra.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class RecieversController : ControllerBase
    {
        private IRecieverConversation _recieverConversation;
        public RecieversController(IRecieverConversation recieverConversation)
        {
            _recieverConversation = recieverConversation;
        }

        [HttpGet]

        public IEnumerable<RecieversInfo> Get(int senderID, string keyWord)
        {
            return _recieverConversation.GetConversationList(senderID, keyWord);
        }

        
    }
}
