namespace HydraAPI;

public class TemplateResponseDTO
{
    public string Id { get; set; } = null;
    public string Name { get; set; } = null;
    public string Unit { get; set; } = null;
    public decimal Stock { get; set; }
    public decimal MinimumStock { get; set; }
}
