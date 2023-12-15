using Internal.Codebase.Infrastructure.Constants;
using Internal.Codebase.Infrastructure.Services.LoadingCurtain;
using Internal.Codebase.Infrastructure.Services.SceneLoader;
using Internal.Codebase.UI.MainUI.LoadingCurtain;
using UnityEngine;
using Zenject;

namespace Internal.Codebase.Infrastructure.GameBootstrapper
{
    public class GameBootstrapper : MonoBehaviour
    {
        private ISceneLoaderService loaderService;
        private ICurtainService curtainService;
        private CurtainConfig curtainConfig;

        [Inject]
        private void Constructor(ISceneLoaderService loaderService, ICurtainService curtainService,
            CurtainConfig curtainConfig)
        {
            this.curtainConfig = curtainConfig;
            this.curtainService = curtainService;
            this.loaderService = loaderService;
        }
        private void Start()
        {
            Load();
        }

        private void Load()
        {
            curtainService.Init();
            curtainService.ShowCurtain(true, HideCurtain); 
        }

        private void HideCurtain()
        {
            curtainService.HideCurtain(curtainConfig.HideDelay);
            loaderService.LoadScene(SceneName.MenuScene/*TODO if WebJL InitGRA*/);
        }
    }
}
