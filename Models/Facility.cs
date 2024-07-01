namespace Toverland_API_V2.Dtos.Facility;

public enum State
{
    Open,
    Closed,
    Maintenance
}

public enum FacilityType
{
    RIDE,
    FOOD_DRINKS,
    RESTROOM,
    FIRST_AID,
    INFORMATION,
    SHOW,
    SHOP
}

public class Facility
{

    public int Id { get; set; }
    public string Title { get; set; }

    public string SubTitle { get; set; }
    
    public string Description { get; set; }
    
    public string ImageUrl { get; set; }

    public string MapUrl { get; set; }
    public int WaitTime { get; set; }
    
    public FacilityType Type { get; set; }

    public State state { get; set; }
}