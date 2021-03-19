using MvvmCross.Plugin;
using MvvmCross.ViewModels;
using MvvmCrossMethodBindingError.ViewModels;

namespace MvvmCrossMethodBindingError
{
    public class Setup : MvxApplication
    {
        public Setup()
        {
                
        }

        public override void Initialize()
        {
            RegisterAppStart<MessageViewModel>();
        }

        public override void LoadPlugins(IMvxPluginManager pluginManager)
        {
            base.LoadPlugins(pluginManager);

            pluginManager.EnsurePluginLoaded<MvvmCross.Plugin.MethodBinding.Plugin>(true);
        }
    }
}
