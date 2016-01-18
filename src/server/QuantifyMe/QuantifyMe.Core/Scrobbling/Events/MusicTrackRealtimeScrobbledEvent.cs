using QuantifyMe.Core.Engine.EventRepository;

namespace QuantifyMe.Core.Scrobbling.Events
{
    public class MusicTrackRealtimeScrobbledEvent : IEvent
    {
        public string TrackName { get; set; }
        public string TrackId { get; set; }
        public string ArtistName { get; set; }
        public string ArtistId { get; set; }
        public string AlbumTitle { get; set; }
        public string AlbumId { get; set; }
        public System.DateTime Date { get; set; }
    }
}