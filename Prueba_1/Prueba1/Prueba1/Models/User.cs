using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba1.Models
{
    public class User : IEquatable<User>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }
        public bool Equals(User usr)
        {
            return (this.id == usr.id);
        }
        public override bool Equals(object obj) => Equals(obj as User);
        public override int GetHashCode() => (this.id).GetHashCode();
    }

    public class Address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
        public override string ToString()
        {
            return this.street + " " + this.suite + ", " + this.city + ". " + this.zipcode + this.geo;
        }
    }

    public class Geo
    {
        public string lat { get; set; }
        public string lng { get; set; }
        public override string ToString()
        {
            return "@[" + this.lat + "," + this.lng + "]";
        }
    }

    public class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
        public override string ToString()
        {
            return this.name;
        }
    }
}
