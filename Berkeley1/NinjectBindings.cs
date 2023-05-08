using Berkeley1.Service.Implementations;
using Berkeley1.Service.Interfaces;

namespace Berkeley1
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
#if DEBUG
            Bind<IStringService>().To<DebugStringService>();
#else
            Bind<IStringService>().To<StringService>();
#endif
        }
    }
}
