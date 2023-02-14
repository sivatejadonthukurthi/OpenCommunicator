using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReqChat.Interface;
using ReqChatRepository.Models;

namespace ReqChatRepository.Repository
{
    public class CandidateListRepository : ICandidateListRepository
    {
        private readonly appContext _context;

        public CandidateListRepository(appContext context)
        {
            _context = context;
        }
        public IEnumerable<CandidateList> GetCandidateID(string candidateID)
        {
            int recruiterId=0;
         var z= _context.Candidates
        .Include(c => c.Conversation)
        .AsEnumerable()
        .Where(candidate =>
            typeof(CandidateList)
            .GetProperties()
            .Select(props => props.GetValue(candidate, null))
            .Any(y => y?.ToString()?.Contains(candidateID) ?? false) &&
            candidate.Conversation?.RecruiterId == recruiterId);
        
            return _context.Candidates.AsEnumerable()
    .Where(candidates => typeof(CandidateList)
        .GetProperties()
        .Select(props => props.GetValue(candidates, null))
        .Any(y => y?.ToString()?.Contains(candidateID) ?? false));
        }
        public IEnumerable<CandidateList> GetCandidatebyKeyword(string keyWord)
        {

            int recruiterId = 123;

            var candidates= _context.Candidates
    .Include(c => c.Conversation)
    .AsEnumerable()
    .Where(candidate => candidate.Conversation != null && candidate.Conversation.RecruiterId == recruiterId)
    .Where(candidate => typeof(CandidateList)
        .GetProperties()
        .Concat(typeof(Conversation).GetProperties())
        .Any(prop =>
        {
            var value = prop.DeclaringType == typeof(CandidateList)
                ? prop.GetValue(candidate)
                : prop.DeclaringType == typeof(Conversation)
                    ? prop.GetValue(candidate.Conversation)
                    : null;

            return value != null && value.ToString().IndexOf(keyWord, StringComparison.OrdinalIgnoreCase) >= 0;
        }))
    .Select(candidate => candidate)
    .Take(10)
    .ToList();

            return candidates;

        }
        public IEnumerable<CandidateList> GetNextSetCandidatesWithKeyword(int presentCount, string keyWord)
        {


            return _context.Candidates.AsEnumerable()
    .Where(candidates => typeof(CandidateList)
        .GetProperties()
        .Select(props => props.GetValue(candidates, null))
        .Any(y => y?.ToString()?.Contains(keyWord) ?? false)).Skip(presentCount).Take(10).ToList();
        }

        public IEnumerable<CandidateList> GetCandidates()
        {
            int recruiterId = 123;
            
            return _context.Candidates
        .Include(c => c.Conversation)
        .AsEnumerable()
        .Where(candidate => candidate.Conversation != null && candidate.Conversation.RecruiterId == recruiterId)
        .Select(candidate => candidate).Take(10).ToList();
        }

        public IEnumerable<CandidateList> GetNextSetCandidates(int presentCount)
        {
            return _context.Candidates.Skip(presentCount).Take(10).ToList();
        }

        public CandidateList? GetCandidateDetails(int candidateID)
        {
            return _context.Candidates.FirstOrDefault(candidates => candidates.CandidateId == candidateID);
        }
        private static string GetCustomSentOnFormat(DateTime sentOn)
        {
            var today = DateTime.Today;
            var timeSpan = today - sentOn.Date;

            if (timeSpan.Days == 0)
            {
                return sentOn.ToString("HH:mm");
            }
            else if (timeSpan.Days == 1)
            {
                return "Yesterday";
            }
            else if (sentOn >= today.AddDays(-7))
            {
                return sentOn.ToString("dddd");
            }
            else
            {
                return sentOn.ToString("MMM dd");
            }
        }

    }
}
