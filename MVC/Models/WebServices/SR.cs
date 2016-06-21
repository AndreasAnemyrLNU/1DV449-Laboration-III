using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC.Models.WebServices
{
    class SR
    {
            private readonly string mode = "xml";

            public IEnumerable<Message> GetMessages()
            {

                //Switch to lon & lat!
                var uri = $"http://api.sr.se/api/v2/traffic/messages";

                string rawXML = string.Empty;

                // Create a request using a URL that can receive a post. 
                WebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                // Set the Method property of the request to GET.
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    rawXML = reader.ReadToEnd();
                }

                XDocument xml = XDocument.Parse(rawXML);

                IEnumerable<XElement> messages =
                from message in xml.Descendants("sr").Elements("messages").Elements("message")
                select message;

                
                return

                        (from message in messages
                         select new Message
                         {
                             Id             = int.Parse(message.Attribute("id").Value),
                             Priority       = int.Parse(message.Attribute("priority").Value),
                             Createddate    = DateTime.Parse(message.Element("createddate").Value),
                             Title          = message.Element("title").Value.ToString(),
                             Exactlocation  = message.Element("exactlocation").Value.ToString(),
                             Description    = message.Element("description").Value.ToString(),
                             Latitude       = float.Parse(message.Element("latitude").Value),
                             Longitude      = float.Parse(message.Element("longitude").Value),
                             Category       = int.Parse(message.Attribute("category").Value),
                             Subcategory    = message.Element("subcategory").Value
                         }).ToList<Message>();
                
                }
        
    }
}
