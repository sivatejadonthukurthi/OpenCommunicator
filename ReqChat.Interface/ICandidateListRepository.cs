using ReqChatRepository.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqChat.Interface
{
    public interface ICandidateListRepository
    {
        IEnumerable<CandidateList> GetCandidates();
        IEnumerable<CandidateList> GetNextSetCandidates(int presentCount);
        CandidateList GetCandidateID(int candidateID);
      //  void InsertCandidate(CandidateList candidate);
        
       // void UpdateEmployee(CandidateList candidate);
    }
}
