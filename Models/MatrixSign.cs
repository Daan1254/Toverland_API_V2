using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toverland_API.Models
{
public class MatrixSign
    {
        private int Id { get; set;}

        public List<Facility> Facilities { get; set;} = new List<Facility>();

        public Location Location { get; private set;}

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public MatrixSign(int Id, List<Facility> facilities, Location location)
        {
            this.Id = Id;
            this.Facilities = facilities;
            this.Location = location;
        }

        public List<Facility> UpdateFacilities(List<Facility> facilities) 
        {
            // By Reference & By Value 

            return facilities;
        }

        public void Move(List<Facility> facilities, Location location) {
            
        }

        private void UpdateLocation(Location location) {

        }
    }
}