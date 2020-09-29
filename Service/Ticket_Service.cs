using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;
namespace Service
{
   public class Ticket_Service
    {
        public void AddTicket(Ticket ticket)
        {
            new Ticket_DAO().AddTicket(ticket);
        }
    }
}
