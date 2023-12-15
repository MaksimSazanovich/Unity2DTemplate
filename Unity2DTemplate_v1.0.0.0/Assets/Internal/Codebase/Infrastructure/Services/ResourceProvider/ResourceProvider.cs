using Internal.Codebase.Infrastructure.Constants;
using Internal.Codebase.UI.MainUI.LoadingCurtain;
using UnityEngine;

namespace Internal.Codebase.Infrastructure.Services.ResourceProvider
{
    public sealed class ResourceProvider : IResourceProvider
    {
        public CurtainConfig LoadCurtainConfig()
        {
            return Resources.Load<CurtainConfig>(AssetPath.CurtainConfig);
        }
        
    }
}