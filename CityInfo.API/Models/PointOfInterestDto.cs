namespace CityInfo.API.Models
{
    /// <summary>
    /// A DTO for the points of interest
    /// </summary>
    public class PointOfInterestDto
    {
        /// <summary>
        /// The id of the point of interest
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the point of interest
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The description of the point of interest
        /// </summary>
        public string? Description { get; set; }
    }
}
