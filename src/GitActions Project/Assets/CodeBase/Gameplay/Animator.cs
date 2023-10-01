using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace CodeBase.Gameplay
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Animator : MonoBehaviour
    {
        [SerializeField] private Health _health;
        [SerializeField] private Color _spin;
        [SerializeField] private Color _normal;
        [SerializeField] private Color _dead;

        private SpriteRenderer _renderer;

        private CancellationTokenSource _source;
        
        private void Awake()
        {
            _renderer = GetComponent<SpriteRenderer>();
            _renderer.color = _normal;
        }

        private void OnEnable()
        {
            _health.HealthChanged += Animate;
            _health.Died += OnDied;
        }

        private async void OnDied()
        {
            await UniTask.Delay(500);
            _source.Cancel();
            _source.Dispose();
            _renderer.color = _dead;
        }

        private async void Animate(float health)
        {
            Debug.Log($"Health changed: {health}");
            _renderer.color = _spin;

            _source = new CancellationTokenSource();
            await GetAnimation(_source);
        }

        private UniTask GetAnimation(CancellationTokenSource source)
        {
            float z = transform.rotation.eulerAngles.z;

            return transform
                .DORotate(new Vector3(0f, 0f, z + 90f), 1f)
                .OnComplete(() => _renderer.color = _normal)
                .ToUniTask(TweenCancelBehaviour.Kill, source.Token);
        }
    }
}