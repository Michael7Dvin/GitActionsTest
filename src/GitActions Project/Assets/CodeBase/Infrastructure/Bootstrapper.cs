using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;
using VContainer.Unity;

namespace CodeBase.Infrastructure
{
    public class Bootstrapper : IInitializable
    {
        private AssetReference _mainScene;

        public Bootstrapper(AssetReference mainScene)
        {
            _mainScene = mainScene;
        }

        public void Initialize()
        {
            Addressables.LoadSceneAsync(_mainScene);
        }
    }
}