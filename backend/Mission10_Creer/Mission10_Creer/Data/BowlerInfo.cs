using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Creer.Data
{
    public class BowlerInfo
    {
        [Key]
        public int BowlerId { get; set; }
        [Required]
        public string BowlerLastName { get; set; }
        [Required]
        public string BowlerFirstName { get; set; }
        // Foreign Key to Teams table
        [Required]
        public int TeamId { get; set; }
        // Navigation property to reference the related Team
        [ForeignKey("TeamId")]
        public TeamInfo Team { get; set; }
        
        public string? BowlerMiddleInit { get; set; }
        [Required]
        public string BowlerAddress { get; set; }
        [Required]
        public string BowlerCity { get; set; }
        [Required]
        public string BowlerState { get; set; }
        [Required]
        public string BowlerZip { get; set; }
        [Required] public string BowlerPhoneNumber { get; set; }
    }    
}