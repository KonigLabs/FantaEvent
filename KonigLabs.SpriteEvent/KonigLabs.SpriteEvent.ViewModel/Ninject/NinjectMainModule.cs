
using KonigLabs.SpriteEvent.CommonViewModel.Factories;
using KonigLabs.SpriteEvent.CommonViewModel.Messenger;
using KonigLabs.SpriteEvent.CommonViewModel.Navigator;
using KonigLabs.SpriteEvent.ViewModel.Factories;
using KonigLabs.SpriteEvent.ViewModel.ViewModels;
using Ninject;
using Ninject.Modules;
using System.Collections.Generic;

namespace KonigLabs.SpriteEvent.ViewModel.Ninject
{
    public class NinjectMainModule: NinjectModule
    {
        public override void Load()
        {

            Bind<IMessenger>().To<MvvmLightMessenger>().InSingletonScope();
            Bind<ViewModelStorage>().ToSelf().InSingletonScope();
            Bind<MainViewModel>().ToSelf();
            Bind<TakePhotoViewModelFactory>().ToSelf();
            Bind<WelcomViewModelFactory>().ToSelf();
            Bind<IViewModelNavigator>().To<ViewModelNavigator>().WithConstructorArgument(typeof(IChildrenViewModelsFactory),
                    x =>
                    {
                        var children = new List<IViewModelFactory>
                        {
                            x.Kernel.Get<WelcomViewModelFactory>()
                        };

                        return new ChildrenViewModelsFactory(children);
                    });
            Bind<IViewModelNavigator>().To<ViewModelNavigator>().WhenInjectedExactlyInto<MainViewModel>().WithConstructorArgument(typeof(IChildrenViewModelsFactory), x =>
            {
                var children = new List<IViewModelFactory>
                {
                    x.Kernel.Get<WelcomViewModelFactory>(),
                    
                };

                return new ChildrenViewModelsFactory(children);
            });
        }
    }
}
