using _2WayMessenger.Interface;
using _2WayMessenger.Model;
using _2WayMessenger.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2wayMessenger.Repository
{
    public class ConsumerRepository : IConsumerRepository
    {
        private readonly appContext _context;

        public ConsumerRepository(appContext context)
        {
            _context = context;
        }
        public bool AddConsumer(Consumers consumers)
        {
            try
            {

                _context.consumers.Add(consumers);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Consumers?> GetConsumerAsync(string UserDetailID)
        {
            var query = from userDetails in _context.UserDetails
                        join client in _context.consumers on userDetails.ConsumerClientId equals client.consumerID
                        
                        where userDetails.Userid == UserDetailID
                        select client;



            Consumers? consumers = await query.FirstOrDefaultAsync();
            return consumers;
        }

        public bool UpdateConsumer(Consumers consumers)
        {
            var ConsumerToUpdate = _context.consumers.FirstOrDefault(consumersList => consumersList.consumerID == consumers.consumerID);
            if (ConsumerToUpdate != null)
            {
                _context.consumers.Update(consumers);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
