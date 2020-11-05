using Model;
using System;
using System.Collections.Generic;
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
            List<BsonDocument> ticketsBson = ReadDocuments(this.collectionName);
            List<Ticket> tickets = new List<Ticket>();
            foreach (var doc in ticketsBson)
            {
                Ticket ticket = new Ticket
                {
                    Id = (int)doc["ticket_id"],
                    ReportedByUser = new User_DAO().GetUserById((int)doc["user_id"]),
                    Subject = (string)doc["subject"],
                    IncidentDate = (DateTime)doc["date"],
                    Type = (TicketIncidentType)Enum.Parse(typeof(TicketIncidentType), (string)doc["type"], true),
                    Priority = (TicketPriorityType)Enum.Parse(typeof(TicketPriorityType), (string)doc["priority"], true),
                    Description = (string)doc["description"],
                    Deadline = (DateTime)(doc["deadline"])
                };
                ticket.IsOpen = ticket.SetStatus((string)doc["status"]);
                tickets.Add(ticket);
            }
            return tickets;
        }
        public void UpdateTicket(Ticket newTicket)
        {
            UpdateDocument(collectionName, "ticket_id", newTicket.Id, "status", newTicket.GetStatus());
        }

        //Updates the id of the user who entered the incident.
        public void UpdateTicketUser(Ticket newTicket)
        {
            UpdateDocument(collectionName, "ticket_id", newTicket.Id, "user_id", newTicket.ReportedByUser.id);
        }

        private BsonDocument CreateTicketDocument(Ticket ticket)
        {
            return new BsonDocument
            {
                {"ticket_id", GetLatestId(this.collectionName,"ticket_id")},
                {"user_id", ticket.ReportedByUser.id },
                {"date", ticket.IncidentDate},
                {"subject", ticket.Subject },
                {"status",ticket.GetStatus()},
                {"type",ticket.Type.ToString() },
                {"priority",ticket.Priority.ToString() },
                {"description",ticket.Description },
                {"deadline",ticket.Deadline}
            };
        }

        public List<Ticket> GetAllArchivedTickets()
        {
            List<BsonDocument> ticketsBson = ReadDocumentsArchive(this.collectionName);
            List<Ticket> tickets = new List<Ticket>();
            foreach (var doc in ticketsBson)
            {
                Ticket ticket = new Ticket
                {
                    Id = (int)doc["ticket_id"],
                    ReportedByUser = new User_DAO().GetUserById((int)doc["user_id"]),
                    Subject = (string)doc["subject"],
                    IncidentDate = (DateTime)doc["date"],
                    Type = (TicketIncidentType)Enum.Parse(typeof(TicketIncidentType), (string)doc["type"], true),
                    Priority = (TicketPriorityType)Enum.Parse(typeof(TicketPriorityType), (string)doc["priority"], true),
                    Description = (string)doc["description"],
                    Deadline = (DateTime)(doc["deadline"])
                };
                ticket.IsOpen = ticket.SetStatus((string)doc["status"]);
                tickets.Add(ticket);
            }
            return tickets;
        }
    }
}
