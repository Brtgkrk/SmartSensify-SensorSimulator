using SensorSimulatorWPF2.Models;
using SensorSimulatorWPF2.DataGeneration;
using SensorSimulatorWPF2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace SensorSimulatorWPF2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsDataGenerating = false;
        private List<DataFactory> dataFactories = new List<DataFactory>();
        private List<Sensor> selectedSensors = new List<Sensor>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RefreshButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshSensors();
        }

        private void RefreshSensors()
        {
            var sensors = Sensor.ReadAllSensorsFromFile();
            listBoxSensors.ItemsSource = sensors;
            RefreshDataFactories();
        }

        private void RefreshDataFactories()
        {
            dataFactories = new List<DataFactory>();
            foreach (var sensor in selectedSensors)
            {
                dataFactories.Add(new DataFactory(sensor));
            }
        }

        private void AddNewSensorButtonClick(object sender, RoutedEventArgs e)
        {
            var editSensorView = new EditSensorView();
            editSensorView.ShowDialog();
        }

        private void GetSelectedSensors(object sender, RoutedEventArgs e)
        {
            var sensors = new List<Sensor>();

            foreach (Sensor sensor in listBoxSensors.Items)
            {
                if (sensor.IsSelected)
                {
                    sensors.Add(sensor);
                }
            }
            //MessageBox.Show("checked");
            selectedSensors = sensors;
            RefreshDataFactories();
        }

        private void GenerateDataClick(object sender, RoutedEventArgs e)
        {
            GenerateDataButtonChange();
            GenerateData(1000);
        }

        private async void GenerateData(int miliseconds)
        {
            while(true)
            {
                if (IsDataGenerating)
                {
                    var dataGenerationTasks = dataFactories.Select(async dataFactory =>
                    {
                        while (IsDataGenerating)
                        {
                            // Generate and log data
                            //Debug.WriteLine(dataFactory.CreateRandomData().ToJson());
                            bool isTaskSuccesful = await HttpClientHelper.SendDataAsync(dataFactory.CreateRandomData().ToJson());

                            if (!isTaskSuccesful) MessageBox.Show("Error when sending data to API!");

                            // Get the data generation speed from the sensor
                            int dataGenerationSpeed = dataFactory.Sensor.DataGenerationSpeed;

                            // Delay based on the data generation speed
                            await Task.Delay(dataGenerationSpeed);
                        }
                    }).ToArray();

                    await Task.WhenAll(dataGenerationTasks);
                }
                else
                {
                    return;
                }    
                //MessageBox.Show(dataFactories[0].Sensor.SensorTypes[0].LastValue.ToString());
                //await Task.Delay(miliseconds);
            }
        }

        private void GenerateDataButtonChange()
        {
            if (IsDataGenerating)
            {
                IsDataGenerating = !IsDataGenerating;
                GenerateDataButton.Content = "Start Generating data for selected sensors";
                DataGenerationProgressBar.IsIndeterminate = false;
            }
            else
            {
                IsDataGenerating = !IsDataGenerating;
                GenerateDataButton.Content = "Stop Generating data for selected sensors";
                DataGenerationProgressBar.IsIndeterminate = true;
                //MessageBox.Show("Generating data");
            }
            
        }

        private async void CheckAPIConnectionButtonClick(object sender, RoutedEventArgs e)
        {
            var loadingProgressBar = new ProgressBar
            {
                IsIndeterminate = true,
                Visibility = Visibility.Visible
            };

            var messageBox = new TextBlock
            {
                Text = "Checking API connection...",
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };

            var stackPanel = new StackPanel
            {
                Orientation = Orientation.Vertical,
                Children = { loadingProgressBar, messageBox }
            };

            var messageBoxWindow = new Window
            {
                Content = stackPanel,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Topmost = true
            };

            messageBoxWindow.Show();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromMinutes(2);

                    var response = await httpClient.GetAsync("https://smartsensify.onrender.com/api/sensors/");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Connected to the API");
                    }
                    else
                    {
                        MessageBox.Show("API returned an error");
                    }
                }
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("API connection timed out");
            }
            finally
            {
                messageBoxWindow.Close();
            }
        }

        private void DeleteSensorClick(object sender, RoutedEventArgs e)
        {

        }

        private void EditDataClick(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
