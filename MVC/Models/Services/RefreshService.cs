using MVC.Models.WebServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Models.DAL;
using System.Data.Entity;

namespace MVC.Models.Services
{
    class TrafficMessageService
    {
        public _1dv449_aa223ig_Mashup _context = new _1dv449_aa223ig_Mashup();

        public IEnumerable<Message> RefreshTrafficMessage()
        {
            SR sr = new SR();
   
            /*
            foreach(var message in sr.GetMessages())
            {
                _context.CreateMessage(message);
            }

            _context.SaveChanges();
            */
            return _context.ReadMessages().ToList<Message>().OrderByDescending(m => m.Createddate).Take(100);
        }
    }
}
