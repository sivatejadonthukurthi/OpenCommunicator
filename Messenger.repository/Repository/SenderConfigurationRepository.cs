using _2WayMessenger.Interface;
using _2WayMessenger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2wayMessenger.Repository.Repository
{
    public class SenderConfigurationRepository : ISenderConfigurationRepository
    {
        public bool AddSenderConfiguration(UserDetails userDetails)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSenderConfiguration(int vendorID)
        {
            throw new NotImplementedException();
        }

        public Task<UserDetails?> GetSenderConfigurationAsync(string UserDetailID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSenderConfiguration(UserDetails userDetails)
        {
            throw new NotImplementedException();
        }
    }
}
