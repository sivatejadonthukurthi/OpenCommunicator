using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2WayMessenger.Model;

namespace _2WayMessenger.Interface
{
    public interface IVendorRepository
    {
        Task<Vendor?> GetVendorAsync(string UserDetailID);
        bool AddVendor(Vendor vendor);

        bool UpdateVendor(Vendor vendor);
        bool DeleteVendor(int vendorID);
    }
}
