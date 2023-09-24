using SensorSimulatorWPF2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SensorSimulatorWPF2.Views
{
    /// <summary>
    /// Interaction logic for EditSensorView.xaml
    /// </summary>
    public partial class EditSensorView : Window
    {

        public EditSensorView()
        {
            InitializeComponent();
            RefreshSensorTypes();
        }

        private void RefreshSensorTypes()
        {
            listBoxSensorTypes.ItemsSource = SensorType.ReadAllSensorTypesFromFile();
        }

        private void SaveSensorClick(object sender, RoutedEventArgs e)
        {
            string sensorName = SensorNameText.Text;
            string sensorId = SensorIdText.Text;
            string sensorSecretKey = SensorSecretKeyText.Text;
            int sensorChangeSpeed;
            

            List<SensorType> selectedSensorTypes = new List<SensorType>();

            foreach (SensorType sensorType in listBoxSensorTypes.Items)
            {
                if (sensorType.IsSelected)
                {
                    selectedSensorTypes.Add(sensorType);
                }
            }

            if (string.IsNullOrWhiteSpace(sensorName) ||
                string.IsNullOrWhiteSpace(sensorId) ||
                string.IsNullOrWhiteSpace(sensorSecretKey) ||
                !int.TryParse(SensorChangeSpeedText.Text, out sensorChangeSpeed))
            {
                WarningText.Visibility = Visibility.Visible;
                return;
            }

            var sensor = new Sensor(sensorName, sensorId, sensorSecretKey, sensorChangeSpeed, selectedSensorTypes);
            MessageBox.Show($"Created new sensor: \n {sensor.ToString()}");
            sensor.SaveSensorToFile();                
            this.Close();
        }

        private void AddNewTypeClick(object sender, RoutedEventArgs e)
        {
            string name = TypeNameText.Text;
            string unit = TypeUnitText.Text;
            int valueMin;
            int.TryParse(ValueMinText.Text, out valueMin);
            int valueMax;
            int.TryParse(ValueMaxText.Text, out valueMax);

            if (String.IsNullOrEmpty(TypeNameText.Text) || String.IsNullOrEmpty(TypeUnitText.Text) || String.IsNullOrEmpty(ValueMinText.Text) || String.IsNullOrEmpty(ValueMaxText.Text))
            {
                WarningTypeText.Foreground = Brushes.Red;
                WarningTypeText.Content = "Complete entire type!";
                WarningTypeText.Visibility = Visibility.Visible;
            }
            else
            {
                WarningTypeText.Visibility = Visibility.Hidden;
                var sensorType = new SensorType(name, unit, valueMin, valueMax);
                if (sensorType.SaveSensorTypeToFile())
                {
                    WarningTypeText.Foreground = Brushes.Green;
                    WarningTypeText.Content = "Type properly added";
                    WarningTypeText.Visibility = Visibility.Visible;

                    TypeNameText.Text = "";
                    TypeUnitText.Text = "";
                    ValueMinText.Text = "";
                    ValueMaxText.Text = "";
                }
                RefreshSensorTypes();
            }
        }
    }
}
