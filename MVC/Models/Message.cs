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
    class Message
    {
        [Key]
        public int Id { get; set; }             // Meddelandets unika id
        public int Priority { get; set; }       // Meddelandets prioritet(1 = Mycket allvarlig händelse, 2 = Stor händelse, 3 = Störning, 4 = Information, 5 = Mindre störning)
        DateTime Createddate { get; set; }      // När meddelandet skapades
        string Title { get; set; }              // Meddelandets rubrik/plats
        string Exactlocation { get; set; }      // Detaljerad beskrivning av plats
        string Description { get; set; }        // Beskrivande text för meddelandet
        float Latitude { get; set; }            // Meddelandets position
        float Longitude { get; set; }           // Meddelandets position { get; set; }
        int Category { get; set; }              //Meddelandets kategori(0 = Vägtrafik, 1 = Kollektivtrafik, 2 = Planerad störning, 3 = Övrigt)
        string Subcategory { get; set; }        // Meddelandets underkategori
    }
}
