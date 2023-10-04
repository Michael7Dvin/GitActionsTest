using System.Collections.Generic;
using CodeBase.Gameplay.Gameplay.Characters.CharacterInfo;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace CodeBase.Gameplay.Gameplay.Characters
{
    [CreateAssetMenu(menuName = "StaticData/Configs/Characters/All", fileName = "AllCharactersConfigs")]
    public class AllCharactersConfigs : SerializedScriptableObject
    {
        [OdinSerialize] public Dictionary<CharacterID, CharacterConfig> CharacterConfigs;
    }
}