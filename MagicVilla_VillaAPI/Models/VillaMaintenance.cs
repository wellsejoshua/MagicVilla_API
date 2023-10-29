using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Models
{
    public class VillaMaintenance
    {
        [Key]
        public int Id { get; set; }

        //address will come from this
        [ForeignKey("Complex")]
        public int PropertyId { get; set; }

        public string TenantName { get; set; }
        public string UnitNumber { get; set; }
        public string Phone { get; set; }
        public string Severity { get; set; }
        public string Description { get; set; }
        public string Room { get; set; }
        public DateTime Created { get; set; }
        public DateTime Completed { get; set; }

        public string RepairedBy { get; set; }
        public string Comments { get; set; }


    }
}
