using AM.ApplicationCore;
using AM.ApplicationCore.Services;

namespace AM.UI.Console
{
    public class Chap2
    {

        static ShowLine showLine = System.Console.WriteLine;


        public void Test1()
        {
            FlightService servF = new FlightService();
            servF.sourcee = InMemorySource.Flights;
            servF.sourcee("Destination", "Paris");
            servF.sourcee("Destination", "Madrid");
            servF.sourcee("Fight id", 3);

        }
    }
}
