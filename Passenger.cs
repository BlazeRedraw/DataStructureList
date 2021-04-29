using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureList
{
    internal class Passenger
    {
        private string name;
        private string id;
        private string ticketId;

        public void Program()
        {

        }

        public bool IsFound(string search)
        {
            return search.Equals(name) || search.Equals(id) || search.Equals(ticketId);
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string TicketId { get => ticketId; set => ticketId = value; }
    }
}
