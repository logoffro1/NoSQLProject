using System;

namespace Model
{
    public class Ticket
    {
        public int Id { get; set; }
        public User ReportedByUser { get; set; }
        public DateTime IncidentDate { get; set; }
        public string Subject { get; set; }
        public TicketIncidentType Type { get; set; }
        public TicketPriorityType Priority { get; set; }
        public string Description { get; set; }
        public TicketDeadline Deadline { get; set; }
        public bool IsOpen { get; set; }

        public string GetStatus()
        {
            if (IsOpen) return "Open";

            return "Closed";
        }
        public bool SetStatus(string status)
        {
            if (status.Equals("Open")) return true;

            return false;
        }

    }
}
