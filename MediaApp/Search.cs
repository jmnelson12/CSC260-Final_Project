using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace MediaApp
{
    class Search
    {
        public string SearchTerm { get; set; }
        private const string _apiKey = "e7f452352c2360b97be05ea336f105f4";
        private string _searchURL = "https://api.themoviedb.org/3/search/movie?api_key=" + _apiKey;

        #region Constructors
        public Search()
        {
            this.SearchTerm = "";
        }

        public Search(string term)
        {
            this.SearchTerm = term;
        }
        #endregion

        #region Methods
        public object GetMovie()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(_searchURL);

                _searchURL += "&query=" + this.SearchTerm;

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetStringAsync(new Uri(_searchURL)).Result;
                var releases = JRaw.Parse(response);
                return releases;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        #endregion
    }
}
