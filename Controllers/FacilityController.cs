
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Toverland_API_V2.Dtos.Facility;
using Toverland_API.Data;

namespace Toverland_API_V2.Controllers;
[ApiController]
[Route("api/[controller]")]
public class FacilityController(ApplicationDBContext context) : ControllerBase
{
    private readonly ApplicationDBContext _context = context;
    List<Facility> facilities = new List<Facility>
    {
        new Facility
        {
            Id = 1,
            Title = "Coco Bolo",
            WaitTime = 15,
            state = State.Open,
            SubTitle = "Toren",
            Description = "Trek jezelf omhoog langs deze reusachtige rots en begroet het magische wezen, dat uit haar ei is gebroken. Geniet van het uitzicht en glijd weer naar beneden.",
            ImageUrl = "/images/MINI_COCOBOLO.png",
            MapUrl = "/images/C_ACHTERGROND.png",
            Type = FacilityType.RIDE
        },
        new Facility
        {
            Id = 3,
            Title = "Dwervelwind",
            SubTitle = "Draaiende achtbaan",
            Description = "Dwervelwind is een achtbaan die je wereld op zijn kop zet. De karretjes draaien om hun as en zorgen voor een onvergetelijke rit. Durf jij het aan?",
            WaitTime = 25,
            state = State.Open,
            ImageUrl = "/images/MINI_DWERVELWIND.png",
            MapUrl = "/images/D_ACHTERGROND.png",
            Type = FacilityType.RIDE
        },
        new Facility
        {
            Id = 5,
            Title = "Merlin's Quest",
            SubTitle = "Boottocht met darkride",
            Description = "Stap in een van de boten en vaar langs de geheimen van de tovenaar. Ontdek de magische wereld van Avalon en help Merlijn de tovenaar bij zijn zoektocht naar de heilige graal.",
            WaitTime = 0,
            state = State.Closed,
            MapUrl = "/images/M_ACHTERGROND.png",
            ImageUrl = "/images/MINI_MERLINSQUEST.png",
            
            Type = FacilityType.RIDE
        },
        new Facility
        {
            Id = 6,
            Title = "Pixarus",
            SubTitle = "Spannende vlietuigmolen",
            Description = "Stap in een van de vliegtuigjes en vlieg mee met Pixarus. Vlieg over de wereld van Avalon en geniet van het uitzicht.",
            WaitTime = 25,
            state = State.Open,
            MapUrl = "/images/P_ACHTERGROND.png",
            ImageUrl = "/images/MINI_PIXARUS.png",
            Type = FacilityType.RIDE
        },
        new Facility
        {
            Id = 7,
            Title = "Waterdwarf Alley",
            SubTitle = "Interactieve kijktaferelen",
            Description = "In Waterdwarf Alley kun je de dwergen van Avalon ontmoeten. Ze hebben een prachtige stad gebouwd en jij mag een kijkje nemen. Ontdek de geheimen van de dwergen en geniet van de prachtige kijktaferelen.",
            WaitTime = 0,
            state = State.Maintenance,
            MapUrl = "/images/W_ACHTERGROND.png",
            ImageUrl = "/images/MINI_WATERDWARFALLEY.png",
            Type = FacilityType.RIDE
        },
        new Facility
        {
            Id = 8,
            Title = "Spirello",
            SubTitle = "Take-away",
            Description = "Geopend vanaf 12.00",
            WaitTime = 5,
            state = State.Open,
            ImageUrl = "/images/MINI_SPIRELLO.png",
            MapUrl = "/images/S_ACHTERGROND.png",
            Type = FacilityType.FOOD_DRINKS
        },
    };
    
    [HttpGet]
    public async Task<ActionResult<List<Facility>>> GetAll()
    {
        return (await _context.Facility.ToListAsync());
    }
    
    
    [HttpGet("{id}")]
    public ActionResult<Facility> Get([FromRoute] int id)
    {
        Facility? facility = _context.Facility.Find(id);

        if (facility == null) {
            return NotFound();
        }

        return Ok(facility);
    }
    
    [HttpPost]
    public ActionResult<Facility> Create([FromBody] Facility facility)
    {
        return Ok(facility);
    }
   
}