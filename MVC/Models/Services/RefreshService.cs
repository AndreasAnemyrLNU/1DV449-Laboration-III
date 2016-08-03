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

        private const int minutesToCache = 15;

        public IEnumerable<Message> RefreshTrafficMessage(int cat)
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
                //TODO DRY DRY!!
                if (cat == -1)
                {
                    return _context.ReadMessages().ToList<Message>().OrderByDescending(m => m.Createddate);
                }
                else
                {
                    return _context.ReadMessages().ToList<Message>().Where(m => m.Category == cat).OrderByDescending(m => m.Createddate);
                }  
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

                //TODO DRY DRY!!
                if (cat == -1)
                {
                    return _context.ReadMessages().ToList<Message>().OrderByDescending(m => m.Createddate);
                }
                else
                {
                    return _context.ReadMessages().ToList<Message>().Where(m => m.Category == cat).OrderByDescending(m => m.Createddate);
                }
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

                    var message = _context.ReadMessages().ToList<Message>().OrderByDescending(m => m.Createddate).First();

                    if (message.CacheSaved.AddMinutes(minutesToCache) < DateTime.Now)
                    {
                        return false;
                    }

            return true;
        }
    }
}
