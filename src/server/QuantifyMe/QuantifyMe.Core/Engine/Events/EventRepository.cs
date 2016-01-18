namespace QuantifyMe.Core.Engine.Events
{
    public class EventRepository : IEventRepository
    {


        public void Store(Engine.EventRepository.IEvent @event) {
            throw new System.NotImplementedException();
        }

        public System.Linq.IQueryable<TEvent> Specialize<TEvent>() where TEvent : Engine.EventRepository.IEvent {
            throw new System.NotImplementedException();
        }
    }
}