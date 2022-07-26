using System.Text;
using System.Threading.Tasks;
using System;
namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEventBus eventBus = new EventBus();
            eventBus.RegisterSubscriber(new CustomerCreatedEventHandler());

            Customer customer = new Customer(eventBus, 1, "nasim");

            Console.ReadLine();

        }
    }
}
