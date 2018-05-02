using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MediaApp
{
    class Search
    {
        public string searchTerm { get; set; }
        private const string _APIKEY = "e7f452352c2360b97be05ea336f105f4";
        private const string _SEARCHURL = "https://api.themoviedb.org/3/search/movie?api_key=" + _APIKEY;
        static HttpClient client = new HttpClient();            

        public int total_results { get; set; }
        public List<object> results;

        #region constructors
        public Search(string term)
        {
            this.searchTerm = term;
            RunAsync(term).GetAwaiter().GetResult();
        }
        #endregion

        #region Methods

        // Run Task
        public async Task RunAsync(string searchTerm)
        {
            //client.BaseAddress = new Uri("https://api.themoviedb.org/3/search/movie?api_key=");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // get the products
                Product product = await GetProductAsync(_SEARCHURL + "&query=" + searchTerm);        
                SetMovie(product);
                product = null;
                searchTerm = null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Call to Api
        static async Task<Product> GetProductAsync(string path)
        {
            Product product = null;
            HttpResponseMessage response = client.GetAsync(path).Result;

            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }
            return product;
        }

        // Set Values
        public void SetMovie(Product product)
        {
            this.total_results = product.Total_Results;
            this.results = product.Results;
        }
     
        #endregion
    }
}
