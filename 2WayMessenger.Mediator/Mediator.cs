using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2WayMessenger.Interface;
using _2WayMessenger.Model;



namespace _2WayMessenger.Mediator
{
    public class Mediator:Imediator
    {
        public async Task<HttpResponseMessage> SendMessage(UserDetails userDetails, Vendor urlDetails, string message)
        {
         
                    using (var httpClient = new HttpClient())
                    {
                        httpClient.DefaultRequestHeaders.Add("X-API-KEY", urlDetails.XApiKey);

                        var requestContent = new StringContent(content: message, encoding: Encoding.UTF8, mediaType: "application/x-www-form-urlencoded");

                        var url = $"{urlDetails.BaseURL}?username={userDetails.Userid}&password={userDetails.Password}&destination={userDetails.PrimaryVirtualNumber}&source={userDetails.SourceNumber}";

                        var response = await httpClient.PostAsync(url, requestContent);

                        return response;
                    }
                  
        }
        }

    
}
