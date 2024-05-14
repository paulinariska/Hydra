using HydraAPI.DTOs.Candidate;
using HydraBusiness.Interfaces;
using HydraDataAccess.Models;

namespace HydraAPI.Services;

public class CandidateService
{
    private readonly ICandidateRepository _repository;

    public CandidateService(ICandidateRepository repository)
    {
        _repository = repository;
    }

    public List<CandidateResponseDTO> Get (int pageNumber, int pageSize, string fullName, int batchBootcamp){
        return _repository.GetIndexCandidates(pageNumber, pageSize, fullName, batchBootcamp)
            .Select(cand => new CandidateResponseDTO()
            {
                Id = cand.Id,
                FullName = cand.FirstName + " " + (cand.LastName ==null ? "" : cand.LastName),
                BirthDate = cand.BirthDate,
                Gender = cand.Gender,
  
                Address = cand.Address,
                BootcampClassId = cand.BootcampClassId,
                PhoneNumber = cand.PhoneNumber,
                Domicile = cand.Domicile,
                HasPassed = cand.HasPassed,
                IsActive = cand.IsActive
            }).ToList();
    }

    public void Insert(CandidateInsertDTO dto){
        var candidate = new Candidate(){
            BootcampClassId = dto.BootcampClassId,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Gender = dto.Gender,
            BirthDate = dto.BirthDate,
            Address = dto.Address,
            Domicile = dto.Domicile,
            PhoneNumber = dto.PhoneNumber
        };

        _repository.Insert(candidate);
    }

    public void Update (CandidateUpdateDTO dto){
        var candidate = _repository.GetCandidate(dto.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kandidat")); 
        candidate.BootcampClassId = dto.BootcampClassId;
        candidate.FirstName = dto.FirstName;
        candidate.LastName = dto.LastName;
        candidate.Gender = dto.Gender;
        candidate.BirthDate = dto.BirthDate;
        candidate.Address = dto.Address;
        candidate.Domicile = dto.Domicile;
        candidate.PhoneNumber = dto.PhoneNumber;

        _repository.Update(candidate);
    }

    public void Delete (int id){
        // var candidate = _repository.GetCandidate(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kandidat"));
        
        _repository.Delete(id);
    }

    public CandidateResponseDTO GetDetail (int id){
        var candidate = _repository.GetCandidate(id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("kandidat"));
        return new CandidateResponseDTO(){
            Id = candidate.Id,
            FullName = candidate.FirstName+ " " + (candidate.LastName ==null ? "" : candidate.LastName),
            Gender = candidate.Gender,
            BootcampClassId = candidate.BootcampClassId,
            BirthDate = candidate.BirthDate,
            Address = candidate.Address,
            Domicile = candidate.Address,
            HasPassed = candidate.HasPassed,
            IsActive = candidate.IsActive
        };
    }

    public int Count(string fullName, int batchBootcamp)
    {
        return _repository.CountData(fullName, batchBootcamp);
    }
}
