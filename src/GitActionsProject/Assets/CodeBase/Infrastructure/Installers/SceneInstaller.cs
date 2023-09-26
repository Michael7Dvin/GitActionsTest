using CodeBase.Gameplay;
using CodeBase.Infrastructure.Services.InputService;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace CodeBase.Infrastructure.Installers
{
    public class SceneInstaller : LifetimeScope
    {
        [SerializeField] private Health _health;
        [SerializeField] private float _damage;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<IInputService, InputService>(Lifetime.Singleton);
            
            builder
                .Register<Bootstrapper>(Lifetime.Singleton)
                .AsImplementedInterfaces()
                .WithParameter(_health)
                .WithParameter(_damage);
        }
    }
}