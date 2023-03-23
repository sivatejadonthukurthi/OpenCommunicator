using _2WayMessenger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Interface
{
    public interface ISenderConfigurationRepository
    {
        Task<UserDetails?> GetSenderConfigurationAsync(string UserDetailID);
        bool AddSenderConfiguration(UserDetails userDetails);

        bool UpdateSenderConfiguration(UserDetails userDetails);
        bool DeleteSenderConfiguration(int vendorID);
    }
}
