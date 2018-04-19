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
        public string searchterm { get; set; }
        private const string _apikey = "e7f452352c2360b97be05ea336f105f4";
        private const string _searchurl = "https://api.themoviedb.org/3/search/movie?api_key=" + _apikey;
        static HttpClient client = new HttpClient();

        public int total_results { get; set; }
        public List<object> results;

        #region constructors
        public Search()
        {
            this.searchterm = "";
            RunAsync("").GetAwaiter().GetResult();
        }

        public Search(string term)
        {
            this.searchterm = term;
            RunAsync(term).GetAwaiter().GetResult();
        }
        #endregion

        #region Methods
        public async Task RunAsync(string searchTerm)
        {
            client.BaseAddress = new Uri("https://api.themoviedb.org/3/search/movie?api_key=");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // get the products
                Product product = await GetProductAsync(_searchurl + "&query=" + searchterm);
              
                GetMovie(product);
            }
            catch (Exception e)
            {
                // Add Error Box
            }
        }

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

        public void GetMovie(Product product)
        {
            this.total_results = product.Total_Results;
            this.results = product.Results;
        }
        #endregion
    }
}
