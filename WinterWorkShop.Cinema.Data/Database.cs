using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Domain.Common
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel>
        {
            new MovieModel { Id = 1, Name = "Spuderman" },
            new MovieModel { Id = 2, Name = "Spuderman 2"}
        };
        public List<ProjectionsModel> GetAllProjectionsResponses = new List<ProjectionsModel>
        {
            new ProjectionsModel { Id = 1, brojSale = 3 , Date = new DateTime(2023, 3, 7, 8, 0, 00) },
            new ProjectionsModel { Id = 2, brojSale = 4 , Date = new DateTime(2023, 3, 7, 10, 0, 00)}
        };
    }
}
