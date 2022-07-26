using System;
using System.Collections.Generic;
using System.Linq;

namespace Test1
{
    public class EventBus : IEventBus
    {
        Dictionary<Type, List<object>> _dic = new Dictionary<Type,List<object>>();
        public void PubishEvent<TEvent>(TEvent @event) where TEvent : IEvent
        {
          var handlers=  _dic[typeof(TEvent)];
            foreach (var item in handlers)
            {
                var handler = item as IEventHandler<TEvent>;
                handler.Handle(@event);
            }
        }

        public void RegisterSubscriber<TEvent>(IEventHandler<TEvent> handler) where TEvent : IEvent
        {
            if (_dic.Keys.Any(key => key == (typeof(TEvent))))
            {
                var type = _dic.Keys.First(key => key == (typeof(TEvent)));
                _dic[type].Add(handler);
            }
            else
            {
                _dic.Add(typeof(TEvent), new List<object>() { handler });
            }

        }
    }
}
