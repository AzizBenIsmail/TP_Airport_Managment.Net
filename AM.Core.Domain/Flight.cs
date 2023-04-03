using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    //[Table("MyFlight")]
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set;}
        public int EstimatedDuration { get; set; }
        //[ForeignKey("PlaneId")] ou bien
        public Plane MyPlane { get; set; }

        [ForeignKey("MyPlane")]
        public int PlaneId { get; set; } //prop
        public IList<Passenger> passengers { get; set; }
        public String Comment { get; set; }
        public override string ToString()
        {
            return "Destination:" + Destination + ";"
                + "Departure:" + Departure + ";"
                + "FlightDate:" + FlightDate + ";"
                + "FlightId:" + FlightId + ";"
                + "EffectiveArrival:" + EffectiveArrival + ";"
                + "EstimatedDuration:" + EstimatedDuration;
        }
    }
}
