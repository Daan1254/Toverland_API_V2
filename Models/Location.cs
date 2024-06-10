using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public enum CordinalDirection {
    NORTH,
    NORTH_EAST,
    EAST,
    SOUTH_EAST,
    SOUTH,
    SOUTH_WEST,
    WEST,
    NORTH_WEST,
}

namespace Toverland_API.Models
{
public class Location
    {
        private int Id { get; set; }

        public decimal Latitude  { get; set; }

        public decimal Longitude { get; set; }

        public CordinalDirection Direction { get; set; }

        public Location(int Id)
        {
            this.Id = Id;
        }


        public void NavigateTo() {

        }

        public void SetDirection(CordinalDirection direction) {
            
        }
    }
}