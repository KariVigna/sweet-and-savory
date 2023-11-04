using System.Collections.Generic;

namespace SweetAndSavory.Models
{
    public class Flavor
    {
        public int FlavorId { get; set; }
        public string Name { get; set; }
        public List<FlavorTreat> JoinEntities { get;}
    }
}