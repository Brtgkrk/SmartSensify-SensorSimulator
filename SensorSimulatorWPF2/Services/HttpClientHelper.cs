using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public static class HttpClientHelper
{
    private static readonly HttpClient httpClient = new HttpClient();
    private static readonly string apiUrl = "https://smartsensify.onrender.com/api/sensors/data";

    public static async Task<bool> SendDataAsync(string json)
    {
        try
        {
            // Create a StringContent object with your JSON data
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send an HTTP POST request to the API
            HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

            // Check if the request was successful (HTTP status code 200)
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                // Handle unsuccessful response (e.g., log, throw exception)
                Console.WriteLine($"HTTP request failed with status code {response.StatusCode}");
                return false;
            }
        }
        catch (Exception ex)
        {
            // Handle exception (e.g., log, throw exception)
            Console.WriteLine($"Error sending HTTP request: {ex.Message}");
            return false;
        }
    }
}
