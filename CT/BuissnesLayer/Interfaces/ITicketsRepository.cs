using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface ITicketsRepository
    {
        public IEnumerable<Ticket> GetAllTicketsByIdConcert(int concertId);
        public Ticket GetTicketById(int ticketId);
        public void DeleteAllTickets(Concert concert);
        public void DeleteTicket(Ticket ticket, Concert concert);
        public void SaveTicket(Ticket ticket, Concert concert);

    }
}
