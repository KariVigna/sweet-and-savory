using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SweetAndSavory.Models
{
    public class Treat
    {
        public int TreatId { get; set; }
        [Required(ErrorMessage = "The treats's name can't be empty!")]
        public string Name { get; set; }
        public List<FlavorTreat> JoinEntities { get;}
    }
}