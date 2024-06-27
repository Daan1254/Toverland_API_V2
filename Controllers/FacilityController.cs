
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
            Title = "Fēnix",
            WaitTime = 15,
            state = State.Open
        },
        new FacilityDto
        {
            Title = "Troy",
            WaitTime = 20,
            state = State.Open
        },
        new FacilityDto
        {
            Title = "Dwervelwind",
            WaitTime = 10,
            state = State.Open
        },
        new FacilityDto
        {
            Title = "Maximus' Blitz Bahn",
            WaitTime = 5,
            state = State.Maintenance
        },
        new FacilityDto
        {
            Title = "Merlin's Quest",
            WaitTime = 0,
            state = State.Closed
        },
        new FacilityDto
        {
            Title = "Djengu River",
            WaitTime = 25,
            state = State.Open
        },
        new FacilityDto
        {
            Title = "Toos-Express",
            WaitTime = 10,
            state = State.Open
        },
        new FacilityDto
        {
            Title = "Boomerang",
            WaitTime = 15,
            state = State.Maintenance
        },
        new FacilityDto
        {
            Title = "Merlin's Quest",
            WaitTime = 5,
            state = State.Closed
        },
        new FacilityDto
        {
            Title = "Expedition Zork",
            WaitTime = 30,
            state = State.Open
        }
    };
    [HttpGet]
    public ActionResult<List<FacilityDto>> GetAll() {
        return Ok(facilities);
    }
    
    [HttpPost]
    public ActionResult<FacilityDto> Create([FromBody] FacilityDto facility)
    {


        return Ok(facility);
    }
   
}