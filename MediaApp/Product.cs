using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApp
{
    public class Product
    {
        public string Id { get; set; }
        public string Original_Title { get; set; }
        public string Poster_Path { get; set; }
        public int Total_Results { get; set; }
        public object Results { get; set; }
    }
}
