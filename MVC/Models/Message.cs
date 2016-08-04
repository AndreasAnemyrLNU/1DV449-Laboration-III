using Newtonsoft.Json;
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
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }             // Meddelandets unika id

        [JsonProperty(PropertyName = "priority")]
        [DisplayName("Prioritet")]
        public int Priority { get; set; }       // Meddelandets prioritet(1 = Mycket allvarlig händelse, 2 = Stor händelse, 3 = Störning, 4 = Information, 5 = Mindre störning)

        [JsonProperty(PropertyName = "createddate")]
        [DisplayName("Skapades")]
        public DateTime Createddate { get; set; }      // När meddelandet skapades

        [JsonProperty(PropertyName = "title")]
        [DisplayName("Titel")]
        public string Title { get; set; }              // Meddelandets rubrik/plats

        [JsonProperty(PropertyName = "exactlocation")]
        public string Exactlocation { get; set; }      // Detaljerad beskrivning av plats

        [JsonProperty(PropertyName = "description")]
        [DisplayName("Beskrivning")]
        public string Description { get; set; }        // Beskrivande text för meddelandet

        [JsonProperty(PropertyName = "latitude")]
        [DisplayName("Latitud")]
        public string Latitude { get; set; }            // Meddelandets position

        [JsonProperty(PropertyName = "longitude")]
        [DisplayName("Longitud")]
        public string Longitude { get; set; }           // Meddelandets position { get; set; }

        [JsonProperty(PropertyName = "category")]
        [DisplayName("Kategori")]
        public int Category { get; set; }              //Meddelandets kategori(0 = Vägtrafik, 1 = Kollektivtrafik, 2 = Planerad störning, 3 = Övrigt)

        [JsonProperty(PropertyName = "subcategory")]
        [DisplayName("Underkategori")]
        public string Subcategory { get; set; }        // Meddelandets underkategori


        public DateTime CacheSaved { get; set; }
    }
}
