using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Movie
    {
        public bool adult { get;set;}
        public int id { get; set; }
        public string title { get; set; }
        public string original_title { get; set; }
        public string poster_path { get; set; }
        public string backdrop_path { get; set; }
        public string release_date { get; set; }
        public string overview { get; set; }
        public float popularity { get; set; }
        public float vote_average { get; set; }
        public float vote_count { get; set; }
    }
}
