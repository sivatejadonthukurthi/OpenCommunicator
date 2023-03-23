using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using _2WayMessenger.Interface;
using _2WayMessenger.Model;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReqChatcassendra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Conversationcontroller : ControllerBase
    {
        private IconversationRepository _conversationRepository;
        private IAllMessageRepository _messagerepository;

        public Conversationcontroller(IconversationRepository conversationRepository, IAllMessageRepository messageRepository)
        {
            _conversationRepository = conversationRepository;
            _messagerepository = messageRepository;

        }



        

        // GET api/<Conversationcontroller>/5
        [HttpGet("{id}")]
        public IEnumerable<AllMessage> Get(int id)
        {
            return _messagerepository.GetAllMessagesByConversationId(id);
        }

        // POST api/<Conversationcontroller>
        [HttpPost]
        public async void Post([FromBody] AllMessage conversation)
        {            
            _messagerepository.InsertMessage(conversation);
            string baseUrl = "https://api20-4.infinite-convergence.com/";
            string username = "BrassRingSMS2";
            string password = "AP3eo894";
            string destination = "+917702757237";
            string source = "18667792854";
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-API-KEY", "HQYXBpMjAtaWNzbWNxUDJ4T3N0QUUxa25OdE");

                var requestContent = new StringContent(content: conversation.Message, encoding: Encoding.UTF8, mediaType: "application/x-www-form-urlencoded");

                var url = $"{baseUrl}?username={username}&password={password}&destination={destination}&source={source}";

                var response =await httpClient.PostAsync(url, requestContent);

                // responseJson = response.Content.ReadAsStringAsync();

                //return JsonConvert.DeserializeObject<ResponseTable>(responseJson);
            }
        }

        

       
    }
}
