using CodeBase.Infrastructure.Services.InputService;
using VContainer;

namespace CodeBase.Gameplay
{
    public class Damager
    {
        private IInputService _inputService;
        private readonly Health _health;
        private readonly float _damage;

        [Inject]
        public void InjectDependencies(IInputService inputService)
        {
            _inputService = inputService;
        }

        public Damager(Health health, float damage)
        {
            _health = health;
            _damage = damage;
        }

        public void Initialize()
        {
            _inputService.SpacePressed += OnSpacePressed;
        }

        private void OnSpacePressed() => 
            _health.TakeDamage(_damage);
    }
}