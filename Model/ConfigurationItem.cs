using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConfigurationItem
    {
        public string ID { get; private set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Owner { get; private set; } // Should be a User?

        public string Location { get; set; }

        public TicketPriorityType Importance { get; set; }

        public ConfigurationItem(string name, string description, int owner, string location, TicketPriorityType importance) : this(
            Guid.NewGuid().ToString(),
            name,
            description,
            owner,
            location,
            importance)
        { }

        public ConfigurationItem(string name, int owner, string location, TicketPriorityType importance) : this(
            Guid.NewGuid().ToString(),
            name,
            "No Description Available",
            owner,
            location,
            importance)
        { }

        // No Description or Priority
        public ConfigurationItem(string name, int owner, string location) : this( 
        Guid.NewGuid().ToString(),
        name,
        "No Description Available",
        owner,
        location,
        TicketPriorityType.Low)
        { }

        public ConfigurationItem(string id, string name, string description, int owner, string location, TicketPriorityType importance)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Owner = owner;
            this.Location = location;
            this.Importance = importance;
        }

        /*public ConfigutationItem(string name) : this(name, "No Description", -1 , TicketPriorityType.Low) { }
        public ConfigutationItem(string name, string description) : this(name, description, -1 , TicketPriorityType.Low) { }
        public ConfigutationItem(string name, string description, int owner) : this(name, description, owner , TicketPriorityType.Low) { }*/

        public override String ToString()
        {
            return String.Format($"ID: {ID}\n" +
                $"Name: {Name}\n" +
                $"Description: {Description}\n" +
                $"Owner: {Owner}\n" +
                $"Location: {Location}\n" +
                $"Importance: {Importance}\n");
        }
    }
}
