using CodeBase.Gameplay.Gameplay.Characters.CharacterInfo;
using CodeBase.Gameplay.Gameplay.Characters.Logic;
using UnityEngine;

namespace CodeBase.Gameplay.Gameplay.Characters
{
    public interface ICharacter
    {
        public CharacterID CharacterID { get; }
        public CharacterTeam CharacterTeam { get; }
        public MovementStats MovementStats { get; }
        
        public CharacterStats CharacterStats { get; }
        
        public ICharacterLogic CharacterLogic { get; }
        public Transform Transform { get; }
        public Vector2Int Coordinate { get; }
        void UpdateCoordinate(Vector2Int coordinate);
    }
}