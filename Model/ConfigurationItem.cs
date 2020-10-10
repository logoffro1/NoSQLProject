using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConfigurationItem
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Owner { get; set; }

        public string Location { get; set; }

        public TicketPriorityType Importance { get; set; }

        public ConfigurationItem(string name, string description, int owner, string location, TicketPriorityType importance)
        {
            this.ID = GenerateConfigurationItemID();
            this.Name = name;
            this.Description = description;
            this.Owner = owner;
            this.Location = location;
            this.Importance = importance;
        }

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

        private string GenerateConfigurationItemID()
        {
            throw new NotImplementedException();
        }

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
