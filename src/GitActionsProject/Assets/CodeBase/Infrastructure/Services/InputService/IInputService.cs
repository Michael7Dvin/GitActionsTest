using System;

namespace CodeBase.Infrastructure.Services.InputService
{
    public interface IInputService
    {
        event Action SpacePressed;
        void Initialize();
    }
}