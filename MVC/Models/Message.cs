using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    /// <summary>
    /// http://sverigesradio.se/api/documentation/v2/metoder/trafik.html
    /// </summary>
    public class Message
    {

        public int Id { get; set; }             // Meddelandets unika id
        public int Priority { get; set; }       // Meddelandets prioritet(1 = Mycket allvarlig händelse, 2 = Stor händelse, 3 = Störning, 4 = Information, 5 = Mindre störning)
        public DateTime Createddate { get; set; }      // När meddelandet skapades
        public string Title { get; set; }              // Meddelandets rubrik/plats
        public string Exactlocation { get; set; }      // Detaljerad beskrivning av plats
        public string Description { get; set; }        // Beskrivande text för meddelandet
        public string Latitude { get; set; }            // Meddelandets position
        public string Longitude { get; set; }           // Meddelandets position { get; set; }
        public int Category { get; set; }              //Meddelandets kategori(0 = Vägtrafik, 1 = Kollektivtrafik, 2 = Planerad störning, 3 = Övrigt)
        public string Subcategory { get; set; }        // Meddelandets underkategori
    }
}
