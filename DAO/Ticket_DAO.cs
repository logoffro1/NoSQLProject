using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace DAO
{
   public class Ticket_DAO : Base
    {
        private string collectionName = "tickets";
        public void AddTicket(Ticket ticket)
        {
            CreateDocument(collectionName, CreateTicketDocument(ticket));
        }
        public List<Ticket> GetAllTickets()
        {
            List<BsonDocument> ticketsBson = ReadDocuments(collectionName);
            List<Ticket> tickets = new List<Ticket>();
            foreach(BsonDocument doc in ticketsBson)
            {
                Ticket ticket = new Ticket
                {
                    id = (int)doc["ticket_id"],
                    subject = (string)doc["subject"],
                    incidentDate = (DateTime)doc["date"],
                    type = (TicketIncidentType)Enum.Parse(typeof(TicketIncidentType), (string)doc["type"], true),
                    priority = (TicketPriorityType)Enum.Parse(typeof(TicketPriorityType), (string)doc["priority"], true),
                    description = (string)doc["description"],         
                    deadline = (TicketDeadline)Enum.Parse(typeof(TicketDeadline), (string)doc["deadline"], true)
                };
                ticket.isOpen = ticket.SetStatus((string)doc["status"]);
                tickets.Add(ticket);
            }
            return tickets;
        }
        private BsonDocument CreateTicketDocument(Ticket ticket)
        {
            return new BsonDocument
            {
                { "ticket_id", GetLatestId("tickets","ticket_id")},
                { "user_id", ticket.reportedByUser.id },
                {"date", ticket.incidentDate},
                {"subject", ticket.subject },
                {"status",ticket.GetStatus()},
                {"type",ticket.type.ToString() },
                {"priority",ticket.priority.ToString() },
                {"description",ticket.description },
                {"deadline",ticket.deadline.ToString() }
            };
        }
    }
}
