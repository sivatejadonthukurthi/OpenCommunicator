

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
        IEnumerable<CandidateList> GetCandidatebyKeyword(string keyWord);

        IEnumerable<CandidateList> GetNextSetCandidatesWithKeyword(int presentCount,string keyWord);
         CandidateList? GetCandidateDetails(int candidateID);

        // void UpdateEmployee(CandidateList candidate);
    }
}
