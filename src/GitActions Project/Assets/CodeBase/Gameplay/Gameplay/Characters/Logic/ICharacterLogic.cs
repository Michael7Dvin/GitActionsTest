using System;

namespace CodeBase.Gameplay.Gameplay.Characters.Logic
{
    public interface ICharacterLogic
    {
        public event Action Died;
    }
}