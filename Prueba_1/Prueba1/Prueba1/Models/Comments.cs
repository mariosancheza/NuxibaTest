using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Prueba1.Models
{
    public class Comments
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        public static Collection<Comments> GetComments(int idPost)
        {
            Collection<Comments> comentarios;
            string strRequest = "https://jsonplaceholder.typicode.com/post/" + idPost + "/comments";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@strRequest);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                comentarios = JsonConvert.DeserializeObject<Collection<Comments>>(json);
            }
            return comentarios;
        }
    }

}
