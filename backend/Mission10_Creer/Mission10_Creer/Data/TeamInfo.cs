using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Creer.Data
{
    public class TeamInfo
    {
        [Key] public int TeamId { get; set; }
        [Required] public string TeamName { get; set; }
    }
}