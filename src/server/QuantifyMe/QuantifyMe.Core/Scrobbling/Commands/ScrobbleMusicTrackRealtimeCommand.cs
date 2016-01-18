using QuantifyMe.Core.Engine;

namespace QuantifyMe.Core.Scrobbling.Commands
{
    public class ScrobbleMusicTrackRealtimeCommand : ICommand
    {
        public string TrackName { get; set; }
        public string TrackId { get; set; }
        public string ArtistName { get; set; }
        public string ArtistId { get; set; }
        public string AlbumTitle { get; set; }
        public string AlbumId { get; set; }

        public void Execute() {
            throw new System.NotImplementedException();
        }
    }
}