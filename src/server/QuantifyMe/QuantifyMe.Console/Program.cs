using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Himmelsk.LastFmApi;

namespace QuantifyMe.Console {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("Main start");
            Task t = MainAsync(args);
            t.ContinueWith((str) => {
                System.Console.WriteLine(str.Status.ToString());
                System.Console.WriteLine("Main end");
            });
            t.Wait();
        }

        static async Task MainAsync(string[] args) {
            var lastfm = new LastFm();

            var appCred = await lastfm.GetAppCredentials("41d2857014512c704ff34a2689125da3", "763e01c374cfe35ef58589c76ba223b7");
            //var cred = await lastfm.GetMobileSessionCredentials("himmelsk", "tit3ch@!", "41d2857014512c704ff34a2689125da3", "763e01c374cfe35ef58589c76ba223b7");

            var last = await lastfm.User.GetRecentTracks(appCred, "himmelsk", null, null, null, 200);

            foreach (var track in last.Typed.RecentTracks.Track) {
                System.Console.WriteLine(track.ToString());
            }


            //var importer = new LastFmImporter();

            //importer.Import();
        }
    }
}
