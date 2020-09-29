using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public int id { get; set; }
        public User reportedByUser { get; set; }
        public DateTime incidentDate { get; set; }
        public string subject { get; set; }
        public TicketIncidentType type { get; set; }
        public TicketPriorityType priority { get; set; }
        public string description { get; set; }
        public TicketDeadline deadline { get; set; }

    }
}
