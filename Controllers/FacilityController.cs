
using Microsoft.AspNetCore.Mvc;
using Toverland_API_V2.Dtos.Facility;
using Toverland_API.Data;

namespace Toverland_API_V2.Controllers;
[ApiController]
[Route("api/[controller]")]
public class FacilityController(ApplicationDBContext context) : ControllerBase
{
    private readonly ApplicationDBContext _context = context;
    List<FacilityDto> facilities = new List<FacilityDto>
    {
        new FacilityDto
        {
            Id = 1,
            Title = "Fēnix",
            WaitTime = 15,
            state = State.Open
        },
        new FacilityDto
        {
            Id = 2,
            Title = "Troy",
            WaitTime = 20,
            state = State.Open
        },
        new FacilityDto
        {
            Id = 3,
            Title = "Dwervelwind",
            WaitTime = 10,
            state = State.Open
        },
        new FacilityDto
        {
            Id = 4,
            Title = "Maximus' Blitz Bahn",
            WaitTime = 5,
            state = State.Maintenance
        },
        new FacilityDto
        {
            Id = 5,
            Title = "Merlin's Quest",
            WaitTime = 0,
            state = State.Closed
        },
        new FacilityDto
        {
            Id = 6,
            Title = "Djengu River",
            WaitTime = 25,
            state = State.Open
        },
        new FacilityDto
        {
            Id = 7,
            Title = "Toos-Express",
            WaitTime = 10,
            state = State.Open
        },
        new FacilityDto
        {
            Id = 8,
            Title = "Boomerang",
            WaitTime = 15,
            state = State.Maintenance
        },
        new FacilityDto
        {
            Id = 9,
            Title = "Merlin's Quest",
            WaitTime = 5,
            state = State.Closed
        },
        new FacilityDto
        {
            Id = 10,
            Title = "Expedition Zork",
            WaitTime = 30,
            state = State.Open
        }
    };
    [HttpGet]
    public ActionResult<List<FacilityDto>> GetAll() {
        return Ok(facilities);
    }
    
    
    [HttpGet("{id}")]
    public ActionResult<FacilityDto> Get([FromRoute] int id) {
        FacilityDto? facility = facilities.Find(f => f.Id == id);

        if (facility == null) {
            return NotFound();
        }

        return Ok(facility);
    }
    
    [HttpPost]
    public ActionResult<FacilityDto> Create([FromBody] FacilityDto facility)
    {


        return Ok(facility);
    }
   
}