using Internal.Codebase.UI.MainUI.LoadingCurtain;

namespace Internal.Codebase.Infrastructure.Factories
{
    public interface IMainUIFactory
    {
        public Curtain CreateCurtain();
    }
}