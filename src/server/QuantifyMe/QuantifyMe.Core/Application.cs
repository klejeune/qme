using Teclyn.Core.Engine;

namespace QuantifyMe.Core
{
    [Application]
    public class Application : IApplication
    {
        public string Name {
            get { return "Qme"; }
        }
    }
}