using HydraDataAccess.Models;

namespace HydraBusiness.Interfaces;

public interface ICandidateRepository
{
    List<Candidate> GetAllCandidates();
    List<Candidate> GetIndexCandidates(int pageNumber, int pageSize, string fullName, int batchBootcamp);
    Candidate? GetCandidate(int id);
    int CountData(string fullName, int batchBootcamp);
    void Insert(Candidate req);
    void Update(Candidate req);
    void Delete(int id);

}
