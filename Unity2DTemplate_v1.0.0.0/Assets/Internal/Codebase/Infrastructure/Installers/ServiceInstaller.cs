using Internal.Codebase.Infrastructure.Services.CoroutineRunner;
using Internal.Codebase.Infrastructure.Services.LoadingCurtain;
using Internal.Codebase.Infrastructure.Services.ResourceProvider;
using Internal.Codebase.Infrastructure.Services.SceneLoader;
using UnityEngine;
using Zenject;
using ResourceProvider = Internal.Codebase.Infrastructure.Services.ResourceProvider.ResourceProvider;


namespace Internal.Codebase.Infrastructure.Installers
{
    [DisallowMultipleComponent]
    public sealed class ServiceInstaller : MonoInstaller, ICoroutineRunner
    {
        public override void InstallBindings()
        {
            Container.Bind<ICoroutineRunner>().FromInstance(this).AsSingle().NonLazy();
            Container.Bind<ISceneLoaderService>().To<SceneLoaderService>().AsSingle().NonLazy();
            Container.Bind<IResourceProvider>().To<ResourceProvider>().AsSingle().NonLazy();
            
            Container.Bind<ICurtainService>().To<CurtainService>().AsSingle().NonLazy();
        }
    }
}