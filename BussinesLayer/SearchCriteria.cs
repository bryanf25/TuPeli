using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using EntityLayer;
using Newtonsoft.Json;

namespace BussinesLayer
{
    public class SearchCriteria
    {
        public static async Task<dynamic> GetlastMovies(string page="")
        {
            try
            {
                string LastMovies = await Api.MoviesMethods("now_playing", page);
                MovieListStructure Movies = JsonConvert.DeserializeObject<MovieListStructure>(LastMovies);
                return Movies;
            }catch(Exception ex)
            {
                return ex;
            } 
        }

        public static async Task<dynamic> GetTopRated(string page = "")
        {
            try
            {
            string TopMovies = await Api.MoviesMethods("top_rated", page);
            MovieListStructure Movies = JsonConvert.DeserializeObject<MovieListStructure>(TopMovies);
            return Movies;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static async Task<dynamic> GetPopular(string page = "")
        {
            try
            {
                string PopularMovies = await Api.MoviesMethods("popular", page);
                MovieListStructure Movies = JsonConvert.DeserializeObject<MovieListStructure>(PopularMovies);
                return Movies;
            }
            catch (Exception ex)
            {
                return ex;
            }

        }

        public static async Task<dynamic> GetMoviesByName(string MovieName)
        {
            try
            {
                string MoviesSearched = await Api.SearchMethods(MovieName);
                MovieListStructure Movies = JsonConvert.DeserializeObject<MovieListStructure>(MoviesSearched);
                return Movies;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static async Task<Movie> GetMovieDetails(string IdNumber)
        {
            string MovieInfo = await Api.MoviesMethods(IdNumber);
            Movie MovieDetails = JsonConvert.DeserializeObject<Movie>(MovieInfo);
            return MovieDetails;
        }

    }
}
