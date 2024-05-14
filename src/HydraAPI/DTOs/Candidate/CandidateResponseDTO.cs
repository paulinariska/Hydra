namespace HydraAPI.DTOs.Candidate;

public class CandidateResponseDTO
{
    public int Id { get; set; }
    public int BootcampClassId { get; set; }
    public string FullName { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Domicile { get; set; } = null!;
    public bool HasPassed { get; set; }
    public bool? IsActive { get; set; }
}
