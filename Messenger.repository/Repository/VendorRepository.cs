using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2WayMessenger.Model;
using _2WayMessenger.Interface;
using Microsoft.EntityFrameworkCore;

namespace _2WayMessenger.Repository
{
    public class VendorRepository : IVendorRepository
    {
        private readonly appContext _context;

        public VendorRepository(appContext context)
        {
            _context = context;
        }

        public bool AddVendor(Vendor vendor)
        {
            try
            {

                _context.Vendors.Add(vendor);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                // Handle the exception or log it.
                return false;
            }
        }

        public bool DeleteVendor(int vendorID)
        {
            var vendorToDelete = _context.Vendors.FirstOrDefault(v => v.VendorId == vendorID);
            if (vendorToDelete == null)
            {
                return false; // or some other error response
            }

            _context.Vendors.Remove(vendorToDelete);
            _context.SaveChanges();
            return true;
        }

        public async Task<Vendor?> GetVendorAsync(string UserDetailID)
        {
            var query = from userDetails in _context.UserDetails
                        join client in _context.clientVendors on userDetails.ConsumerClientId equals client.ConsumerClientId
                        join vendors in _context.Vendors on client.ConsumerId equals vendors.ConsumerID
                        where userDetails.Userid == UserDetailID
                        select vendors;



            Vendor? vendor = await query.FirstOrDefaultAsync();
            return vendor;
        }
        

        public bool UpdateVendor(Vendor vendor)
        {
            var vendorToUpdate = _context.Vendors.FirstOrDefault(vendorList => vendorList.VendorId == vendor.VendorId);
            
            _context.Vendors.Update(vendor);
            _context.SaveChanges();
            return true;
        }
    }
}
