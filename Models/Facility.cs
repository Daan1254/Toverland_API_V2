using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public enum FacilityType {
    RIDE,
    FOOD_DRINKS,
    RESTROOM,
    FIRST_AID,
    INFORMATION,
    SHOW,
    SHOP
}

namespace Toverland_API.Models
{
    public class Facility
    {
        private int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int? WaitTime { get; set; }

        public Location Location { get; private set; }

        public CordinalDirection Direction { get; set; }

        public int? MatrixSignId { get; set; }

        public MatrixSign? MatrixSign { get; set; }

        public FacilityType Type { get; set; } = FacilityType.RIDE;


        public Facility(int Id, Location location) 
        {
            this.Id = Id;
            this.Location = location;
        }

        public void SetWaitTime(int WaitTime) {

        }

        public void Move(Location location) {

        }
    }
}