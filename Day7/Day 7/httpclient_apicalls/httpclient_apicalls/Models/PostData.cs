using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace httpclient_apicalls.Models
{
    public class PostData
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        List<PostData> data = new List<PostData>();

        public List<PostData> GetPostDetails()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var apicall = client.GetAsync(url);

            if (apicall.Result.IsSuccessStatusCode)
            {
                var calldata = apicall.Result.Content.ReadAsAsync<List<PostData>>();
                calldata.Wait();
                data = calldata.Result;
                return data;
            }
            else
            {
                throw new Exception("Could not get data, please conact Admin");
            }





        }
    }
}
