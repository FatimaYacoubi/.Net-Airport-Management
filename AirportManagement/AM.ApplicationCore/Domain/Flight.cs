using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Departure{ get; set; }
        public string Destination { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public float EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public int FightId { get; set; }
        public virtual Plane Plane { get; set; }
        public virtual IList<Passenger> passengers { get; set; }

        public override string ToString()
        {
            return "Flight Id :" + FightId + ", Destination : " + Destination + ", Date : " + FlightDate;

        }
    }
}