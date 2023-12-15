using System;

namespace Internal.Codebase.Infrastructure.Services.SceneLoader
{
    public interface ISceneLoaderService
    {
        public void LoadScene(string sceneName, Action onLoadedScene = null);

        public string GetCurrentSceneName();
    }
}