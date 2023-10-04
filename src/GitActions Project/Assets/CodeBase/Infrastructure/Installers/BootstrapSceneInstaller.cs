using UnityEngine;
using UnityEngine.AddressableAssets;
using VContainer;
using VContainer.Unity;

namespace CodeBase.Infrastructure.Installers
{
    public class BootstrapSceneInstaller : LifetimeScope
    {
        [SerializeField] private AssetReference _mainScene;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<Bootstrapper>(Lifetime.Singleton).AsImplementedInterfaces().WithParameter(_mainScene);
        }
    }
}