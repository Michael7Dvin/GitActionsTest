using System;
using UnityEngine;

namespace CodeBase.Gameplay
{
    public class Health : MonoBehaviour
    {
        public float Value;
        private bool _isDied;
        
        public event Action<float> HealthChanged; 
        public event Action Died;
        
        public void TakeDamage(float damage)
        {
            if (_isDied == true)
                return;
            
            if (damage <= 0)
            {
                Debug.LogError($"{nameof(damage)} should be above zero");
                throw new ArgumentException();
            }

            float newHealth = Value - damage;
        
            if (newHealth <= 0)
            {
                Value = 0f;
                HealthChanged?.Invoke(Value);
                _isDied = true;
                Died?.Invoke();
                return;
            }

            Value = newHealth;
            HealthChanged?.Invoke(Value);
        }
    }
}
