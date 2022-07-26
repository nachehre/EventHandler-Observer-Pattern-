using System;

namespace Test1
{
    public class CustomerCreated : IEvent
    {
        public Guid Id { get ;private set; }
        public DateTime CreationDateTime { get ; private set ; }
        public int CustomerId { get; set; }
        public CustomerCreated(int  customerId)
        {
            CustomerId = customerId;
            Id = Guid.NewGuid();
            CreationDateTime = DateTime.Now;
        }
    }
}
