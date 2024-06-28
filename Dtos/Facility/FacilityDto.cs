namespace Toverland_API_V2.Dtos.Facility;

public enum State
{
    Open,
    Closed,
    Maintenance
}

public class FacilityDto
{

    public int Id { get; set; }
    public string Title { get; set; }
    public int WaitTime { get; set; }

    public State state { get; set; }
}