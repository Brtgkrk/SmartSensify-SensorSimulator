using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace SensorSimulatorWPF2.Models
{
    public class Location
    {
        public string x { get; set; }
        public string y { get; set; }
    }

    public class Reading
    {
        public string type { get; set; }
        public string unit { get; set; }
        public double value { get; set; }
    }

    public class Data
    {
        public string sensorId { get; set; }
        public DateTime timestamp { get; set; }
        public Location location { get; set; }
        public List<Reading> readings { get; set; }
    }

    public class DataModel
    {
        public string secretKey { get; set; }
        public Data data { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented);
        }
    }
}
