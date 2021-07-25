using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MMT.Shop.Client
{
    class Program
    {
        private const string BaseUrl = "http://localhost:5000/";
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.WriteLine("Testing available endpoints");
            var categories = await MakeHttpCall("v1/category");
            Console.WriteLine("Categories");
            Console.WriteLine(categories);

            var featuredProducts = await MakeHttpCall("v1/product/featured");
            Console.WriteLine("Featured Products");
            Console.WriteLine(featuredProducts);

            var categoryProducts = await MakeHttpCall("v1/category/1/products");
            Console.WriteLine("Product for category 1");
            Console.WriteLine(categoryProducts);

            Console.ReadLine();
        }

        private static async Task<string> MakeHttpCall(string resource)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            return await client.GetStringAsync($"{BaseUrl}{resource}");
        }
    }
}
