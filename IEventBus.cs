namespace Test1
{
    public interface IEventBus
    {
        void RegisterSubscriber<TEvent>(IEventHandler<TEvent> handler) where  TEvent:IEvent;
        void PubishEvent<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
