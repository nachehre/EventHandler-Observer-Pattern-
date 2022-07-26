using System;

namespace Test1
{
    public interface IEvent
    {
         Guid Id { get; }
         DateTime CreationDateTime { get;}
    }
}
