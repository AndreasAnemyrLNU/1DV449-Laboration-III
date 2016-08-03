using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            //Vägtrafik
            Categories.Add
            (new Category
            {
                Id = -1,
                Name = "Alla",
            }
            );

            //Vägtrafik
            Categories.Add
            (new Category
            {
                Id = 0,
                Name = "Vägtrafik",
            }
            );
            
            //Kollektivtrafik
            Categories.Add
            (new Category
            {
                Id = 1,
                Name = "Kollektivtrafik",
            }
            );

            //Planerad störning
            Categories.Add
            (new Category
            {
                Id = 2,
                Name = "Planerad störning",
            }
            );

            //Övrigt
            Categories.Add
            (new Category
            {
                Id = 3,
                Name = "Övrigt",
            }
            );

        }


        public IEnumerable<Message> Messages { get; set; }

        public int Cat { get;  set;}

        public List<Category> Categories = new List<Category>();

        public class Category
        {
            //http://sverigesradio.se/api/documentation/v2/metoder/trafik.html
            //String dependency to db and SR API!
            public int Id { get; set; }

            public string Name { get; set; }

            //public IEnumerable<string> Items {get; set;}
        }
    }
}
