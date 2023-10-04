using System;
using CodeBase.Gameplay.Gameplay.Characters.Logic;

namespace CodeBase.Gameplay.Gameplay.Characters.CharacterInfo
{
    public class CharacterLogic : ICharacterLogic
    {
        public event Action Died;
    }
}