using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class Api
    {
        

        public static async Task<string> GetAPIData(string Request, string optionalparam = "")
        {
            HttpClient httpClient = new HttpClient();
            const string ApiKey = "aa6958eb6d8d30e3ac6b1fd7c6711450";
            const string WebApi = "https://api.themoviedb.org/3/";
            return await httpClient.GetStringAsync(WebApi + Request + "?api_key=" + ApiKey+ optionalparam+ "&language=es");
        }


        public static async Task<string>  MoviesMethods (string param,string page="")
        {
            page = (page != "") ? "&page="+ page : page;
            return await GetAPIData("movie/" + param, page); 
        }

        public static async Task<string> SearchMethods (string query)
        {
            return await GetAPIData("search/movie","&query="+query);
        }
    }
}
