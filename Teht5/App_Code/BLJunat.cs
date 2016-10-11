using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLJunat
/// </summary>

namespace VR
{
    public class Station
    {
        public string stationName { get; set; }
        public string stationShortCode { get; set; }
    }

    public class Train
    {
        public string trainNumber { get; set; }
        public string cancelled { get; set; }
        public string departureDate { get; set; }
    }
}
