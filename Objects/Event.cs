using Microsoft.AspNetCore.Components;

public class Event {
    required public string Title { get; set; }
    required public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    required public string LocationName { get; set; }
    public string? LocationURL { get; set; }
    required public string AddressLine1 { get; set; }
    required public string AddressLine2 { get; set; }
    required public string Cost { get; set; }
    public string? MainImageUrl { get; set; }
    public string? Description { get; set; }
    public string? FacebookEventUrl { get; set; }
    public Dictionary<string, string>? OtherLinks { get; set; }
}