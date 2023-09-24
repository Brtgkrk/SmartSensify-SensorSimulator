using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SensorSimulatorWPF2.Models;

public class SensorType : INotifyPropertyChanged
{
    public string Name { get; set; }
    public string Unit { get; set; }
    public double ValueMin { get; set; }
    public double ValueMax { get; set; }
    public bool IsSelected { get; set; }
    private double _lastValue;
    public double LastValue
    {
        get => _lastValue;
        set
        {
            if (_lastValue != value)
            {
                _lastValue = value;
                OnPropertyChanged(nameof(LastValue));
            }
        }
    }

    public SensorType() { }
    public SensorType(string name, string unit, double valueMin, double valueMax)
    {
        Name = name;
        Unit = unit;
        ValueMin = valueMin;
        ValueMax = valueMax;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public bool SaveSensorTypeToFile()
    {
        try
        {
            string sensorTypeCsv = $"{this.Name},{this.Unit},{this.ValueMin},{this.ValueMax}";
            string filePath = "sensorTypes.csv";
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine(sensorTypeCsv);
            }
        }
        catch (Exception ex)
        {
            throw new FileNotFoundException($"Some problems with saving to file {ex.Message}");
        }
        return true;
    }

    public static SensorType GetSensorTypeByName(string name)
    {
        var allSensorsTypes = ReadAllSensorTypesFromFile();
        foreach (var sensorType in allSensorsTypes)
        {
            if (sensorType.Name == name) return sensorType;
        }
        return null;
    }

    public static List<SensorType> ReadAllSensorTypesFromFile()
    {
        var sensorTypeList = new List<SensorType>();
        string filePath = "sensorTypes.csv";
        if (File.Exists(filePath))
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    sensorTypeList.Add(GenerateSensorTypeFromCsvLine(line));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading sensor types from CSV file (possibly you need to add a sensor): {ex.Message}");
            }
        }
        return sensorTypeList;
    }

    private static SensorType GenerateSensorTypeFromCsvLine(string line)
    {
        string[] values = line.Split(',');
        const int minValuesToCreateSensorType = 4;
        if (values.Length >= minValuesToCreateSensorType)
        {
            int valueMin;
            int.TryParse(values[2], out valueMin);
            int valueMax;
            int.TryParse(values[3], out valueMax);
            SensorType sensorType = new SensorType
            {
                Name = values[0],
                Unit = values[1],
                ValueMin = valueMin,
                ValueMax = valueMax
            };

            return sensorType;
        }
        return null;
    }
}