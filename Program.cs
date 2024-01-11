using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    public static async Task Main(string[] args)
    {   
        using (HttpClient client = new HttpClient())
        {
            string url = "https://jsonplaceholder.typicode.com/todos/";
            
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }

        Console.ReadLine();
    }
}
