using Internal.Codebase.Infrastructure.Factories;
using UnityEngine;
using Zenject;

namespace Internal.Codebase.Infrastructure.Installers
{
    [DisallowMultipleComponent]
    public sealed class FactoryInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IMainUIFactory>().To<MainUIFactory>().AsSingle().NonLazy();
        }
    }
}