using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightService : IFlightService
    { ShowLine showLine;
        public static ICollection <Flight> sourcee; //wala generique
        public FlightService(ICollection<Flight> source , ShowLine showLine) {
            sourcee = source;
            this.showLine = showLine;
        }
        public FlightService() { }
        public void ShowFlights(string filterType, string filterValue)
        {
            showLine($"filterType: {filterType} ,FilterValue: {filterValue}");
            switch (filterType)
            {    case "Destination":
                    
                 foreach (Flight flight in sourcee)
            {
                        showLine(flight);
                    }
                    break;

                case "FlightDate":
                    DateTime convertedDate = DateTime.Parse(filterValue);

                    foreach (Flight flight in sourcee)
                    {
                        if (flight.FlightDate == convertedDate)
                            showLine(flight);
                    }
                    break;
                case "FlightId":
                    int o = int.Parse(filterValue);

                    foreach (Flight flight in sourcee)
                    {
                        if (flight.FightId == o)
                            showLine(flight);
                    }
                    break;


                default:
                    throw new ArgumentException();



            }



        }
    }

}
