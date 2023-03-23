using _2WayMessenger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Interface
{
    public interface IConsumerRepository
    {
        Task<Consumers?> GetConsumerAsync(string UserDetailID);
        bool AddConsumer(Consumers consumers);
        bool UpdateConsumer(Consumers consumers);
    }
}
