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

            if (!PreviousMessageExists())
            {
                foreach (var message in sr.GetMessages())
                {
                    _context.CreateMessage(message);
                }
            }

            if (UseCachedMessages())
            {
                return _context.ReadMessages().ToList<Message>().OrderByDescending(m => m.Createddate).Take(10);
            }
            else
            {
                //Delete old messages
                foreach (var message in _context.Messages)
                {
                    _context.DeleteMessage(message);
                }

                _context.SaveChanges();

                //Cache new messages
                foreach (var message in sr.GetMessages())
                {
                    _context.CreateMessage(message);
                }

                _context.SaveChanges();

                return _context.ReadMessages().ToList<Message>().OrderByDescending(m => m.Createddate).Take(10);
            }

        }

        /// <summary>
        /// Check if there is existing messages in db.
        /// </summary>
        /// <returns></returns>
        private bool PreviousMessageExists()
        {

            IEnumerable<Message> messages = _context.ReadMessages().ToList<Message>().OrderByDescending(m => m.Createddate).Take<Message>(1);

            if(messages.SingleOrDefault() != null)
            {
                return true;
            }

            return false;
        }

        private bool UseCachedMessages()
        {
            if (PreviousMessageExists())
            {
                try
                {
                    var message = _context.ReadMessages().ToList<Message>().OrderByDescending(m => m.Createddate).First();

                    if (message.CacheSaved.AddMinutes(1) < DateTime.Now)
                    {
                        return true;
                    }
                }
                catch
                {
                    //Empty
                }


            }
            return false;
        }
    }
}
