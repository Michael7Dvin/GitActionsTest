using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CodeBase.Infrastructure.Services.InputService
{
    public class InputService : IInputService
    {
        private readonly PlayerInput _input = new();
    
        public event Action SpacePressed;
    
        public void Initialize()
        {
            _input.Enable();
            _input.Common.Space.performed += OnSpacePerformed;
            //_input.Common.Space.started += OnSpacePerformed;
        }

        private void OnSpacePerformed(InputAction.CallbackContext context)
        {
            Debug.Log("space");
            SpacePressed?.Invoke();
        }
    }
}