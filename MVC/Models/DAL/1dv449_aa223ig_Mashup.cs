namespace MVC.Models.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;
    public partial class _1dv449_aa223ig_Mashup : DbContext
    {
        public _1dv449_aa223ig_Mashup()
            : base("name=MashupAtFalken")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Message> Messages {get; set;}


        //CRUD Messages!
        public void CreateMessage(Message message)
        {
            Messages.Add(message);
        } 

        public IEnumerable<Message> ReadMessages()
        {
            return Messages.ToList<Message>();
        }

        public Message ReadMessageById(int id)
        {
            return Messages.Find(id);
        }

        public void UpdateMessage(Message message)
        {
            Messages.Attach(message);
        }

        public void DeleteMessage(Message message)
        {
            Messages.Remove(;
        }

        public void Save()
        {
            base.SaveChanges();
        }

    }
}
