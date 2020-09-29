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
            CreateDocument(collectionName, createTicketDocument(ticket));
        }
        private BsonDocument createTicketDocument(Ticket ticket)
        {
            return new BsonDocument
            {
                { "ticket_id", GetLatestId("tickets","ticket_id")},
                { "user_id", ticket.reportedByUser.id },
                {"date", ticket.incidentDate},
                {"subject", ticket.subject },
                {"type",ticket.type.ToString() },
                {"priority",ticket.priority.ToString() },
                {"description",ticket.description },
                {"deadline",ticket.deadline.ToString() }
            };
        }
    }
}
