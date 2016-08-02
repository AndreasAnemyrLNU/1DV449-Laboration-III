using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Message> Messages { get; set; }

        public IEnumerable<string> subCategories = new string[]
        {
                "Buss",
                "Buööer",
                "Färja",
                "Hälsa och sjukvård",
                "Miljö",
                "Pollen",
                "Spårvagn",
                "Trafikstörning",
                "Tåg",
                "Vatten",
                "Väder",
                "Vägarbete"
        };
    }
}
