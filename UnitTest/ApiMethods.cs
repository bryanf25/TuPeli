using Microsoft.VisualStudio.TestTools.UnitTesting;
using BussinesLayer;
using System.Threading.Tasks;
using EntityLayer;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class ApiMethods
    {
        [TestMethod]
        public async Task CheckMovieNameById()
        {
            Movie result = await SearchCriteria.GetMovieDetails("385687");
            Assert.AreEqual("Fast & Furious 10",result.title);

        }

        [TestMethod]
        public  async Task Check20LastMovies()
        {
            MovieListStructure result =  await SearchCriteria.GetlastMovies();
            Assert.AreEqual(20, result.results.Count);
        }

        [TestMethod]
        public async Task CheckParticularLastMovie()
        {
            int count = 0;
            MovieListStructure result = await SearchCriteria.GetlastMovies();
            foreach (Movie item in result.results)
            {
                if (item.title.Contains("Space Jam"))
                {
                    count++;
                }
            }
            Assert.IsTrue(count >= 1);
        }

        [TestMethod]
        public async Task CheckOver8TopRated()
        {
            MovieListStructure result = await SearchCriteria.GetTopRated();
            foreach (Movie item in result.results)
            {
                Assert.IsTrue(item.vote_average > 8);
            }  
        }

        [TestMethod]
        public async Task ChekOver1000Popularity()
        {
            MovieListStructure result = await SearchCriteria.GetPopular();
            foreach (Movie item in result.results)
            {
                Assert.IsTrue(item.popularity > 1000);
            }
        }

        [TestMethod]
        public async Task CheckSearchMovieWorkIt()
        {
            MovieListStructure result = await SearchCriteria.GetMoviesByName("king");
            Assert.IsTrue(result.total_results > 1);
        }


    }
}
