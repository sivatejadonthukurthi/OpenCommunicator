using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using _2WayMessenger.Model;
using _2WayMessenger.Repository;

namespace _2WayMessenger.Repository
{
    public class appContext:DbContext
    {
    public appContext(DbContextOptions options) : base(options)
    {
    }

       // public DbSet<Root> Roots { get; set; }
        public DbSet<RecieversInfo> recievers { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<AllMessage> messages { get; set; }       

        public DbSet<Vendor> Vendors { get; internal set; }
        public DbSet<UserDetails> UserDetails { get; internal set; }
        public DbSet<ClientVendors> clientVendors { get; internal set; }
        public DbSet<ExceptionLog> ExceptionLogs { get; internal set; }

        public DbSet<Consumers> consumers { get; internal set; }
    }
}

