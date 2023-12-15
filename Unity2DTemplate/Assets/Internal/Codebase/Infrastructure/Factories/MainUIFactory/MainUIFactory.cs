using Internal.Codebase.Infrastructure.Services.ResourceProvider;
using Internal.Codebase.UI.MainUI.LoadingCurtain;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;

namespace Internal.Codebase.Infrastructure.Factories
{
    class MainUIFactory : IMainUIFactory
    {
        private GameObject currentPefab;
        private DiContainer container;
        private IResourceProvider resourceProvider;
        
        [Inject]
        private void Construct(DiContainer container, IResourceProvider resourceProvider)
        {
            this.resourceProvider = resourceProvider;
            this.container = container;
        }
        
        public Curtain CreateCurtain()
        {
            var config = resourceProvider.LoadCurtainConfig();

            var view = Object.Instantiate(config.Curtain);
            view.Constructor(config.AnimationDuration);

            return view;
        }
    }
}