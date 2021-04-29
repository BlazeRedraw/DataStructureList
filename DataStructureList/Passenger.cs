namespace DataStructureList
{
    public class Passenger
    {
        private string name;
        private string id;
        private string ticketId;

        public Passenger()
        {
        }

        public bool IsFound(string search)
        {
            return search.Equals(name) || search.Equals(id) || search.Equals(ticketId);
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Ticket { get => ticketId; set => ticketId = value; }

    }
}
