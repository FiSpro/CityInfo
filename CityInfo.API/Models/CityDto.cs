namespace CityInfo.API.Models
{
    /// <summary>
    /// A DTO for a city
    /// </summary>
    public class CityDto
    {
        /// <summary>
        /// The id of the city
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the city
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The Description of the city
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The total number of points of interest for the city
        /// </summary>
        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }

        /// <summary>
        /// Collection of the points of interest for the city
        /// </summary>
        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; }
            = new List<PointOfInterestDto>();
    }
}
