using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReqChat.Interface;
using ReqChatRepository.Models;

namespace ReqChatcassendra.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private ICandidateListRepository _candidateListRepository;
        public CandidatesController(ICandidateListRepository candidateListRepository)
        {
            _candidateListRepository = candidateListRepository;
        }

        [HttpGet]
        public IEnumerable<CandidateList> Get()
        {
            return _candidateListRepository.GetCandidates();
        }

        [HttpGet("NextSet")]
        public IEnumerable<CandidateList> GetNextSet(int setLoaded)
        {
            return _candidateListRepository.GetNextSetCandidates(setLoaded);
        }
        [HttpGet("Filtered")]
        public IEnumerable<CandidateList> Filtered(string keyWord)
        {
            
            return _candidateListRepository.GetCandidatebyKeyword(keyWord);
        }
        [HttpGet("FilteredNextset")]
        public IEnumerable<CandidateList> GetFilteredNextSet(int setLoaded,string keyWord)
        {
            return _candidateListRepository.GetNextSetCandidatesWithKeyword(setLoaded,keyWord);
        }

    }
}
