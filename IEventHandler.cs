namespace Test1
{
    public interface IEventHandler<TEvent> where TEvent:IEvent
    {
        void Handle(TEvent @event);
    }
}
