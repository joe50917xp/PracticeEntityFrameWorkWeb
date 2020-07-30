using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoeCodeMvcOracleExample.UI.Web.Models.Home
{
    public class Index
    {
        public int OracleRecordCount { get; set; }
        public List<Flight> Flights { get; set; }


        public class Flight
        {
            public string FlightDate { get; set; }
            public string FlightNbr { get; set; }
            public string FlightArrStn { get; set; }
        }
    }
    
}