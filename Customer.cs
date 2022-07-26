namespace Test1
{
    public class Customer
    {
        private readonly IEventBus _eventBus;
        public Customer(IEventBus eventBus, int id, string name)
        {
            this.Id = id;
            Name = name;
            _eventBus = eventBus;

            var customerCreatedEvent = new CustomerCreated(Id);
            _eventBus.PubishEvent(customerCreatedEvent);
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
