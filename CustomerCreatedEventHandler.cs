namespace Test1
{
    public class CustomerCreatedEventHandler : IEventHandler<CustomerCreated>
    {
        public void Handle(CustomerCreated @event)
        {
            System.Console.WriteLine($"Customer with id:{@event.CustomerId} was created");
        }
    }
}
