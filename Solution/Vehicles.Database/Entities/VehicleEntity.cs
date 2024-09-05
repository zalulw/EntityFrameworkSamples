using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicles.Database.Entities
{
    [Table("vehicle")]
    public class VehicleEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }

        [Required]
        [StringLength(7)]
        public string LicensePlate { get; set; }

        [Required]
        [StringLength(17)]
        public string ChassisNumber { get; set; }

        [Required]
        [StringLength(2)]
        public string EngineNumber { get; set; }

        [Required]
        [Range(3, 7)]
        public uint numOfDoors { get; set; }

        [Required]
        public uint Weight { get; set; }

        [Required]
        public uint Power { get; set; }
    }
}
