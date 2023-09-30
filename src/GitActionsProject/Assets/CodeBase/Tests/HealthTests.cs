using CodeBase.Gameplay;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;

namespace CodeBase.Tests
{
    public class HealthTests
    {
        [Test]
        public void WhenTakingDamage_AndDamageLessThanHealth_ThenNewHealthEqualsHealthMinusDamage()
        {
            // Arrange.
            float initialHealthValue = 100f;
            float damage = 5f;
            
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(typeof(Health));
            Health health = Substitute.For<Health>();
            health.Value = initialHealthValue;

            // Act.
            health.TakeDamage(damage);
            
            // Assert.
            health.Value.Should().Be(initialHealthValue - damage);
        }
    }
}