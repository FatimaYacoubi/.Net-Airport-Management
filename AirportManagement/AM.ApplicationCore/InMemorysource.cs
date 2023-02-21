using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public static class InMemorySource
    { //cette classe stocke les donnees 
        public static Plane Boeing1 { get; private set; }
        public static readonly Plane Boeing2 = new Plane(PlaneType.Boeing, 150, new DateTime(2015, 2, 3)) { PlaneId = 2, Flights = new List<Flight> { flight3, flight4 } };
        public static readonly Plane Airbus = new Plane()
        {
            PlaneId = 3,
            PlaneType = PlaneType.Airbus,
            ManufactureDate = new DateTime(2020, 11, 11),
            Capacity = 250,
            Flights = new List<Flight> { flight4, flight5 }

        };
        static Plane GetFirstPlane()
        {
            Plane plane = new Plane();
            plane.PlaneId = 1;
            plane.PlaneType = PlaneType.Boeing;
            plane.Capacity = 200;
            plane.ManufactureDate = new DateTime(2019, 12, 13);
            plane.Flights = new List<Flight> { flight1, flight2 };
            return plane;

        }
        public static readonly Staff staffCaptain = new Staff
        {
            FirstName = "captain",
            LastName = "Captain",
            EmailAdress = "captain@gmail.com",
            BirthDate = new DateTime(1965, 01, 01),
            EmployementDate = new DateTime(1999, 01, 01),
            Salary = 10000,
            Flights = new List<Flight> { flight1, flight3 }


        };
        public static readonly Staff staffHostess1 = new Staff
        {
            FirstName = "hostess1",
            LastName = "Hostess1",
            EmailAdress = "hostess1@gmail.com",
            BirthDate = new DateTime(1995, 01, 01),
            EmployementDate = new DateTime(2019, 01, 01),
            Salary = 5000,
            Flights = new List<Flight> { flight1, flight3 }
        };

        public static readonly Staff staffHostess2 = new Staff
        {
            FirstName = "hostess2",
            LastName = "Hostess2",
            EmailAdress = "hostess2@gmail.com",
            BirthDate = new DateTime(1996, 01, 01),
            EmployementDate = new DateTime(2018, 01, 01),
            Salary = 6100,
            Flights = new List<Flight> { flight1, flight3 }
        };

        public static readonly Traveller traveller1 = new Traveller
        {
            FirstName = "traveller1",
            LastName = "Traveller1",
            BirthDate = new DateTime(1980, 01, 01),
            HealthInformation = "No troubles",
            Nationality = "American",
            Flights = new List<Flight> { flight2, flight3 }
        };
        public static readonly Traveller traveller2 = new Traveller
        {
            FirstName = "traveller2",
            LastName = "Traveller2",
            BirthDate = new DateTime(1981, 01, 01),
            HealthInformation = "some troubles",
            Nationality = "frensh",
            Flights = new List<Flight> { flight2, flight3 }

        };
        public static readonly Traveller traveller3 = new Traveller
        {
            FirstName = "traveller3",
            LastName = "Traveller3",
            BirthDate = new DateTime(1982, 01, 01),
            HealthInformation = "No troubles",
            Nationality = "Tunisian",
            Flights = new List<Flight> { flight2, flight3 }

        };
        public static readonly Traveller traveller4 = new Traveller
        {
            FirstName = "traveller4",
            LastName = "Traveller4",
            BirthDate = new DateTime(1983, 01, 01),
            HealthInformation = "some troubles",
            Nationality = "American",
            Flights = new List<Flight> { flight2, flight3 }

        };
        public static readonly Traveller traveller5 = new Traveller
        {
            FirstName = "traveller5",
            LastName = "Traveller5",
            BirthDate = new DateTime(1984, 01, 01),
            HealthInformation = "some troubles",
            Nationality = "Spanish",
            Flights = new List<Flight> { flight2, flight3 }

        };
        public static List<Staff> Staffs = new List<Staff> { staffCaptain, staffHostess1, staffHostess2 };
        public static List<Traveller> Travellers = new List<Traveller> { traveller1, traveller2, traveller3, traveller4, traveller5 };


        public static readonly Flight flight1 = new Flight
        {
            FightId = 1,
            FlightDate = new DateTime(2022, 01, 01, 15, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 01, 17, 10, 10),
            EstimatedDuration = 2,
            Plane = Boeing1,
            passengers = new List<Passenger> { staffCaptain, staffHostess2, staffHostess1 }
        };

        public static readonly Flight flight2 = new Flight
        {
            FightId = 2,
            FlightDate = new DateTime(2022, 02, 01, 21, 10, 0),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 0),
            EstimatedDuration = 2,
            Plane = Boeing1,
            passengers = new List<Passenger> { traveller1, traveller2, traveller3, traveller4, traveller5 }

        };
        public static readonly Flight flight3 = new Flight
        {
            FightId = 3,
            FlightDate = new DateTime(2022, 03, 01, 5, 10, 0),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 03, 01, 7, 10, 0),
            EstimatedDuration = 2,
            Plane = Boeing2,
            passengers = new List<Passenger> { traveller1, traveller2, traveller3, traveller4, traveller5, staffCaptain, staffHostess1, staffHostess2 }

        };
        public static readonly Flight flight4 = new Flight
        {
            FightId = 4,
            FlightDate = new DateTime(2022, 04, 01, 6, 10, 0),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 04, 01, 8, 10, 0),
            EstimatedDuration = 2.5f,
            Plane = Boeing2
        };
        public static readonly Flight flight5 = new Flight
        {
            FightId = 5,
            FlightDate = new DateTime(2022, 05, 01, 17, 10, 0),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 05, 01, 19, 10, 0),
            EstimatedDuration = 2.5f,
            Plane = Airbus
        };
     

        public static List<Flight> Flights = new List<Flight> { flight1, flight2, flight3, flight4, flight5};







    }
}