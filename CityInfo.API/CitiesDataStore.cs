using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore() 
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "The one with the big park."
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Ohrid",
                    Description = "The one with the lake."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower."
                }
            };
        }
    }
}
