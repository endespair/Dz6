using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz6
{
    internal class InJson
    {
        //[JsonIgnore]
        public int PublishingHouseId { get; set; }
        //[JsonPropertyName("Name")]
        public string? Title { get; set; }
        public PublishingHouse? PublishingHouse { get; set; }
    }
}
