using System.Linq;
using QuantifyMe.Core.Engine.EventRepository;

namespace QuantifyMe.Core.Engine.Events
{
    public interface IEventRepository
    {
        void Store(IEvent @event);
        IQueryable<TEvent> Specialize<TEvent>() where TEvent : IEvent;
    }
}