using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReqChatRepository.Models;

namespace ReqChatRepository
{
    public class appContext:DbContext
    {
    public appContext(DbContextOptions options) : base(options)
    {
    }

       // public DbSet<Root> Roots { get; set; }
        public DbSet<CandidateList> Candidates { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<AllMessage> messages { get; set; }
        public DbSet<SystemUserInformation> DeskUser { get; set; }

        public DbSet<CandidateReq> candidateReqs { get; set; }


    }
}
