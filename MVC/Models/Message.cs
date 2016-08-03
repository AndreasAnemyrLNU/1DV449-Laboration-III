using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Prioritet")]
        public int Priority { get; set; }       // Meddelandets prioritet(1 = Mycket allvarlig händelse, 2 = Stor händelse, 3 = Störning, 4 = Information, 5 = Mindre störning)
        [DisplayName("Skapades")]
        public DateTime Createddate { get; set; }      // När meddelandet skapades
        [DisplayName("Titel")]
        public string Title { get; set; }              // Meddelandets rubrik/plats
        public string Exactlocation { get; set; }      // Detaljerad beskrivning av plats
        [DisplayName("Beskrivning")]
        public string Description { get; set; }        // Beskrivande text för meddelandet
        [DisplayName("Latitud")]
        public string Latitude { get; set; }            // Meddelandets position
        [DisplayName("Longitud")]
        public string Longitude { get; set; }           // Meddelandets position { get; set; }
        [DisplayName("Kategori")]
        public int Category { get; set; }              //Meddelandets kategori(0 = Vägtrafik, 1 = Kollektivtrafik, 2 = Planerad störning, 3 = Övrigt)
        [DisplayName("Underkategori")]
        public string Subcategory { get; set; }        // Meddelandets underkategori
        public DateTime CacheSaved { get; set; }
    }
}
