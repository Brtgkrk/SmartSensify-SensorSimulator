using SensorSimulatorWPF2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorSimulatorWPF2.DataGeneration
{
    public class DataFactory
    {
        private double lastValue;

        public Sensor Sensor
        {
            get;
            private set;
        }

        public DataFactory(Sensor sensor)
        {
            Sensor = sensor;
        }
        
        public DataModel CreateRandomData()
        {
            var dataModel = new DataModel
            {
                secretKey = Sensor.SecretKey,
                data = new Data
                {
                    sensorId = Sensor.Id,
                    location = Sensor.Location,
                    timestamp = DateTime.Now,
                    readings = new List<Reading>()
                }
            };
            foreach (var type in Sensor.SensorTypes)
            {
                var newValue = GenerateValue(type);
                dataModel.data.readings.Add(new Reading
                {
                    type = type.Name,
                    unit = type.Unit,
                    value = newValue
                });
                type.LastValue = newValue;
            }
            return dataModel;
        }

       

        private double GenerateValue(SensorType type)
        {
            Random random = new Random();
            // Generate a random double within the specified range
            double randomValue = random.NextDouble() * (type.ValueMax - type.ValueMin) + type.ValueMin;
            
            // Calculate the maximum allowed change from the last value
            double maxChange = (Math.Abs(type.ValueMin) + Math.Abs(type.ValueMax)) / 100;
            
            // Ensure the generated value does not exceed the maximum change
            double minValue = Math.Max(type.ValueMin, lastValue - maxChange);
            double maxValue = Math.Min(type.ValueMax, lastValue + maxChange);

            // Clamp the randomValue within the allowed range
            double clampedValue = Math.Max(minValue, Math.Min(maxValue, randomValue));

            // Round the clampedValue to two decimal places
            double roundedValue = Math.Round(clampedValue, 2);

            lastValue = roundedValue;
            return roundedValue;
        }
    }
}
