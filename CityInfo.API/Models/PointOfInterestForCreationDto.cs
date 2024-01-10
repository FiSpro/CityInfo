using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    /// <summary>
    /// A DTO for creating points of interest
    /// </summary>
    public class PointOfInterestForCreationDto
    {
        /// <summary>
        /// The name of the point of interest
        /// </summary>
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// The description of the point of interest
        /// </summary>
        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
