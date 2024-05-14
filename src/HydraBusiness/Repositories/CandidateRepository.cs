using HydraBusiness.Interfaces;
using HydraDataAccess.Models;

namespace HydraBusiness.Repositories;

public class CandidateRepository : ICandidateRepository
{
    private readonly HydraContext _context;

    public CandidateRepository(HydraContext context)
    {
        _context = context;
    }

    public int CountData(string fullName, int batchBootcamp)
    {
        return _context.Candidates
                .Where(cand => (cand.FirstName+cand.LastName).ToLower().Contains(fullName??"".ToLower()) && (cand.BootcampClassId == null || cand.BootcampClassId == batchBootcamp))
                .Count();
    }

    public void Delete(int id)
    {
        try
        {
            var candidate = _context.Candidates.Find(id);
            _context.Remove(candidate);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public List<Candidate> GetAllCandidates()
    {
        return _context.Candidates.ToList();
    }

    public Candidate? GetCandidate(int id)
    {
        return _context.Candidates.Find(id);
    }

    public List<Candidate> GetIndexCandidates(int pageNumber, int pageSize, string fullName, int batchBootcamp)
    {
        return _context.Candidates
                .Where(cand => (cand.FirstName+cand.LastName).ToLower().Contains(fullName??"".ToLower()) && (cand.BootcampClassId == null || cand.BootcampClassId == batchBootcamp))
                .Skip((pageNumber-1) * pageSize)
                .Take(pageSize)
                .ToList();
    }

    public void Insert(Candidate candidate)
    {
        try
        {
            _context.Candidates.Add(candidate);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Update(Candidate candidate)
    {
        try
        {
            _context.Candidates.Update(candidate);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
