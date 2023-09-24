using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SensorSimulatorWPF2.Models;

public class Sensor
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string SecretKey { get; set; }
    public int ChangeSpeed { get; set; }
    public int DataGenerationSpeed { get; set; } = 1000;
    public bool IsSelected { get; set; }
    public string IsDataGenerating { get; set; }
    public List<SensorType> SensorTypes { get; set; } = new List<SensorType>();
    public Location Location { get; internal set; }

    public Sensor() { }

    public Sensor(string name, string id, string secretKey, int changeSpeed, List<SensorType> sensorTypes)
    {
        Name = name;
        Id = id;
        SecretKey = secretKey;
        ChangeSpeed = changeSpeed;
        SensorTypes = sensorTypes;
    }

    public override string ToString()
    {
        var message = $"Name: {Name}, Id: {Id}, Secret Key: {SecretKey}, Speed: {ChangeSpeed} Types: ";
        foreach (var type in SensorTypes)
        {
            message += $"\n{type.Name} {type.Unit} {type.ValueMin} - {type.ValueMax}";
        }
        return message;
    }

    public void SaveSensorToFile()
    {
        string sensorCsv = $"{this.Name},{this.Id},{this.SecretKey},{this.ChangeSpeed}";
        foreach (var sensorType in SensorTypes)
        {
            sensorCsv += $",{sensorType.Name}";
        }
        string filePath = "sensors.csv";
        using (StreamWriter writer = new StreamWriter(filePath, append: true))
        {
            writer.WriteLine(sensorCsv);
        }
    }

    public static List<Sensor> ReadAllSensorsFromFile()
    {
        var sensorList = new List<Sensor>();
        string filePath = "sensors.csv";
        if (File.Exists(filePath))
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    sensorList.Add(GenerateSensorFromCsvLine(line));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading sensors from CSV file (possibly you need to add a sensor): {ex.Message}"); 
            }
        }
        return sensorList;
    }

    private static Sensor GenerateSensorFromCsvLine(string line)
    {
        string[] values = line.Split(',');
        const int minValuesToCreateSensor = 4;
        if (values.Length >= minValuesToCreateSensor)
        {
            int changeSpeedValue;
            int.TryParse(values[3], out changeSpeedValue);
            Sensor sensor = new Sensor
            {
                Name = values[0],
                Id = values[1],
                SecretKey = values[2],
                ChangeSpeed = changeSpeedValue
            };
            for (int i = 4; i < values.Length; i++)
            {
                sensor.SensorTypes.Add(SensorType.GetSensorTypeByName(values[i]));
            }

            return sensor;
        }
        return null;
    }
}
