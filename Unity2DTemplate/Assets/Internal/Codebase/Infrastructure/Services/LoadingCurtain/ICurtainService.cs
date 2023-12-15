using System;

namespace Internal.Codebase.Infrastructure.Services.LoadingCurtain
{
    public interface ICurtainService
    {
        public void Init();
        
        public void ShowCurtain(bool isAnimated, Action callback = null);
        
        public void HideCurtain(float startDelay, Action callback = null);
    }
}