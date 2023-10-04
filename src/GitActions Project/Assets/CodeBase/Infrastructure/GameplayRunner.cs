using CodeBase.Gameplay;
using CodeBase.Infrastructure.Services.InputService;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace CodeBase.Infrastructure
{
    public class GameplayRunner : IInitializable
    {
        private readonly IObjectResolver _objectResolver;
        private readonly IInputService _inputService;
        private readonly Health _health;
        private readonly float _damage;

        public GameplayRunner(IObjectResolver objectResolver, IInputService inputService, Health health, float damage)
        {
            _objectResolver = objectResolver;
            _inputService = inputService;
            _health = health;
            _damage = damage;
        }

        public void Initialize()
        {
            _inputService.Initialize();
            
            Damager damager = new(_health, _damage);
            _objectResolver.Inject(damager);
            damager.Initialize();
            
            Debug.Log("initialze");
        }
    }
}